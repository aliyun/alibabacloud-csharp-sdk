// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class BicyclingDirectionNovaResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public BicyclingDirectionNovaResponseBodyData Data { get; set; }
        public class BicyclingDirectionNovaResponseBodyData : TeaModel {
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
            public List<BicyclingDirectionNovaResponseBodyDataPaths> Paths { get; set; }
            public class BicyclingDirectionNovaResponseBodyDataPaths : TeaModel {
                [NameInMap("cost")]
                [Validation(Required=false)]
                public BicyclingDirectionNovaResponseBodyDataPathsCost Cost { get; set; }
                public class BicyclingDirectionNovaResponseBodyDataPathsCost : TeaModel {
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
                /// <para>96375</para>
                /// </summary>
                [NameInMap("distanceMeter")]
                [Validation(Required=false)]
                public string DistanceMeter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("durationSecond")]
                [Validation(Required=false)]
                public string DurationSecond { get; set; }

                [NameInMap("restriction")]
                [Validation(Required=false)]
                public string Restriction { get; set; }

                [NameInMap("steps")]
                [Validation(Required=false)]
                public List<BicyclingDirectionNovaResponseBodyDataPathsSteps> Steps { get; set; }
                public class BicyclingDirectionNovaResponseBodyDataPathsSteps : TeaModel {
                    [NameInMap("cost")]
                    [Validation(Required=false)]
                    public BicyclingDirectionNovaResponseBodyDataPathsStepsCost Cost { get; set; }
                    public class BicyclingDirectionNovaResponseBodyDataPathsStepsCost : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2000</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("taxiCost")]
            [Validation(Required=false)]
            public string TaxiCost { get; set; }

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
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
