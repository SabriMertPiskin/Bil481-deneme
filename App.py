from manipulation import Data_for_aircraft as dfa
from map import elemanEkle, haritaOlustur, setStartingCoordinates

Aircraft_Tuples, m1, m2 = dfa.returnAircrafData()

setStartingCoordinates(m1, m2)
#print(Aircraft_Tuples.keys())


for key in Aircraft_Tuples:
    (NormalAircraft,ManipulatedAircraft) = Aircraft_Tuples[key]
    print(f"{NormalAircraft.latitude} {ManipulatedAircraft.latitude}")
    elemanEkle(NormalAircraft.latitude, NormalAircraft.longitude, key, NormalAircraft.velocity, NormalAircraft.geo_altitude, False)
    elemanEkle(ManipulatedAircraft.latitude, ManipulatedAircraft.longitude, key, ManipulatedAircraft.velocity, ManipulatedAircraft.geo_altitude, True)

haritaOlustur()
