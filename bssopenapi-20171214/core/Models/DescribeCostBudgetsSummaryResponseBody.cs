// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCostBudgetsSummaryResponseBodyData Data { get; set; }
        public class DescribeCostBudgetsSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The site of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The data that is returned.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeCostBudgetsSummaryResponseBodyDataItems> Items { get; set; }
            public class DescribeCostBudgetsSummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The information about the budget. The BudgetCycleType parameter indicates the cycle of the budget. Valid values: daily, monthly, quarterly, and yearly. The TotalBudgetAmount parameter indicates the total budget. The BudgetMemo parameter indicates the remarks of the budget.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{           &quot;budgetCycleType&quot;: &quot;monthly&quot;,           &quot;budgetMemo&quot;: &quot;&quot;,           &quot;totalBudgetAmount&quot;: 220         }</para>
                /// </summary>
                [NameInMap("Budget")]
                [Validation(Required=false)]
                public Dictionary<string, object> Budget { get; set; }

                /// <summary>
                /// <para>The name of the budget.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Annual budget</para>
                /// </summary>
                [NameInMap("BudgetName")]
                [Validation(Required=false)]
                public string BudgetName { get; set; }

                /// <summary>
                /// <para>The status of the budget.</para>
                /// 
                /// <b>Example:</b>
                /// <para>overdue</para>
                /// </summary>
                [NameInMap("BudgetStatus")]
                [Validation(Required=false)]
                public string BudgetStatus { get; set; }

                /// <summary>
                /// <para>The type of the budget.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cost</para>
                /// </summary>
                [NameInMap("BudgetType")]
                [Validation(Required=false)]
                public string BudgetType { get; set; }

                /// <summary>
                /// <para>The information about the estimate-to-actual analysis. The ActualConsumeSum parameter indicates the accumulated actual value. The ActualAddForecastedAmount parameter indicates the sum of accumulated actual value and predicted value. If the BudgetType parameter is set to cost, the sum of actual value and predicted value includes the actual cost incurred from the budget start date to the current date and the predicted cost from the current date to the budget end date. If the BudgetType parameter is set to asset, the sum of actual value and predicted value includes the actual usage or coverage from the budget start date to the budget end date. If the budget end date minus the current date is more than one year, the part that exceeds one year is not included. The ActualAndBudgetComparison parameter indicates the comparison between the actual value and the predicted value. The value of the ActualAndBudgetComparison parameter is calculated based on the following formula: Accumulated actual value/Total budget × 100%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{           &quot;actualConsumeSum&quot;: 88.6,           &quot;actualAddForecastedAmount&quot;: 89.6,           &quot;actualAndBudgetComparison&quot;: &quot;20.73%&quot;         }</para>
                /// </summary>
                [NameInMap("CalculatedValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> CalculatedValues { get; set; }

                /// <summary>
                /// <para>The information about the billing cycle. The ConsumePeriodBegin parameter indicates the start date of the budget. The ConsumePeriodEnd parameter indicates the end date of the budget.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{           &quot;consumePeriodBegin&quot;: &quot;2022-10&quot;,           &quot;consumePeriodEnd&quot;: &quot;2022-11&quot;         }</para>
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public Dictionary<string, object> ConsumePeriod { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to retrieve the next page</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6NH0=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BFC23FE-A182-4D96-A1E4-7521B30B8E43</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
