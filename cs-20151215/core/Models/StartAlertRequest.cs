// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartAlertRequest : TeaModel {
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        [NameInMap("alert_rule_name")]
        [Validation(Required=false)]
        public string AlertRuleName { get; set; }

    }

}
