// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ApplyMetricRuleTemplateResponseBodyResource Resource { get; set; }
        public class ApplyMetricRuleTemplateResponseBodyResource : TeaModel {
            [NameInMap("AlertResults")]
            [Validation(Required=false)]
            public List<ApplyMetricRuleTemplateResponseBodyResourceAlertResults> AlertResults { get; set; }
            public class ApplyMetricRuleTemplateResponseBodyResourceAlertResults : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public bool? Success { get; set; }
            }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
