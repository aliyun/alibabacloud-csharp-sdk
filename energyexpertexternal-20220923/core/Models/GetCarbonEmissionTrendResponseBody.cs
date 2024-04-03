// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetCarbonEmissionTrendResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCarbonEmissionTrendResponseBodyData Data { get; set; }
        public class GetCarbonEmissionTrendResponseBodyData : TeaModel {
            /// <summary>
            /// Actual emission list.
            /// </summary>
            [NameInMap("actualEmissionList")]
            [Validation(Required=false)]
            public List<GetCarbonEmissionTrendResponseBodyDataActualEmissionList> ActualEmissionList { get; set; }
            public class GetCarbonEmissionTrendResponseBodyDataActualEmissionList : TeaModel {
                /// <summary>
                /// Data item list.
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetCarbonEmissionTrendResponseBodyDataActualEmissionListItems> Items { get; set; }
                public class GetCarbonEmissionTrendResponseBodyDataActualEmissionListItems : TeaModel {
                    /// <summary>
                    /// Carbon emissions.
                    /// </summary>
                    [NameInMap("carbonEmissionData")]
                    [Validation(Required=false)]
                    public double? CarbonEmissionData { get; set; }

                    /// <summary>
                    /// The month.
                    /// </summary>
                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// The year.
                    /// </summary>
                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public string Year { get; set; }

                }

                /// <summary>
                /// The year.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Target Emission List.
            /// </summary>
            [NameInMap("targetEmissionList")]
            [Validation(Required=false)]
            public List<GetCarbonEmissionTrendResponseBodyDataTargetEmissionList> TargetEmissionList { get; set; }
            public class GetCarbonEmissionTrendResponseBodyDataTargetEmissionList : TeaModel {
                /// <summary>
                /// Data item list.
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetCarbonEmissionTrendResponseBodyDataTargetEmissionListItems> Items { get; set; }
                public class GetCarbonEmissionTrendResponseBodyDataTargetEmissionListItems : TeaModel {
                    /// <summary>
                    /// Carbon emissions.
                    /// </summary>
                    [NameInMap("carbonEmissionData")]
                    [Validation(Required=false)]
                    public double? CarbonEmissionData { get; set; }

                    /// <summary>
                    /// The month.
                    /// </summary>
                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// The year.
                    /// </summary>
                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public string Year { get; set; }

                }

                /// <summary>
                /// The year.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

        }

        /// <summary>
        /// Id of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
