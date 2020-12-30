// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class PublishRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public PublishRuleResponseBodyResult Result { get; set; }
        public class PublishRuleResponseBodyResult : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }
        };

    }

}
