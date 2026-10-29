// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StopAlertRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("alert_rule_name")]
        [Validation(Required=false)]
        public string AlertRuleName { get; set; }

    }

}
