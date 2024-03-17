from bokeh.plotting import figure, show
from bokeh.models import WMTSTileSource, HoverTool, ColumnDataSource
import pandas as pd
import numpy as np

# Define constants
URL = "http://a.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}.png"
ATTRIBUTION = "Tiles by Carto, under CC by 3.0. Data by OSM, under ODbL"
COORDINATES = x_range, y_range = ((-13884029, -7453304), (2698291, 6455972))
ANKARA_COORDINATES = (39.9334, 32.8597)

# Create Bokeh figure
p = figure(tools="wheel_zoom,pan", x_range=x_range, y_range=y_range,
           x_axis_type="mercator", y_axis_type="mercator",
           height_policy="max", width_policy="max")

def setStartingCoordinates(lat, lon):
    x_center, y_center = wgs84_to_web_mercator2(lat, lon)
    x_range_start = x_center - (x_range[1] - x_range[0]) / 2
    y_range_start = y_center - (y_range[1] - y_range[0]) / 2
    p.x_range.start = x_range_start
    p.x_range.end = x_range_start + (x_range[1] - x_range[0])
    p.y_range.start = y_range_start
    p.y_range.end = y_range_start + (y_range[1] - y_range[0])

def wgs84_to_web_mercator2(lon, lat):
    k = 6378137
    x = lon * (k * np.pi / 180.0)
    y = np.log(np.tan((90 + lat) * np.pi / 360.0)) * k
    return x, y

def haritaOlustur():
    p.add_tile(WMTSTileSource(url=URL, attribution=ATTRIBUTION))
    show(p)

def elemanEkle(lan, lon, address, planeName):
    data = dict(name=planeName, lat=[lan], lon=[lon], address=[address])
    df = pd.DataFrame(data)
    newdf = wgs84_to_web_mercator(df)
    source = ColumnDataSource(newdf)
    p.circle(x='x', y='y', fill_color="green", size=15, source=source)
    hover = HoverTool(tooltips=[('Address', '@address')])
    p.add_tools(hover)
    

def wgs84_to_web_mercator(df, lon="lon", lat="lat"):
    k = 6378137
    df["x"] = df[lon] * (k * np.pi / 180.0)
    df["y"] = np.log(np.tan((90 + df[lat]) * np.pi / 360.0)) * k
    return df

# Set starting coordinates and display map
setStartingCoordinates(*ANKARA_COORDINATES)

# Add airplane coordinates and display map
nycKor = (40.728333, -73.994167)
elemanEkle(*nycKor, "40.728333, -73.994167", "ucakNewYork")
haritaOlustur()
