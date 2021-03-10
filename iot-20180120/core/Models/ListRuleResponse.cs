// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListRuleResponseData Data { get; set; }
        public class ListRuleResponseData : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=true)]
            public List<ListRuleResponseDataRuleInfo> RuleInfo { get; set; }
            public class ListRuleResponseDataRuleInfo : TeaModel {
                public long? Id { get; set; }
                public string Select { get; set; }
                public string Topic { get; set; }
                public string ShortTopic { get; set; }
                public string Where { get; set; }
                public string Status { get; set; }
                public long? CreateUserId { get; set; }
                public string ProductKey { get; set; }
                public string Name { get; set; }
                public string DataType { get; set; }
                public string RuleDesc { get; set; }
                public string Created { get; set; }
                public string UtcCreated { get; set; }
                public string Modified { get; set; }
                public string UtcModified { get; set; }
            }
        };

    }

}
