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

        /// <summary>
        /// <para>Specifies whether to enable the new ruled for automatic check only on agentless detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no.</description></item>
        /// <item><description><b>1</b>: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableNewRule")]
        [Validation(Required=false)]
        public int? EnableNewRule { get; set; }

        /// <summary>
        /// <para>The source of the check rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>agentless</b>: agentless detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
