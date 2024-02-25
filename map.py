from bokeh.plotting import figure,show
from bokeh.models import WMTSTileSource
import pandas as pd
import numpy as np

coordinates = x_range, y_range = ((-13884029,-7453304),(2698291,6455972))
p = figure(tools="wheel_zoom,pan",x_range=x_range,y_range=y_range,x_axis_type="mercator",y_axis_type="mercator")
url = "http://a.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}.png"
attribution = "Tiles by Carto, under CC by 3.0. Data by OSM, under ODbL"
p.add_tile(WMTSTileSource(url=url,attribution=attribution))

def setStartingCoordinates(x1,x2,y1,y2): #BİTMEDİ
    coordinates = x_range, y_range = ((x2-x1),(2698291,6455972))

def wgs84_to_web_mercator(df, lon="lon", lat="lat"):#lan lon decimaldan converter
    k = 6378137
    df["x"] = df[lon] * (k * np.pi/180.0)
    df["y"] = np.log(np.tan((90 + df[lat]) * np.pi/360.0)) * k
    return df
      
def haritaOlustur():  
    show(p)
def elemanEkle(lan,lon): #uçak lan lonları buna verilecek
    nycKor = 40.728333,-73.994167
    data = dict(name = "NYC", lat = nycKor[0],lon = nycKor[1],index=[0])
    df = pd.DataFrame(data)
    newdf = wgs84_to_web_mercator(df)
    p.circle(x=df['x'],y=df['y'],fill_color="firebrick",size=15)
elemanEkle(0,0)
haritaOlustur()
