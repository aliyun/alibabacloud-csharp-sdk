// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartAlertRequest : Darabonba.Model {
        /// <summary>
        /// <para>The alert rule group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        /// <summary>
        /// <para>The alert rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("alert_rule_name")]
        [Validation(Required=false)]
        public string AlertRuleName { get; set; }

    }

}

