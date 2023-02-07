// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCostBudgetsSummaryResponseBodyData Data { get; set; }
        public class DescribeCostBudgetsSummaryResponseBodyData : TeaModel {
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeCostBudgetsSummaryResponseBodyDataItems> Items { get; set; }
            public class DescribeCostBudgetsSummaryResponseBodyDataItems : TeaModel {
                [NameInMap("Budget")]
                [Validation(Required=false)]
                public Dictionary<string, object> Budget { get; set; }

                [NameInMap("BudgetName")]
                [Validation(Required=false)]
                public string BudgetName { get; set; }

                [NameInMap("BudgetStatus")]
                [Validation(Required=false)]
                public string BudgetStatus { get; set; }

                [NameInMap("BudgetType")]
                [Validation(Required=false)]
                public string BudgetType { get; set; }

                [NameInMap("CalculatedValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> CalculatedValues { get; set; }

                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public Dictionary<string, object> ConsumePeriod { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
