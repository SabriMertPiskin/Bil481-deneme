from bokeh.plotting import figure,show
from bokeh.models import WMTSTileSource
import pandas as pd
import numpy as np
import xyzservices.providers as xyz
import math

coordinates = x_range, y_range = ((-13884029,-7453304),(2698291,6455972))
p = figure(tools="wheel_zoom,pan",x_range=x_range,y_range=y_range,x_axis_type="mercator",y_axis_type="mercator",height_policy="max",width_policy="max")
url = "http://a.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}.png"
attribution = "Tiles by Carto, under CC by 3.0. Data by OSM, under ODbL"


def setStartingCoordinates(lat,lon): 
    x_center, y_center = wgs84_to_web_mercator2(lat,lon) #ankara merkezli yapmak
    x_range_start = x_center - (x_range[1] - x_range[0]) / 2
    y_range_start = y_center - (y_range[1] - y_range[0]) / 2
    p.x_range.start = x_range_start
    p.x_range.end = x_range_start + (x_range[1] - x_range[0])
    p.y_range.start = y_range_start
    p.y_range.end = y_range_start + (y_range[1] - y_range[0])



def wgs84_to_web_mercator(df, lon="lon", lat="lat"):#lan lon decimaldan converter
    k = 6378137
    df["x"] = df[lon] * (k * np.pi/180.0)
    df["y"] = np.log(np.tan((90 + df[lat]) * np.pi/360.0)) * k
    return df
def wgs84_to_web_mercator2(lon="lon", lat="lat"):#lan lon decimaldan converter w.o. df
    k = 6378137
    x = lon * (k * np.pi/180.0)
    y = np.log(np.tan((90 + lat) * np.pi/360.0)) * k
    return x,y
 
   
def haritaOlustur():
    
    p.add_tile(WMTSTileSource(url=url,attribution=attribution))
    
    show(p)
def elemanEkle(lan,lon,planeName): #uçak lan lonları buna verilecek
    data = dict(name = "NYC", lat = lan,lon = lon,index=[0])
    df = pd.DataFrame(data)
    newdf = wgs84_to_web_mercator(df)
    p.circle(x=newdf['x'],y=newdf['y'],fill_color="firebrick",size=15)
ankara_kor = 39.9334, 32.8597
setStartingCoordinates(ankara_kor[0],ankara_kor[1])
nycKor = 40.728333,-73.994167
elemanEkle(nycKor[0], nycKor[1],"ucakNewYork")
haritaOlustur()
