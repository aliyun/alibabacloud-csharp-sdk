// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class DrivingDirectionNovaResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public DrivingDirectionNovaResponseBodyData Data { get; set; }
        public class DrivingDirectionNovaResponseBodyData : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40.345456</para>
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
            /// <para>117.466485</para>
            /// </summary>
            [NameInMap("originLongitude")]
            [Validation(Required=false)]
            public string OriginLongitude { get; set; }

            [NameInMap("paths")]
            [Validation(Required=false)]
            public List<DrivingDirectionNovaResponseBodyDataPaths> Paths { get; set; }
            public class DrivingDirectionNovaResponseBodyDataPaths : TeaModel {
                [NameInMap("cost")]
                [Validation(Required=false)]
                public DrivingDirectionNovaResponseBodyDataPathsCost Cost { get; set; }
                public class DrivingDirectionNovaResponseBodyDataPathsCost : TeaModel {
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("trafficLights")]
                    [Validation(Required=false)]
                    public string TrafficLights { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                /// <para>39223</para>
                /// </summary>
                [NameInMap("durationSecond")]
                [Validation(Required=false)]
                public string DurationSecond { get; set; }

                [NameInMap("restriction")]
                [Validation(Required=false)]
                public string Restriction { get; set; }

                [NameInMap("steps")]
                [Validation(Required=false)]
                public List<DrivingDirectionNovaResponseBodyDataPathsSteps> Steps { get; set; }
                public class DrivingDirectionNovaResponseBodyDataPathsSteps : TeaModel {
                    [NameInMap("cost")]
                    [Validation(Required=false)]
                    public DrivingDirectionNovaResponseBodyDataPathsStepsCost Cost { get; set; }
                    public class DrivingDirectionNovaResponseBodyDataPathsStepsCost : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1234</para>
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

                    [NameInMap("polyline")]
                    [Validation(Required=false)]
                    public string Polyline { get; set; }

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
            /// <para>20</para>
            /// </summary>
            [NameInMap("taxiCost")]
            [Validation(Required=false)]
            public string TaxiCost { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
