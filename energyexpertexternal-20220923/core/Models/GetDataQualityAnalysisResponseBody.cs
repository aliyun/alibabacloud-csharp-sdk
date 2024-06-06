// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDataQualityAnalysisResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataQualityAnalysisResponseBodyData Data { get; set; }
        public class GetDataQualityAnalysisResponseBodyData : TeaModel {
            /// <summary>
            /// Score of each inventory.
            /// </summary>
            [NameInMap("dataQuality")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataDataQuality> DataQuality { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataDataQuality : TeaModel {
                /// <summary>
                /// Inventory name
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// Score. The distribution ranges from 1 to 5. A value closer to 1 indicates better data quality.
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public GetDataQualityAnalysisResponseBodyDataDataQualityScore Score { get; set; }
                public class GetDataQualityAnalysisResponseBodyDataDataQualityScore : TeaModel {
                    /// <summary>
                    /// Data quality evaluation indicator 1: activity data credibility.
                    /// </summary>
                    [NameInMap("g1")]
                    [Validation(Required=false)]
                    public double? G1 { get; set; }

                    /// <summary>
                    /// Data quality evaluation indicator 2: data factor reliability.
                    /// </summary>
                    [NameInMap("g2")]
                    [Validation(Required=false)]
                    public double? G2 { get; set; }

                    /// <summary>
                    /// Data quality evaluation indicator 3: time representativeness.
                    /// </summary>
                    [NameInMap("g3")]
                    [Validation(Required=false)]
                    public double? G3 { get; set; }

                    /// <summary>
                    /// Data quality evaluation indicator 4: geographic representativeness.
                    /// </summary>
                    [NameInMap("g4")]
                    [Validation(Required=false)]
                    public double? G4 { get; set; }

                }

            }

            /// <summary>
            /// Data quality result.
            /// </summary>
            [NameInMap("dataQualityResult")]
            [Validation(Required=false)]
            public GetDataQualityAnalysisResponseBodyDataDataQualityResult DataQualityResult { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataDataQualityResult : TeaModel {
                /// <summary>
                /// The score. This parameter is applicable to DQR results. The distribution ranges from 1 to 5. A value closer to 1 indicates better data quality. The number of valid digits is kept to four decimal places.
                /// </summary>
                [NameInMap("data_quality_score")]
                [Validation(Required=false)]
                public double? DataQualityScore { get; set; }

                /// <summary>
                /// Data quality evaluation indicator 1: activity data credibility.
                /// </summary>
                [NameInMap("g1")]
                [Validation(Required=false)]
                public double? G1 { get; set; }

                /// <summary>
                /// Data quality evaluation indicator 2: data factor reliability.
                /// </summary>
                [NameInMap("g2")]
                [Validation(Required=false)]
                public double? G2 { get; set; }

                /// <summary>
                /// Data quality evaluation indicator 3: time representativeness.
                /// </summary>
                [NameInMap("g3")]
                [Validation(Required=false)]
                public double? G3 { get; set; }

                /// <summary>
                /// Data quality evaluation indicator 4: geographic representativeness.
                /// </summary>
                [NameInMap("g4")]
                [Validation(Required=false)]
                public double? G4 { get; set; }

            }

            /// <summary>
            /// Sensitivity analysis list
            /// </summary>
            [NameInMap("sensitivityList")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataSensitivityList> SensitivityList { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataSensitivityList : TeaModel {
                /// <summary>
                /// Inventory id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Name of the inventory item.
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// List of emission reduction measures.
                /// </summary>
                [NameInMap("reductionList")]
                [Validation(Required=false)]
                public List<string> ReductionList { get; set; }

                /// <summary>
                /// Sensitivity percentage.
                /// </summary>
                [NameInMap("sensitivity")]
                [Validation(Required=false)]
                public double? Sensitivity { get; set; }

            }

            /// <summary>
            /// Uncertainty value. The model\\"s overall percentage uncertainty results. "10.00%" symbolizes a 10.00% uncertainty, indicating that the carbon footprint lies within ±10.00%. This is derived from a weighted aggregation of individual inventory uncertainties.
            /// </summary>
            [NameInMap("uncertainty")]
            [Validation(Required=false)]
            public string Uncertainty { get; set; }

            /// <summary>
            /// Uncertainty list
            /// </summary>
            [NameInMap("uncertaintyValues")]
            [Validation(Required=false)]
            public List<GetDataQualityAnalysisResponseBodyDataUncertaintyValues> UncertaintyValues { get; set; }
            public class GetDataQualityAnalysisResponseBodyDataUncertaintyValues : TeaModel {
                /// <summary>
                /// The name of the inventory. Format: process name / inventory name.
                /// </summary>
                [NameInMap("inventory")]
                [Validation(Required=false)]
                public string Inventory { get; set; }

                /// <summary>
                /// Inventory uncertainty absolute contribution size. The impact of the quality of each inventory data on the carbon footprint results in the modeling process, when the uncertain contribution of a list is large, please improve its data quality as much as possible to improve the accuracy of carbon footprint analysis. The meaning of "1.4964" is not determined to contribute 1.4964 kgCO₂ e/unit, where unit is the unit of the product.
                /// </summary>
                [NameInMap("uncertaintyContribution")]
                [Validation(Required=false)]
                public string UncertaintyContribution { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
