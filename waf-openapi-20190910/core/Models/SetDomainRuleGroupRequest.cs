// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class SetDomainRuleGroupRequest : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RuleGroupId")]
        [Validation(Required=false)]
        public long? RuleGroupId { get; set; }

        [NameInMap("WafAiStatus")]
        [Validation(Required=false)]
        public int? WafAiStatus { get; set; }

        [NameInMap("WafVersion")]
        [Validation(Required=false)]
        public long? WafVersion { get; set; }

    }

}
