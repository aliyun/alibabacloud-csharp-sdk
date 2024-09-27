// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetCarbonEmissionTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCarbonEmissionTrendResponseBodyData Data { get; set; }
        public class GetCarbonEmissionTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Actual emission list.</para>
            /// </summary>
            [NameInMap("actualEmissionList")]
            [Validation(Required=false)]
            public List<GetCarbonEmissionTrendResponseBodyDataActualEmissionList> ActualEmissionList { get; set; }
            public class GetCarbonEmissionTrendResponseBodyDataActualEmissionList : TeaModel {
                /// <summary>
                /// <para>Data item list.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetCarbonEmissionTrendResponseBodyDataActualEmissionListItems> Items { get; set; }
                public class GetCarbonEmissionTrendResponseBodyDataActualEmissionListItems : TeaModel {
                    /// <summary>
                    /// <para>Carbon emissions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.22</para>
                    /// </summary>
                    [NameInMap("carbonEmissionData")]
                    [Validation(Required=false)]
                    public double? CarbonEmissionData { get; set; }

                    /// <summary>
                    /// <para>The month.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <para>The year.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024</para>
                    /// </summary>
                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public string Year { get; set; }

                }

                /// <summary>
                /// <para>The year.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Target Emission List.</para>
            /// </summary>
            [NameInMap("targetEmissionList")]
            [Validation(Required=false)]
            public List<GetCarbonEmissionTrendResponseBodyDataTargetEmissionList> TargetEmissionList { get; set; }
            public class GetCarbonEmissionTrendResponseBodyDataTargetEmissionList : TeaModel {
                /// <summary>
                /// <para>Data item list.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetCarbonEmissionTrendResponseBodyDataTargetEmissionListItems> Items { get; set; }
                public class GetCarbonEmissionTrendResponseBodyDataTargetEmissionListItems : TeaModel {
                    /// <summary>
                    /// <para>Carbon emissions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.22</para>
                    /// </summary>
                    [NameInMap("carbonEmissionData")]
                    [Validation(Required=false)]
                    public double? CarbonEmissionData { get; set; }

                    /// <summary>
                    /// <para>The month.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <para>The year.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024</para>
                    /// </summary>
                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public string Year { get; set; }

                }

                /// <summary>
                /// <para>The year.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9bc20a5a-b26b-4c28-922a-7cd10b61f96f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
