// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetBuildRiskDefineRuleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration item for scanning image build command risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>classKey</b>: Set the value to a valid value of the ClassKey parameter in RuleTree.</description></item>
        /// <item><description><b>ruleList</b>: Set the value to a valid value of the RuleKey parameter in RuleList.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~GetBuildRiskDefineRuleConfig~~">GetBuildRiskDefineRuleConfig</a> operation to query the valid values.</para>
        /// </remarks>
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
