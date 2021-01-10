// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RuleInfo")]
        [Validation(Required=false)]
        public GetRuleResponseBodyRuleInfo RuleInfo { get; set; }
        public class GetRuleResponseBodyRuleInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }
            [NameInMap("Select")]
            [Validation(Required=false)]
            public string Select { get; set; }
            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public int? TopicType { get; set; }
            [NameInMap("Where")]
            [Validation(Required=false)]
            public string Where { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("ShortTopic")]
            [Validation(Required=false)]
            public string ShortTopic { get; set; }
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
