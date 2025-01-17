// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class TransitIntegratedDirectionResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public TransitIntegratedDirectionResponseBodyData Data { get; set; }
        public class TransitIntegratedDirectionResponseBodyData : TeaModel {
            [NameInMap("cost")]
            [Validation(Required=false)]
            public TransitIntegratedDirectionResponseBodyDataCost Cost { get; set; }
            public class TransitIntegratedDirectionResponseBodyDataCost : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1231</para>
                /// </summary>
                [NameInMap("durationSecond")]
                [Validation(Required=false)]
                public string DurationSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("taxiFee")]
                [Validation(Required=false)]
                public string TaxiFee { get; set; }

                [NameInMap("tollDistanceMeter")]
                [Validation(Required=false)]
                public string TollDistanceMeter { get; set; }

                [NameInMap("tollRoads")]
                [Validation(Required=false)]
                public string TollRoads { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("tolls")]
                [Validation(Required=false)]
                public string Tolls { get; set; }

                [NameInMap("trafficLights")]
                [Validation(Required=false)]
                public string TrafficLights { get; set; }

                [NameInMap("transitFee")]
                [Validation(Required=false)]
                public string TransitFee { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>39.995197</para>
            /// </summary>
            [NameInMap("destinationLatitude")]
            [Validation(Required=false)]
            public string DestinationLatitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>116.46424</para>
            /// </summary>
            [NameInMap("destinationLongitude")]
            [Validation(Required=false)]
            public string DestinationLongitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>445</para>
            /// </summary>
            [NameInMap("distanceMeter")]
            [Validation(Required=false)]
            public string DistanceMeter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>39.995197</para>
            /// </summary>
            [NameInMap("originLatitude")]
            [Validation(Required=false)]
            public string OriginLatitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>116.466485</para>
            /// </summary>
            [NameInMap("originLongitude")]
            [Validation(Required=false)]
            public string OriginLongitude { get; set; }

            [NameInMap("paths")]
            [Validation(Required=false)]
            public List<TransitIntegratedDirectionResponseBodyDataPaths> Paths { get; set; }
            public class TransitIntegratedDirectionResponseBodyDataPaths : TeaModel {
                [NameInMap("cost")]
                [Validation(Required=false)]
                public TransitIntegratedDirectionResponseBodyDataPathsCost Cost { get; set; }
                public class TransitIntegratedDirectionResponseBodyDataPathsCost : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>39233</para>
                    /// </summary>
                    [NameInMap("durationSecond")]
                    [Validation(Required=false)]
                    public string DurationSecond { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("taxiFee")]
                    [Validation(Required=false)]
                    public string TaxiFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("tollDistanceMeter")]
                    [Validation(Required=false)]
                    public string TollDistanceMeter { get; set; }

                    [NameInMap("tollRoads")]
                    [Validation(Required=false)]
                    public string TollRoads { get; set; }

                    [NameInMap("tolls")]
                    [Validation(Required=false)]
                    public string Tolls { get; set; }

                    [NameInMap("trafficLights")]
                    [Validation(Required=false)]
                    public string TrafficLights { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("transitFee")]
                    [Validation(Required=false)]
                    public string TransitFee { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12000</para>
                /// </summary>
                [NameInMap("distanceMeter")]
                [Validation(Required=false)]
                public string DistanceMeter { get; set; }

                [NameInMap("nightflag")]
                [Validation(Required=false)]
                public string Nightflag { get; set; }

                [NameInMap("segments")]
                [Validation(Required=false)]
                public List<TransitIntegratedDirectionResponseBodyDataPathsSegments> Segments { get; set; }
                public class TransitIntegratedDirectionResponseBodyDataPathsSegments : TeaModel {
                    [NameInMap("bus")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBus Bus { get; set; }
                    public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBus : TeaModel {
                        [NameInMap("buslines")]
                        [Validation(Required=false)]
                        public List<TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslines> Buslines { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslines : TeaModel {
                            [NameInMap("arrivalStop")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesArrivalStop ArrivalStop { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesArrivalStop : TeaModel {
                                [NameInMap("exit")]
                                [Validation(Required=false)]
                                public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesArrivalStopExit Exit { get; set; }
                                public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesArrivalStopExit : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>900000028907015</para>
                                    /// </summary>
                                    [NameInMap("id")]
                                    [Validation(Required=false)]
                                    public string Id { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>116.468213,39.998876</para>
                                    /// </summary>
                                    [NameInMap("location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    [NameInMap("name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100935</para>
                                /// </summary>
                                [NameInMap("id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>119.82416178385417,30.27139702690972</para>
                                /// </summary>
                                [NameInMap("location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            [NameInMap("busTimeTips")]
                            [Validation(Required=false)]
                            public string BusTimeTips { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("bustimetag")]
                            [Validation(Required=false)]
                            public string Bustimetag { get; set; }

                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesCost Cost { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesCost : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1521</para>
                                /// </summary>
                                [NameInMap("durationSecond")]
                                [Validation(Required=false)]
                                public string DurationSecond { get; set; }

                                [NameInMap("taxiFee")]
                                [Validation(Required=false)]
                                public string TaxiFee { get; set; }

                                [NameInMap("tollDistanceMeter")]
                                [Validation(Required=false)]
                                public string TollDistanceMeter { get; set; }

                                [NameInMap("tollRoads")]
                                [Validation(Required=false)]
                                public string TollRoads { get; set; }

                                [NameInMap("tolls")]
                                [Validation(Required=false)]
                                public string Tolls { get; set; }

                                [NameInMap("trafficLights")]
                                [Validation(Required=false)]
                                public string TrafficLights { get; set; }

                                [NameInMap("transitFee")]
                                [Validation(Required=false)]
                                public string TransitFee { get; set; }

                            }

                            [NameInMap("departureStop")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesDepartureStop DepartureStop { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesDepartureStop : TeaModel {
                                [NameInMap("entrance")]
                                [Validation(Required=false)]
                                public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesDepartureStopEntrance Entrance { get; set; }
                                public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesDepartureStopEntrance : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>99088345834</para>
                                    /// </summary>
                                    [NameInMap("id")]
                                    [Validation(Required=false)]
                                    public string Id { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>116.468213,39.998876</para>
                                    /// </summary>
                                    [NameInMap("location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    [NameInMap("name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>60852</para>
                                /// </summary>
                                [NameInMap("id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>116.468213,39.998876</para>
                                /// </summary>
                                [NameInMap("location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>13322</para>
                            /// </summary>
                            [NameInMap("distanceMeter")]
                            [Validation(Required=false)]
                            public string DistanceMeter { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2259</para>
                            /// </summary>
                            [NameInMap("endTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>900000028907</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("polyline")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesPolyline Polyline { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesPolyline : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>116.471544,39.991835</para>
                                /// </summary>
                                [NameInMap("polyline")]
                                [Validation(Required=false)]
                                public string Polyline { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0509</para>
                            /// </summary>
                            [NameInMap("startTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>8</para>
                            /// </summary>
                            [NameInMap("viaNum")]
                            [Validation(Required=false)]
                            public string ViaNum { get; set; }

                            [NameInMap("viaStops")]
                            [Validation(Required=false)]
                            public List<TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesViaStops> ViaStops { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsBusBuslinesViaStops : TeaModel {
                                [NameInMap("id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                [NameInMap("location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                        }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                    }

                    [NameInMap("railway")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailway Railway { get; set; }
                    public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailway : TeaModel {
                        [NameInMap("arrivalStop")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwayArrivalStop ArrivalStop { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwayArrivalStop : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>023</para>
                            /// </summary>
                            [NameInMap("adcode")]
                            [Validation(Required=false)]
                            public string Adcode { get; set; }

                            /// <summary>
                            /// <para>end</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1699410466578</para>
                            /// </summary>
                            [NameInMap("end")]
                            [Validation(Required=false)]
                            public string End { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>8234837534</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>101.45625135633681,25.08939480251736</para>
                            /// </summary>
                            [NameInMap("location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2024-10-28 10:10:32</para>
                            /// </summary>
                            [NameInMap("time")]
                            [Validation(Required=false)]
                            public string Time { get; set; }

                        }

                        [NameInMap("departureStop")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwayDepartureStop DepartureStop { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwayDepartureStop : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>029</para>
                            /// </summary>
                            [NameInMap("adcode")]
                            [Validation(Required=false)]
                            public string Adcode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100937</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>101.45625135633681,25.08939480251736</para>
                            /// </summary>
                            [NameInMap("location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1729440000000</para>
                            /// </summary>
                            [NameInMap("start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2024-09-30 10:04:13</para>
                            /// </summary>
                            [NameInMap("time")]
                            [Validation(Required=false)]
                            public string Time { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>398734</para>
                        /// </summary>
                        [NameInMap("distanceMeter")]
                        [Validation(Required=false)]
                        public string DistanceMeter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>434508</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("spaces")]
                        [Validation(Required=false)]
                        public List<TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwaySpaces> Spaces { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsRailwaySpaces : TeaModel {
                            [NameInMap("code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>150</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public string Cost { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-09-28 10:07:22</para>
                        /// </summary>
                        [NameInMap("time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                        [NameInMap("trip")]
                        [Validation(Required=false)]
                        public string Trip { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("taxi")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionResponseBodyDataPathsSegmentsTaxi Taxi { get; set; }
                    public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsTaxi : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("destinationName")]
                        [Validation(Required=false)]
                        public string DestinationName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.464297,39.896458</para>
                        /// </summary>
                        [NameInMap("destinationPoint")]
                        [Validation(Required=false)]
                        public string DestinationPoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1772</para>
                        /// </summary>
                        [NameInMap("distanceMeter")]
                        [Validation(Required=false)]
                        public string DistanceMeter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>720</para>
                        /// </summary>
                        [NameInMap("driveTimeSecond")]
                        [Validation(Required=false)]
                        public string DriveTimeSecond { get; set; }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        [NameInMap("originName")]
                        [Validation(Required=false)]
                        public string OriginName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.476597,39.893420</para>
                        /// </summary>
                        [NameInMap("originPoint")]
                        [Validation(Required=false)]
                        public string OriginPoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>13.5</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                    }

                    [NameInMap("walking")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalking Walking { get; set; }
                    public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalking : TeaModel {
                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingCost Cost { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingCost : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>468</para>
                            /// </summary>
                            [NameInMap("durationSecond")]
                            [Validation(Required=false)]
                            public string DurationSecond { get; set; }

                            [NameInMap("taxiFee")]
                            [Validation(Required=false)]
                            public string TaxiFee { get; set; }

                            [NameInMap("tollDistanceMeter")]
                            [Validation(Required=false)]
                            public string TollDistanceMeter { get; set; }

                            [NameInMap("tollRoads")]
                            [Validation(Required=false)]
                            public string TollRoads { get; set; }

                            [NameInMap("tolls")]
                            [Validation(Required=false)]
                            public string Tolls { get; set; }

                            [NameInMap("trafficLights")]
                            [Validation(Required=false)]
                            public string TrafficLights { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("transitFee")]
                            [Validation(Required=false)]
                            public string TransitFee { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.468208,39.998875</para>
                        /// </summary>
                        [NameInMap("destination")]
                        [Validation(Required=false)]
                        public string Destination { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>546</para>
                        /// </summary>
                        [NameInMap("distanceMeter")]
                        [Validation(Required=false)]
                        public string DistanceMeter { get; set; }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.466568,39.995552</para>
                        /// </summary>
                        [NameInMap("origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        [NameInMap("steps")]
                        [Validation(Required=false)]
                        public List<TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingSteps> Steps { get; set; }
                        public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingSteps : TeaModel {
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingStepsCost Cost { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingStepsCost : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>435</para>
                                /// </summary>
                                [NameInMap("durationSecond")]
                                [Validation(Required=false)]
                                public string DurationSecond { get; set; }

                                [NameInMap("taxiFee")]
                                [Validation(Required=false)]
                                public string TaxiFee { get; set; }

                                [NameInMap("tollDistanceMeter")]
                                [Validation(Required=false)]
                                public string TollDistanceMeter { get; set; }

                                [NameInMap("tollRoads")]
                                [Validation(Required=false)]
                                public string TollRoads { get; set; }

                                [NameInMap("tolls")]
                                [Validation(Required=false)]
                                public string Tolls { get; set; }

                                [NameInMap("trafficLights")]
                                [Validation(Required=false)]
                                public string TrafficLights { get; set; }

                                [NameInMap("transitFee")]
                                [Validation(Required=false)]
                                public string TransitFee { get; set; }

                            }

                            [NameInMap("instruction")]
                            [Validation(Required=false)]
                            public string Instruction { get; set; }

                            [NameInMap("orientation")]
                            [Validation(Required=false)]
                            public string Orientation { get; set; }

                            [NameInMap("polyline")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingStepsPolyline Polyline { get; set; }
                            public class TransitIntegratedDirectionResponseBodyDataPathsSegmentsWalkingStepsPolyline : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>116.467751,39.997631;116.467430,39.997631</para>
                                /// </summary>
                                [NameInMap("polyline")]
                                [Validation(Required=false)]
                                public string Polyline { get; set; }

                            }

                            [NameInMap("roadName")]
                            [Validation(Required=false)]
                            public string RoadName { get; set; }

                            [NameInMap("stepDistanceMeter")]
                            [Validation(Required=false)]
                            public string StepDistanceMeter { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23435</para>
                /// </summary>
                [NameInMap("walkingDistanceMeter")]
                [Validation(Required=false)]
                public string WalkingDistanceMeter { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <title>502 Bad Gateway</title>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
