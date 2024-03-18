from bokeh.plotting import figure, show
from bokeh.models import WMTSTileSource, HoverTool, ColumnDataSource,ImageURL,Toolbar,WheelZoomTool
import pandas as pd
import numpy as np

# Define constants
URL = "http://a.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}.png"
ATTRIBUTION = "Tiles by Carto, under CC by 3.0. Data by OSM, under ODbL"
COORDINATES = x_range, y_range = ((-13884029, -7453304), (2698291, 6455972))
ANKARA_COORDINATES = (39.9334, 32.8597)
resim_url = "https://icons.iconarchive.com/icons/iconka/business-finance/24/paper-plane-icon.png" #manipüle edilmiş uçak
resim_url2="https://icons.iconarchive.com/icons/custom-icon-design/flatastic-10/24/Paper-plane-icon.png"#doğru uçak
# Create Bokeh figure
p = figure(tools="pan", x_range=x_range, y_range=y_range,
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
    hover = HoverTool(tooltips=[('Plane Name','@name'),('Lat, Lon', '@address'),('Velocity', '@velocity'),('Altitude', '@altitude')])#add plane name,velocity,altitude
    a = WheelZoomTool()
    p.toolbar.active_scroll = a
    p.add_tools(a)
    p.add_tools(hover)
    p.add_tile(WMTSTileSource(url=URL, attribution=ATTRIBUTION))
    p.toolbar.logo = None
    p.toolbar_location = None
    show(p)

def elemanEkle(lan, lon, planeName, velocity, altitude,angle,isManipulated):
    latlon = str(lan) + " ," + str(lon)
    data = dict(name=planeName, lat=[lan], lon=[lon], address=[latlon], velocity=[velocity], altitude=[altitude])
    df = pd.DataFrame(data)
    newdf = wgs84_to_web_mercator(df)
    source = ColumnDataSource(newdf)
    
    
    
    if(isManipulated == True):
        image1 = ImageURL(url="url", x="x", y="y",anchor="center",angle=180,angle_units='deg')
        p.add_glyph(source, image1)
        p.circle('x','y',source=source,fill_color='red',hover_color='yellow',size=15,fill_alpha=0,line_width=0)
    else:
        image1 = ImageURL(url="url2", x="x", y="y",anchor="center",angle=180,angle_units='deg')
        p.add_glyph(source, image1)
        p.circle('x','y',source=source,fill_color='red',hover_color='yellow',size=15,fill_alpha=0,line_width=0)
  
    

def wgs84_to_web_mercator(df, lon="lon", lat="lat"):
    k = 6378137
    df["x"] = df[lon] * (k * np.pi / 180.0)
    df["y"] = np.log(np.tan((90 + df[lat]) * np.pi / 360.0)) * k
    df["url"] = resim_url
    df["url2"] = resim_url2
    return df

# Set starting coordinates and display map
setStartingCoordinates(*ANKARA_COORDINATES)

# Add airplane coordinates and display map
nycKor = (40.728333, -73.994167)
elemanEkle(*nycKor, "ucakNewYork",50,60,5,True)
elemanEkle(40,-70, "ucakNewYork",50,60,5,False)
haritaOlustur()
