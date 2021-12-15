// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DeleteProtectionModuleRuleRequest : TeaModel {
        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
