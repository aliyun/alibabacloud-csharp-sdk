// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCostBudgetsSummaryResponseBodyData Data { get; set; }
        public class DescribeCostBudgetsSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// The site of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The data that is returned.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeCostBudgetsSummaryResponseBodyDataItems> Items { get; set; }
            public class DescribeCostBudgetsSummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The information about the budget. The BudgetCycleType parameter indicates the cycle of the budget. Valid values: daily, monthly, quarterly, and yearly. The TotalBudgetAmount parameter indicates the total budget. The BudgetMemo parameter indicates the remarks of the budget.
                /// </summary>
                [NameInMap("Budget")]
                [Validation(Required=false)]
                public Dictionary<string, object> Budget { get; set; }

                /// <summary>
                /// The name of the budget.
                /// </summary>
                [NameInMap("BudgetName")]
                [Validation(Required=false)]
                public string BudgetName { get; set; }

                /// <summary>
                /// The status of the budget.
                /// </summary>
                [NameInMap("BudgetStatus")]
                [Validation(Required=false)]
                public string BudgetStatus { get; set; }

                /// <summary>
                /// The type of the budget.
                /// </summary>
                [NameInMap("BudgetType")]
                [Validation(Required=false)]
                public string BudgetType { get; set; }

                /// <summary>
                /// The information about the estimate-to-actual analysis. The ActualConsumeSum parameter indicates the accumulated actual value. The ActualAddForecastedAmount parameter indicates the sum of accumulated actual value and predicted value. If the BudgetType parameter is set to cost, the sum of actual value and predicted value includes the actual cost incurred from the budget start date to the current date and the predicted cost from the current date to the budget end date. If the BudgetType parameter is set to asset, the sum of actual value and predicted value includes the actual usage or coverage from the budget start date to the budget end date. If the budget end date minus the current date is more than one year, the part that exceeds one year is not included. The ActualAndBudgetComparison parameter indicates the comparison between the actual value and the predicted value. The value of the ActualAndBudgetComparison parameter is calculated based on the following formula: Accumulated actual value/Total budget × 100%.
                /// </summary>
                [NameInMap("CalculatedValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> CalculatedValues { get; set; }

                /// <summary>
                /// The information about the billing cycle. The ConsumePeriodBegin parameter indicates the start date of the budget. The ConsumePeriodEnd parameter indicates the end date of the budget.
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public Dictionary<string, object> ConsumePeriod { get; set; }

            }

            /// <summary>
            /// The maximum number of entries that are returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that is used to retrieve the next page
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries that are returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
