using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBERPOINTERIZER
{
        public static class UberAPIReader
        {
            public static List<Cab> interpreteMessage(String message, List<String> uberCabTypesToParse)
            {
                List<Cab> newCabs = new List<Cab>();
                var deSerialized = System.Web.Helpers.Json.Decode(message);

                for (int i = 0; i < uberCabTypesToParse.Count; i++)
                {
                    var xCab = Dynamitey.Dynamic.InvokeGet(deSerialized.nearbyVehicles, uberCabTypesToParse[i]);
                    List<String> cabIDs = getPropertiesNameOfClass(xCab.vehiclePaths);
                    for (int ix = 0; ix < cabIDs.Count; ix++)
                    {
                        Cab currentCab = new Cab();
                        currentCab.cabIdentifier = cabIDs[ix];
                        var cabType = Dynamitey.Dynamic.InvokeGet(deSerialized.nearbyVehicles, uberCabTypesToParse[i]);
                        var specificCab = Dynamitey.Dynamic.InvokeGet(cabType.vehiclePaths, cabIDs[ix]);
                        int updatesInMessageForSpecificCab = specificCab.Length;
                        for (int ixy = 0; ixy < updatesInMessageForSpecificCab; ixy++)
                        {
                            currentCab.epoch.Add(Convert.ToInt64(specificCab[ixy].epoch));
                            currentCab.lat.Add(Convert.ToDouble(specificCab[ixy].latitude));
                            currentCab.lon.Add(Convert.ToDouble(specificCab[ixy].longitude));
                            currentCab.heading.Add(Convert.ToInt32(specificCab[ixy].course));
                        }
                        newCabs.Add(currentCab);
                    }
                }

                return newCabs;
            }
            public static List<String> getUberCabTypeIdentifiers(String sampleMessage)
            {
                var deSerialized = System.Web.Helpers.Json.Decode(sampleMessage);
                List<String> uberCabTypes = getPropertiesNameOfClass(deSerialized.city.vehicleViews);
                return uberCabTypes;
            }

            public static List<String> getPropertiesNameOfClass(object pObject)
            {
                List<String> propertyList = new List<String>();
                if (pObject != null)
                {
                    IEnumerable<string> prop = Dynamitey.Dynamic.GetMemberNames(pObject);
                    propertyList = prop.ToList();
                }
                return propertyList;
            }

            public static List<String> getUberCabTypeNames(String sampleMessage, List<String> identifiers)
            {
                var deSerialized = System.Web.Helpers.Json.Decode(sampleMessage);
                List<String> uberCabTypes = new List<String>();
                for (int i = 0; i < uberCabTypes.Count; i++) { uberCabTypes.Add(deSerialized.city.vehicleViews.GetType().GetProperty(uberCabTypes.ElementAt(i)).displayName); }
                return uberCabTypes;
            }

            public static List<Cab> updateCabListWithNewList(List<Cab> currentList, List<Cab> newList)
            {
                Cab newCab;
                for (int i = 0; i < newList.Count; i++)
                {
                    newCab = newList[i];

                    for (int ix = 0; ix < currentList.Count; ix++)
                    {
                        if (newCab.cabIdentifier.Equals(currentList[ix].cabIdentifier))
                        {
                            for (int ixy = 0; ixy < newCab.epoch.Count; ixy++)
                            {
                                if (newCab.epoch[ixy] > currentList[ix].epoch[currentList[ix].epoch.Count() - 1])
                                {
                                    currentList[ix].epoch.Add(newCab.epoch[ixy]);
                                    currentList[ix].lat.Add(newCab.lat[ixy]);
                                    currentList[ix].lon.Add(newCab.lon[ixy]);
                                    currentList[ix].heading.Add(newCab.heading[ixy]);
                                    currentList[ix].updateType.Add(1);
                                }
                            }
                            break;
                        }
                        else if (ix == (currentList.Count - 1))
                        {
                            currentList.Add(newCab);
                        }
                    }
                }
                if (currentList.Count() == 0) { currentList = newList; }
                return currentList;
            }
        }
}
