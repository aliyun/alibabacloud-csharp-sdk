// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class DrivingDirectionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DrivingDirectionResponseBodyData> Data { get; set; }
        public class DrivingDirectionResponseBodyData : TeaModel {
            [NameInMap("cost")]
            [Validation(Required=false)]
            public DrivingDirectionResponseBodyDataCost Cost { get; set; }
            public class DrivingDirectionResponseBodyDataCost : TeaModel {
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

            [NameInMap("restriction")]
            [Validation(Required=false)]
            public string Restriction { get; set; }

            [NameInMap("steps")]
            [Validation(Required=false)]
            public List<DrivingDirectionResponseBodyDataSteps> Steps { get; set; }
            public class DrivingDirectionResponseBodyDataSteps : TeaModel {
                [NameInMap("cost")]
                [Validation(Required=false)]
                public DrivingDirectionResponseBodyDataStepsCost Cost { get; set; }
                public class DrivingDirectionResponseBodyDataStepsCost : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>27647</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("tollRoads")]
                    [Validation(Required=false)]
                    public string TollRoads { get; set; }

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
                /// <para>500</para>
                /// </summary>
                [NameInMap("stepDistanceMeter")]
                [Validation(Required=false)]
                public string StepDistanceMeter { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
