// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class SetDomainRuleGroupRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        [NameInMap("RuleGroupId")]
        [Validation(Required=false)]
        public long? RuleGroupId { get; set; }

        [NameInMap("WafVersion")]
        [Validation(Required=false)]
        public long? WafVersion { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
