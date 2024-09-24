// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetSensitiveDefineRuleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the custom check rule. The value is in the JSON format. Valid values of keys:</para>
        /// <list type="bullet">
        /// <item><description><b>classKey</b>: the category keyword of the check rule.</description></item>
        /// <item><description><b>ruleList</b>: the keyword of the check rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;classKey\&quot;: \&quot;password\&quot;, \&quot;ruleList\&quot;: [\&quot;huaweicloud_ak\&quot;, \&quot;ak_leak\&quot;]}]</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
