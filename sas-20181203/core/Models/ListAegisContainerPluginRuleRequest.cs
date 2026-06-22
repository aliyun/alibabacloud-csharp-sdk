// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAegisContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions. The format is as follows:</para>
        /// <pre><code class="language-json">[
        ///   {
        ///     &quot;name&quot;: &quot;ruleName&quot;,
        ///     &quot;value&quot;: &quot;test&quot;
        ///   }
        /// ]
        /// </c></pre>
        /// <para><b>- name</b>: The condition name. The following conditions are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>ruleName</b>: The rule name.</description></item>
        /// </list>
        /// <para><b>- value</b>: The condition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;: \&quot;name\&quot;, \&quot;value\&quot;: \&quot;test-1818\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies the language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: User-defined.</description></item>
        /// <item><description><b>1</b>: System built-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

    }

}
