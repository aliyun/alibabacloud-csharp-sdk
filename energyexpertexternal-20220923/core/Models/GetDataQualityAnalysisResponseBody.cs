// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDataQualityAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataQualityAnalysisResponseBodyData Data { get; set; }
        public class GetDataQualityAnalysisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Score of each inventory.</para>
            /// </summary>
            [NameInMap("dataQuality")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataDataQuality> DataQuality { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataDataQuality : TeaModel {
                /// <summary>
                /// <para>Inventory name</para>
                /// 
                /// <b>Example:</b>
                /// <para>energy</para>
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// <para>Score. The distribution ranges from 1 to 5. A value closer to 1 indicates better data quality.</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public GetDataQualityAnalysisResponseBodyDataDataQualityScore Score { get; set; }
                public class GetDataQualityAnalysisResponseBodyDataDataQualityScore : TeaModel {
                    /// <summary>
                    /// <para>Data quality evaluation indicator 1: activity data credibility.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("g1")]
                    [Validation(Required=false)]
                    public double? G1 { get; set; }

                    /// <summary>
                    /// <para>Data quality evaluation indicator 2: data factor reliability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("g2")]
                    [Validation(Required=false)]
                    public double? G2 { get; set; }

                    /// <summary>
                    /// <para>Data quality evaluation indicator 3: time representativeness.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("g3")]
                    [Validation(Required=false)]
                    public double? G3 { get; set; }

                    /// <summary>
                    /// <para>Data quality evaluation indicator 4: geographic representativeness.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("g4")]
                    [Validation(Required=false)]
                    public double? G4 { get; set; }

                }

            }

            /// <summary>
            /// <para>Data quality result.</para>
            /// </summary>
            [NameInMap("dataQualityResult")]
            [Validation(Required=false)]
            public GetDataQualityAnalysisResponseBodyDataDataQualityResult DataQualityResult { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataDataQualityResult : TeaModel {
                /// <summary>
                /// <para>The score. This parameter is applicable to DQR results. The distribution ranges from 1 to 5. A value closer to 1 indicates better data quality. The number of valid digits is kept to four decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2345</para>
                /// </summary>
                [NameInMap("data_quality_score")]
                [Validation(Required=false)]
                public double? DataQualityScore { get; set; }

                /// <summary>
                /// <para>Data quality evaluation indicator 1: activity data credibility.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2345</para>
                /// </summary>
                [NameInMap("g1")]
                [Validation(Required=false)]
                public double? G1 { get; set; }

                /// <summary>
                /// <para>Data quality evaluation indicator 2: data factor reliability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2345</para>
                /// </summary>
                [NameInMap("g2")]
                [Validation(Required=false)]
                public double? G2 { get; set; }

                /// <summary>
                /// <para>Data quality evaluation indicator 3: time representativeness.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2345</para>
                /// </summary>
                [NameInMap("g3")]
                [Validation(Required=false)]
                public double? G3 { get; set; }

                /// <summary>
                /// <para>Data quality evaluation indicator 4: geographic representativeness.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2345</para>
                /// </summary>
                [NameInMap("g4")]
                [Validation(Required=false)]
                public double? G4 { get; set; }

            }

            /// <summary>
            /// <para>Sensitivity analysis list</para>
            /// </summary>
            [NameInMap("sensitivityList")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataSensitivityList> SensitivityList { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataSensitivityList : TeaModel {
                /// <summary>
                /// <para>Inventory id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Name of the inventory item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>energy</para>
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// <para>List of emission reduction measures.</para>
                /// </summary>
                [NameInMap("reductionList")]
                [Validation(Required=false)]
                public List<string> ReductionList { get; set; }

                /// <summary>
                /// <para>Sensitivity percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91.7</para>
                /// </summary>
                [NameInMap("sensitivity")]
                [Validation(Required=false)]
                public double? Sensitivity { get; set; }

            }

            /// <summary>
            /// <para>Uncertainty value. The model\&quot;s overall percentage uncertainty results. &quot;10.00%&quot; symbolizes a 10.00% uncertainty, indicating that the carbon footprint lies within ±10.00%. This is derived from a weighted aggregation of individual inventory uncertainties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.00</para>
            /// </summary>
            [NameInMap("uncertainty")]
            [Validation(Required=false)]
            public string Uncertainty { get; set; }

            /// <summary>
            /// <para>Uncertainty list</para>
            /// </summary>
            [NameInMap("uncertaintyValues")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataUncertaintyValues> UncertaintyValues { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataUncertaintyValues : TeaModel {
                /// <summary>
                /// <para>The name of the inventory. Format: process name / inventory name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>process-1/inventory-1</para>
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// <para>Inventory uncertainty absolute contribution size. The impact of the quality of each inventory data on the carbon footprint results in the modeling process, when the uncertain contribution of a list is large, please improve its data quality as much as possible to improve the accuracy of carbon footprint analysis. The meaning of &quot;1.4964&quot; is not determined to contribute 1.4964 kgCO₂ e/unit, where unit is the unit of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.4964</para>
                /// </summary>
                [NameInMap("uncertaintyContribution")]
                [Validation(Required=false)]
                public string UncertaintyContribution { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A0AEC56-5C9A-5D47-93DF-7227836FFF82</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
