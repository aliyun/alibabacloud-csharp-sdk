// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEmissionSummaryResponseBody : TeaModel {
        /// <summary>
        /// Details of summarized data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEmissionSummaryResponseBodyData Data { get; set; }
        public class GetEmissionSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// Percentage of scheduled.
            /// </summary>
            [NameInMap("actualEmissionRatio")]
            [Validation(Required=false)]
            public double? ActualEmissionRatio { get; set; }

            /// <summary>
            /// Carbon emissions reduction.
            /// </summary>
            [NameInMap("carbonSaveConversion")]
            [Validation(Required=false)]
            public double? CarbonSaveConversion { get; set; }

            /// <summary>
            /// Statistical indicators for this cycle.
            /// </summary>
            [NameInMap("currentPeriodCarbonEmissionData")]
            [Validation(Required=false)]
            public double? CurrentPeriodCarbonEmissionData { get; set; }

            /// <summary>
            /// Whether to show the weighting ratio carbon emission.
            /// </summary>
            [NameInMap("isWeighting")]
            [Validation(Required=false)]
            public bool? IsWeighting { get; set; }

            /// <summary>
            /// Last period statistical indicators.
            /// </summary>
            [NameInMap("lastPeriodCarbonEmissionData")]
            [Validation(Required=false)]
            public double? LastPeriodCarbonEmissionData { get; set; }

            /// <summary>
            /// Calculation of carbon emissions based on shareholding ratio in the last cycle.
            /// </summary>
            [NameInMap("lastPeriodWeightingCarbonEmissionData")]
            [Validation(Required=false)]
            public double? LastPeriodWeightingCarbonEmissionData { get; set; }

            /// <summary>
            /// Year-on-year.
            /// </summary>
            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

            /// <summary>
            /// Total carbon emissions.
            /// </summary>
            [NameInMap("totalCarbonEmissionData")]
            [Validation(Required=false)]
            public double? TotalCarbonEmissionData { get; set; }

            /// <summary>
            /// Calculate carbon emissions by share ratio
            /// </summary>
            [NameInMap("weightingCarbonEmissionData")]
            [Validation(Required=false)]
            public double? WeightingCarbonEmissionData { get; set; }

            /// <summary>
            /// Year-on-year of weighting ratio carbon emissions.
            /// </summary>
            [NameInMap("weightingRatio")]
            [Validation(Required=false)]
            public double? WeightingRatio { get; set; }

        }

        /// <summary>
        /// Id of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
