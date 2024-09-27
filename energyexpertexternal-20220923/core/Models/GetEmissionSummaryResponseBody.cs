// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEmissionSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of summarized data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEmissionSummaryResponseBodyData Data { get; set; }
        public class GetEmissionSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Percentage of scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.7657</para>
            /// </summary>
            [NameInMap("actualEmissionRatio")]
            [Validation(Required=false)]
            public double? ActualEmissionRatio { get; set; }

            /// <summary>
            /// <para>Carbon emissions reduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("carbonSaveConversion")]
            [Validation(Required=false)]
            public double? CarbonSaveConversion { get; set; }

            /// <summary>
            /// <para>Statistical indicators for this cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>276.4</para>
            /// </summary>
            [NameInMap("currentPeriodCarbonEmissionData")]
            [Validation(Required=false)]
            public double? CurrentPeriodCarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Whether to show the weighting ratio carbon emission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isWeighting")]
            [Validation(Required=false)]
            public bool? IsWeighting { get; set; }

            /// <summary>
            /// <para>Last period statistical indicators.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9.40100</para>
            /// </summary>
            [NameInMap("lastPeriodCarbonEmissionData")]
            [Validation(Required=false)]
            public double? LastPeriodCarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Calculation of carbon emissions based on shareholding ratio in the last cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.4609</para>
            /// </summary>
            [NameInMap("lastPeriodWeightingCarbonEmissionData")]
            [Validation(Required=false)]
            public double? LastPeriodWeightingCarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Year-on-year.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28.410</para>
            /// </summary>
            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

            /// <summary>
            /// <para>Total carbon emissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>276.46</para>
            /// </summary>
            [NameInMap("totalCarbonEmissionData")]
            [Validation(Required=false)]
            public double? TotalCarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Calculate carbon emissions by share ratio</para>
            /// 
            /// <b>Example:</b>
            /// <para>248.81400</para>
            /// </summary>
            [NameInMap("weightingCarbonEmissionData")]
            [Validation(Required=false)]
            public double? WeightingCarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Year-on-year of weighting ratio carbon emissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28.4102</para>
            /// </summary>
            [NameInMap("weightingRatio")]
            [Validation(Required=false)]
            public double? WeightingRatio { get; set; }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
