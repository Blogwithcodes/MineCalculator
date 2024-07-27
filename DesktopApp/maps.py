import folium
import numpy as np
from scipy.spatial import ConvexHull
from folium.plugins import MarkerCluster

def generate_map():
    # Initial coordinates for the landmark
    lm_lat = 25.32665
    lm_long = 74.32849

    # Define the table data for all flows
    data = [
        # Flow 1
        {"Source": "LM", "Destination": "9P", "Bearing": 48, "Distance": 150},
        {"Source": "9P", "Destination": "SSM1", "Bearing": 60, "Distance": 120},
        {"Source": "SSM1", "Destination": "TP₁a", "Bearing": 105, "Distance": 98},
        {"Source": "TP₁a", "Destination": "TP₂a", "Bearing": 60, "Distance": 120},
        {"Source": "TP₂a", "Destination": "TP₃a", "Bearing": 80, "Distance": 145},
        {"Source": "TP₃a", "Destination": "ESM₁", "Bearing": 48, "Distance": 130},
        # Flow 2
        {"Source": "LM", "Destination": "SSM₂", "Bearing": 75, "Distance": 180},
        {"Source": "SSM₂", "Destination": "TP₁b", "Bearing": 91, "Distance": 100},
        {"Source": "TP₁b", "Destination": "TP₂b", "Bearing": 40, "Distance": 120},
        {"Source": "TP₂b", "Destination": "TP₃b", "Bearing": 150, "Distance": 40},
        {"Source": "TP₃b", "Destination": "ESM2", "Bearing": 70, "Distance": 180},
        # Flow 3
        {"Source": "LM", "Destination": "SSM3", "Bearing": 94, "Distance": 120},
        {"Source": "SSM3", "Destination": "TP₁c", "Bearing": 91, "Distance": 100},
        {"Source": "TP₁c", "Destination": "TP₂c", "Bearing": 40, "Distance": 60},
        {"Source": "TP₂c", "Destination": "TP₃c", "Bearing": 150, "Distance": 40},
        {"Source": "TP₃c", "Destination": "TP4c", "Bearing": 50, "Distance": 90},
        {"Source": "TP4c", "Destination": "ESM3", "Bearing": 70, "Distance": 180},
    ]

    # Function to calculate new coordinates from bearing and distance
    def calculate_new_coords(lat, long, bearing, distance):
        R = 6378.1  # Radius of the Earth in km
        brng = np.radians(bearing)  # Convert bearing to radians
        d = distance / 1000  # Distance in km

        lat1 = np.radians(lat)  # Current lat point converted to radians
        lon1 = np.radians(long)  # Current long point converted to radians

        lat2 = np.arcsin(np.sin(lat1) * np.cos(d / R) + np.cos(lat1) * np.sin(d / R) * np.cos(brng))
        lon2 = lon1 + np.arctan2(np.sin(brng) * np.sin(d / R) * np.cos(lat1), np.cos(d / R) - np.sin(lat1) * np.sin(lat2))

        lat2 = np.degrees(lat2)
        lon2 = np.degrees(lon2)

        return lat2, lon2

    # Create a map centered at the initial landmark
    m = folium.Map(location=[lm_lat, lm_long], zoom_start=15)

    # List to store all points except LM
    all_points = []

    # Function to add a flow to the map
    def add_flow(data, start_lat, start_long):
        lats = [start_lat]
        longs = [start_long]
        labels = ["LM"]

        for row in data:
            lat, long = calculate_new_coords(lats[-1], longs[-1], row["Bearing"], row["Distance"])
            lats.append(lat)
            longs.append(long)
            labels.append(row["Destination"])

        # Add points to the all_points list except the initial landmark
        for i in range(1, len(lats)):
            all_points.append((lats[i], longs[i]))

        # Add the initial landmark to the map with a tooltip
        folium.Marker(
            location=[start_lat, start_long],
            tooltip="LM",
            icon=folium.Icon(color="red")
        ).add_to(m)

        # Add the rest of the points to the map with tooltips
        for i in range(1, len(labels)):
            folium.Marker(
                location=[lats[i], longs[i]],
                tooltip=f"{labels[i]}",
                icon=folium.Icon(color="blue")
            ).add_to(m)

            # Add polyline with a label on it
            folium.PolyLine(
                locations=[[lats[i - 1], longs[i - 1]], [lats[i], longs[i]]],
                color='blue',
                weight=2
            ).add_to(m)

            # Add a label on the line
            midpoint_lat = (lats[i - 1] + lats[i]) / 2
            midpoint_long = (longs[i - 1] + longs[i]) / 2
            folium.Marker(
                location=[midpoint_lat, midpoint_long],
                icon=folium.DivIcon(
                    html=f'<div style="font-size: 12px; color: blue;">{data[i - 1]["Bearing"]}°<br>{data[i - 1]["Distance"]} m</div>')
            ).add_to(m)

    # Separate the data into different flows
    flows = [
        data[0:6],  # Flow 1
        data[6:11],  # Flow 2
        data[11:17]  # Flow 3
    ]

    # Add each flow to the map
    for flow in flows:
        add_flow(flow, lm_lat, lm_long)

    # Calculate the convex hull to create the boundary
    points = np.array(all_points)
    hull = ConvexHull(points)

    # Calculate the centroid of the points
    centroid = np.mean(points, axis=0)

    # Expand the hull points by a small factor
    expansion_factor = 0.1  # Adjust this factor to expand the boundary
    expanded_points = []

    for point in points[hull.vertices]:
        direction = point - centroid
        expanded_point = point + direction * expansion_factor
        expanded_points.append(expanded_point)

    # Create a boundary around all points except the initial landmark
    boundary = folium.Polygon(locations=expanded_points, color='green', weight=2.5, fill=True, fill_color='green',
                              fill_opacity=0.1)
    boundary.add_to(m)

    # Save the map to an HTML file
    m.save('map_with_expanded_boundaries.html')
