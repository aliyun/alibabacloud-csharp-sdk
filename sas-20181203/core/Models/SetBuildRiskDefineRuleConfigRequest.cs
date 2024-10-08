// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetBuildRiskDefineRuleConfigRequest : TeaModel {
        /// <summary>
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
