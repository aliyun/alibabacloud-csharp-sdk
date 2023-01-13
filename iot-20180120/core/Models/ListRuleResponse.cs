// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListRuleResponseData Data { get; set; }
        public class ListRuleResponseData : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=true)]
            public List<ListRuleResponseDataRuleInfo> RuleInfo { get; set; }
            public class ListRuleResponseDataRuleInfo : TeaModel {
                [NameInMap("CreateUserId")]
                [Validation(Required=true)]
                public long? CreateUserId { get; set; }

                [NameInMap("Created")]
                [Validation(Required=true)]
                public string Created { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=true)]
                public string DataType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=true)]
                public long? Id { get; set; }

                [NameInMap("Modified")]
                [Validation(Required=true)]
                public string Modified { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("RuleDesc")]
                [Validation(Required=true)]
                public string RuleDesc { get; set; }

                [NameInMap("Select")]
                [Validation(Required=true)]
                public string Select { get; set; }

                [NameInMap("ShortTopic")]
                [Validation(Required=true)]
                public string ShortTopic { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=true)]
                public string Topic { get; set; }

                [NameInMap("UtcCreated")]
                [Validation(Required=true)]
                public string UtcCreated { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

                [NameInMap("Where")]
                [Validation(Required=true)]
                public string Where { get; set; }

            }

        }

    }

}
