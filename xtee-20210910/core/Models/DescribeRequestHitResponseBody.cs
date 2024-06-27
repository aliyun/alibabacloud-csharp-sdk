// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRequestHitResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRequestHitResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRequestHitResponseBodyResultObject : TeaModel {
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("requestTime")]
            [Validation(Required=false)]
            public long? RequestTime { get; set; }

            [NameInMap("ruleHitRecords")]
            [Validation(Required=false)]
            public List<DescribeRequestHitResponseBodyResultObjectRuleHitRecords> RuleHitRecords { get; set; }
            public class DescribeRequestHitResponseBodyResultObjectRuleHitRecords : TeaModel {
                [NameInMap("cost")]
                [Validation(Required=false)]
                public int? Cost { get; set; }

                [NameInMap("hitSuccessful")]
                [Validation(Required=false)]
                public bool? HitSuccessful { get; set; }

                [NameInMap("isShowDetail")]
                [Validation(Required=false)]
                public bool? IsShowDetail { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("ruleSnapshotId")]
                [Validation(Required=false)]
                public string RuleSnapshotId { get; set; }

                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

            }

            [NameInMap("sRequestId")]
            [Validation(Required=false)]
            public string SRequestId { get; set; }

            [NameInMap("totalCost")]
            [Validation(Required=false)]
            public long? TotalCost { get; set; }

        }

    }

}
