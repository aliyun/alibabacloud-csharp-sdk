// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StopAlertRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert rule set to be disabled.</para>
        /// </summary>
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        /// <summary>
        /// <para>The name of the alert rule to be disabled. If you do not specify an alert rule name, the alert rule set is disabled.</para>
        /// </summary>
        [NameInMap("alert_rule_name")]
        [Validation(Required=false)]
        public string AlertRuleName { get; set; }

    }

}
