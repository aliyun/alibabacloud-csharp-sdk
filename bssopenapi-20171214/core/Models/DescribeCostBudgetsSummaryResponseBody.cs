// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
            /// <para>The website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The list of items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeCostBudgetsSummaryResponseBodyDataItems> Items { get; set; }
            public class DescribeCostBudgetsSummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Information about the budget.</para>
                /// <list type="bullet">
                /// <item><description><para>BudgetCycleType: The budget period. Valid values: daily, monthly, quarterly, and yearly.</para>
                /// </description></item>
                /// <item><description><para>TotalBudgetAmount: The total budget amount.</para>
                /// </description></item>
                /// <item><description><para>BudgetMemo: The notes for the budget.</para>
                /// </description></item>
                /// </list>
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
                /// <para>全年预算</para>
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
                /// <para>Information about the estimate-to-actual comparison.</para>
                /// <list type="bullet">
                /// <item><description><para>ActualConsumeSum: The accumulated actual consumption.</para>
                /// </description></item>
                /// <item><description><para>ActualAddForecastedAmount: The sum of the accumulated actual value and the predicted value. For a cost budget, this value represents the actual spending to date plus the forecasted spending until the budget period ends.</para>
                /// </description></item>
                /// <item><description><para>ActualAndBudgetComparison: The comparison of the actual consumption to the budget. This value is calculated using the following formula: (Accumulated actual value / Total budget amount) × 100%.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{           &quot;actualConsumeSum&quot;: 88.6,           &quot;actualAddForecastedAmount&quot;: 89.6,           &quot;actualAndBudgetComparison&quot;: &quot;20.73%&quot;         }</para>
                /// </summary>
                [NameInMap("CalculatedValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> CalculatedValues { get; set; }

                /// <summary>
                /// <para>Information about the billing cycle.</para>
                /// <list type="bullet">
                /// <item><description><para>ConsumePeriodBegin: The start date of the budget.</para>
                /// </description></item>
                /// <item><description><para>ConsumePeriodEnd: The end date of the budget.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{           &quot;consumePeriodBegin&quot;: &quot;2022-10&quot;,           &quot;consumePeriodEnd&quot;: &quot;2022-11&quot;         }</para>
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public Dictionary<string, object> ConsumePeriod { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6NH0=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
