// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetBuildRiskDefineRuleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The risk items in the risk scan configuration for image build instructions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>classKey</b>: the ClassKey field value from RuleTree</description></item>
        /// <item><description><b>ruleList</b>: the RuleKey field values under RuleList<remarks>
        /// <para>Call the <a href="~~GetBuildRiskDefineRuleConfig~~">GetBuildRiskDefineRuleConfig</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;classKey&quot;: &quot;other&quot;,
        ///         &quot;ruleList&quot;: [
        ///             &quot;add&quot;,
        ///             &quot;apk&quot;
        ///         ]
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
