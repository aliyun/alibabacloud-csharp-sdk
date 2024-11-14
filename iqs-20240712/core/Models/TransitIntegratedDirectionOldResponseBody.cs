// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class TransitIntegratedDirectionOldResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<TransitIntegratedDirectionOldResponseBodyData> Data { get; set; }
        public class TransitIntegratedDirectionOldResponseBodyData : TeaModel {
            [NameInMap("cost")]
            [Validation(Required=false)]
            public TransitIntegratedDirectionOldResponseBodyDataCost Cost { get; set; }
            public class TransitIntegratedDirectionOldResponseBodyDataCost : TeaModel {
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
            /// <para>445</para>
            /// </summary>
            [NameInMap("distanceMeter")]
            [Validation(Required=false)]
            public string DistanceMeter { get; set; }

            [NameInMap("nightflag")]
            [Validation(Required=false)]
            public string Nightflag { get; set; }

            [NameInMap("segments")]
            [Validation(Required=false)]
            public List<TransitIntegratedDirectionOldResponseBodyDataSegments> Segments { get; set; }
            public class TransitIntegratedDirectionOldResponseBodyDataSegments : TeaModel {
                [NameInMap("bus")]
                [Validation(Required=false)]
                public TransitIntegratedDirectionOldResponseBodyDataSegmentsBus Bus { get; set; }
                public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBus : TeaModel {
                    [NameInMap("buslines")]
                    [Validation(Required=false)]
                    public List<TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslines> Buslines { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslines : TeaModel {
                        [NameInMap("arrivalStop")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesArrivalStop ArrivalStop { get; set; }
                        public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesArrivalStop : TeaModel {
                            [NameInMap("exit")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesArrivalStopExit Exit { get; set; }
                            public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesArrivalStopExit : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>99900009</para>
                                /// </summary>
                                [NameInMap("id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>116.467430,39.997627</para>
                                /// </summary>
                                [NameInMap("location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>review</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>rpe-fu181hrp24i8fc6r38fbsnn</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>116.467430,39.997627</para>
                            /// </summary>
                            [NameInMap("location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>znzmo_cqz</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("busTimeTips")]
                        [Validation(Required=false)]
                        public string BusTimeTips { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>09:00---21:00</para>
                        /// </summary>
                        [NameInMap("bustimetag")]
                        [Validation(Required=false)]
                        public string Bustimetag { get; set; }

                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesCost Cost { get; set; }
                        public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesCost : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>348394</para>
                            /// </summary>
                            [NameInMap("durationSecond")]
                            [Validation(Required=false)]
                            public string DurationSecond { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>12</para>
                            /// </summary>
                            [NameInMap("taxiFee")]
                            [Validation(Required=false)]
                            public string TaxiFee { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>444</para>
                            /// </summary>
                            [NameInMap("tollDistanceMeter")]
                            [Validation(Required=false)]
                            public string TollDistanceMeter { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxx</para>
                            /// </summary>
                            [NameInMap("tollRoads")]
                            [Validation(Required=false)]
                            public string TollRoads { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>34</para>
                            /// </summary>
                            [NameInMap("tolls")]
                            [Validation(Required=false)]
                            public string Tolls { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>4</para>
                            /// </summary>
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

                        [NameInMap("departureStop")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesDepartureStop DepartureStop { get; set; }
                        public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesDepartureStop : TeaModel {
                            [NameInMap("entrance")]
                            [Validation(Required=false)]
                            public TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesDepartureStopEntrance Entrance { get; set; }
                            public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesDepartureStopEntrance : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>124100037</para>
                                /// </summary>
                                [NameInMap("id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>116.467430,39.997627</para>
                                /// </summary>
                                [NameInMap("location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>tyc_cust</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>st-628f075f-11638689</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>116.467430,39.997627</para>
                            /// </summary>
                            [NameInMap("location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1597871211794192-1700571612867-LcFKnaDJRsoAsYpltZzfrc7Ts0TY1DYOrID+QVy0WxxxPOY8+bod62GWhHB1NK1lITs5tu2zIwknT3R9S8XCAA</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3000</para>
                        /// </summary>
                        [NameInMap("distanceMeter")]
                        [Validation(Required=false)]
                        public string DistanceMeter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1710432000000</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1841625</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Sheet1</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1730448000000</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cluster</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("viaNum")]
                        [Validation(Required=false)]
                        public string ViaNum { get; set; }

                        [NameInMap("viaStops")]
                        [Validation(Required=false)]
                        public List<TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesViaStops> ViaStops { get; set; }
                        public class TransitIntegratedDirectionOldResponseBodyDataSegmentsBusBuslinesViaStops : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>136200191</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>114.23980387369792,30.60205837673611</para>
                            /// </summary>
                            [NameInMap("location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>WordsWeightTest</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                }

                [NameInMap("railway")]
                [Validation(Required=false)]
                public TransitIntegratedDirectionOldResponseBodyDataSegmentsRailway Railway { get; set; }
                public class TransitIntegratedDirectionOldResponseBodyDataSegmentsRailway : TeaModel {
                    [NameInMap("arrivalStop")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwayArrivalStop ArrivalStop { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwayArrivalStop : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100200</para>
                        /// </summary>
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        /// <summary>
                        /// <para>end</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1728553266042</para>
                        /// </summary>
                        [NameInMap("end")]
                        [Validation(Required=false)]
                        public string End { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>138700037</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.467430,39.997627</para>
                        /// </summary>
                        [NameInMap("location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1634343014745990-1699252808337-stack_10340126_20231106144004.log</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-11-09 10:00:46</para>
                        /// </summary>
                        [NameInMap("time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                    }

                    [NameInMap("departureStop")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwayDepartureStop DepartureStop { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwayDepartureStop : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1002200</para>
                        /// </summary>
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>148100008</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>116.467430,39.997627</para>
                        /// </summary>
                        [NameInMap("location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>stop_words</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1727141356337</para>
                        /// </summary>
                        [NameInMap("start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-11-04 10:26:41</para>
                        /// </summary>
                        [NameInMap("time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("distanceMeter")]
                    [Validation(Required=false)]
                    public string DistanceMeter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rpe-kw141hrpoh8vttte2lrvhdb</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hbh_rectify</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("spaces")]
                    [Validation(Required=false)]
                    public List<TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwaySpaces> Spaces { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsRailwaySpaces : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public string Cost { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-11-04 10:26:41</para>
                    /// </summary>
                    [NameInMap("time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4002</para>
                    /// </summary>
                    [NameInMap("trip")]
                    [Validation(Required=false)]
                    public string Trip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OFFLINE_DICT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("taxi")]
                [Validation(Required=false)]
                public TransitIntegratedDirectionOldResponseBodyDataSegmentsTaxi Taxi { get; set; }
                public class TransitIntegratedDirectionOldResponseBodyDataSegmentsTaxi : TeaModel {
                    [NameInMap("destinationName")]
                    [Validation(Required=false)]
                    public string DestinationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>116.461662,39.944807</para>
                    /// </summary>
                    [NameInMap("destinationPoint")]
                    [Validation(Required=false)]
                    public string DestinationPoint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("distanceMeter")]
                    [Validation(Required=false)]
                    public string DistanceMeter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("driveTimeSecond")]
                    [Validation(Required=false)]
                    public string DriveTimeSecond { get; set; }

                    [NameInMap("originName")]
                    [Validation(Required=false)]
                    public string OriginName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>116.461662,39.944807</para>
                    /// </summary>
                    [NameInMap("originPoint")]
                    [Validation(Required=false)]
                    public string OriginPoint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>241000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                }

                [NameInMap("walking")]
                [Validation(Required=false)]
                public TransitIntegratedDirectionOldResponseBodyDataSegmentsWalking Walking { get; set; }
                public class TransitIntegratedDirectionOldResponseBodyDataSegmentsWalking : TeaModel {
                    [NameInMap("cost")]
                    [Validation(Required=false)]
                    public TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingCost Cost { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingCost : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1293</para>
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
                        /// <para>4000</para>
                        /// </summary>
                        [NameInMap("tollDistanceMeter")]
                        [Validation(Required=false)]
                        public string TollDistanceMeter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("tollRoads")]
                        [Validation(Required=false)]
                        public string TollRoads { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1203</para>
                        /// </summary>
                        [NameInMap("tolls")]
                        [Validation(Required=false)]
                        public string Tolls { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
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
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("distanceMeter")]
                    [Validation(Required=false)]
                    public string DistanceMeter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>116.466568,39.995552</para>
                    /// </summary>
                    [NameInMap("origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    [NameInMap("steps")]
                    [Validation(Required=false)]
                    public List<TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingSteps> Steps { get; set; }
                    public class TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingSteps : TeaModel {
                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingStepsCost Cost { get; set; }
                        public class TransitIntegratedDirectionOldResponseBodyDataSegmentsWalkingStepsCost : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3435</para>
                            /// </summary>
                            [NameInMap("durationSecond")]
                            [Validation(Required=false)]
                            public string DurationSecond { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxx</para>
                            /// </summary>
                            [NameInMap("tollRoads")]
                            [Validation(Required=false)]
                            public string TollRoads { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("tolls")]
                            [Validation(Required=false)]
                            public string Tolls { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("trafficLights")]
                            [Validation(Required=false)]
                            public string TrafficLights { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("roadName")]
                        [Validation(Required=false)]
                        public string RoadName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3000</para>
                        /// </summary>
                        [NameInMap("stepDistanceMeter")]
                        [Validation(Required=false)]
                        public string StepDistanceMeter { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11000</para>
            /// </summary>
            [NameInMap("walkingDistanceMeter")]
            [Validation(Required=false)]
            public string WalkingDistanceMeter { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECB2144C-E277-5434-80E6-12D26678D364</para>
        /// </summary>
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
