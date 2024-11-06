// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain names. Specify multiple accelerated domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.org</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The features that you want to configure. Format:</para>
        /// <list type="bullet">
        /// <item><description><para><b>functionName</b>: The name of the feature. Separate multiple values with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/410622.html">A list of features</a>.</para>
        /// </description></item>
        /// <item><description><para><b>argName</b>: The feature parameters for <b>functionName</b>.</para>
        /// </description></item>
        /// <item><description><para><b>argValue</b>: The parameter values set for <b>functionName</b>.</para>
        /// </description></item>
        /// <item><description><para><b>parentid</b>: the rule ID. This parameter is optional. You can use the <b>condition</b> rules engine to create a rule. For information, see <a href="https://help.aliyun.com/document_detail/388460.html">Feature settings for domain names</a>. A rule can identify parameters that are included in requests and filter requests based on the identified parameters. After you create a rule, a <a href="https://help.aliyun.com/document_detail/388994.html">configid</a> is generated. A configid can be used as parentId that is referenced by other features. This way, you can combine rules and features for flexible configurations.</para>
        /// </description></item>
        /// </list>
        /// <para>If the <b>parentId</b> parameter is <b>-1</b>, the existing rules in the configurations are deleted.</para>
        /// <pre><code class="language-["> {
        ///    &quot;functionArgs&quot;: [
        ///     {
        ///      &quot;argName&quot;: &quot;Parameter A&quot;, 
        ///      &quot;argValue&quot;: Value of parameter A&quot;
        ///     }, 
        ///   {
        ///     &quot;argName&quot;: &quot;Parameter B&quot;, 
        ///     &quot;argValue&quot;: &quot;Value of Parameter B&quot;
        ///      }
        ///  ], 
        ///  &quot;functionName&quot;: &quot;Feature name&quot;
        ///     }
        /// ]```
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;switch&quot;,&quot;argValue&quot;:&quot;on&quot;},{&quot;argName&quot;:&quot;region&quot;,&quot;argValue&quot;:&quot;*&quot;}],&quot;functionName&quot;:&quot;ipv6&quot;}]</para>
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
