// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchSetCdnDomainConfigRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain names. You can specify multiple accelerated domain names and separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The features that you want to configure. Format:</para>
        /// <list type="bullet">
        /// <item><description><b>functionName</b>: the name of the feature. This parameter is required. Separate multiple values with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/388460.html">Parameters for configuring features for domain names</a>.</description></item>
        /// <item><description><b>argName</b>: the feature parameter for <b>functionName</b>. This parameter is required. You can specify multiple feature parameters.</description></item>
        /// <item><description><b>argValue</b>: the parameter value that is specified for <b>functionName</b>. This parameter is required.</description></item>
        /// <item><description><b>parentid</b>: the rule condition ID. This parameter is optional. You can use the <b>condition</b> rule engine to create a rule condition. For information, see <a href="https://help.aliyun.com/document_detail/388460.html">Parameters for configuring features for domain names</a>. A rule condition can identify parameters that are included in requests and filter requests based on the identified parameters. After you create a rule condition, a <a href="https://help.aliyun.com/document_detail/388994.html">configid</a> is generated. A configid can be used as parentId that is referenced by other features. This way, you can combine rule conditions and features for flexible configurations.</description></item>
        /// </list>
        /// <para>If the <b>ParentId</b> parameter is \<em>\</em>-1\<em>\</em>, the existing rule conditions in the configurations are deleted.</para>
        /// <pre><code class="language-[{">   &quot;functionArgs&quot;: [{
        ///      &quot;argName&quot;: &quot;Parameter A&quot;, 
        ///      &quot;argValue&quot;: &quot;Value of parameter A&quot;
        ///     }, 
        ///   {
        ///     &quot;argName&quot;: &quot;Parameter B&quot;, 
        ///     &quot;argValue&quot;: &quot;Value of parameter B&quot;
        ///      }], 
        ///  &quot;functionName&quot;: &quot;Feature name&quot;
        ///  &quot;parentId&quot;: Optional. parentId corresponds to configid of the referenced rule condition
        /// }]
        /// </c></pre>
        /// <para>The following code provides a sample configuration if <b>parentId</b> is not used. In this example, the <b>origin_request_header</b> feature is used to add back-to-origin HTTP headers, and the rule condition whose configuration ID is <b>configid=222728944812032</b> is referenced.</para>
        /// <pre><code class="language-[{">        &quot;functionArgs&quot;: [{
        ///             &quot;argName&quot;: &quot;header_operation_type&quot;,
        ///             &quot;argValue&quot;: &quot;add&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_name&quot;,
        ///             &quot;argValue&quot;: &quot;Accept-Encoding&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_value&quot;,
        ///             &quot;argValue&quot;: &quot;gzip&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;duplicate&quot;,
        ///             &quot;argValue&quot;: &quot;off&quot;
        ///         }],
        ///         &quot;functionName&quot;: &quot;origin_request_header&quot;
        /// }]
        /// </c></pre>
        /// <para>The following code shows a sample configuration if <b>parentId</b> is used. In this example, the <b>origin_request_header</b> feature is used to add back-to-origin HTTP headers, and the rule condition whose configuration ID is <b>222728944812032</b> is referenced.</para>
        /// <pre><code class="language-[{">        &quot;functionArgs&quot;: [{
        ///             &quot;argName&quot;: &quot;header_operation_type&quot;,
        ///             &quot;argValue&quot;: &quot;add&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_name&quot;,
        ///             &quot;argValue&quot;: &quot;Accept-Encoding&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_value&quot;,
        ///             &quot;argValue&quot;: &quot;gzip&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;duplicate&quot;,
        ///             &quot;argValue&quot;: &quot;off&quot;
        ///         }],
        ///         &quot;functionName&quot;: &quot;origin_request_header&quot;,
        ///         &quot;parentId&quot;: 222728944812032
        /// }]
        /// </c></pre>
        /// <para>The following code provides a sample configuration that deletes the reference to <b>parentId</b> for a feature that uses <b>parentId</b>. This example shows how to delete the rule condition that has a configuration ID of <b>222728944812032</b> and is referenced when <b>origin_request_header</b> feature is used to add back-to-origin HTTP headers.</para>
        /// <pre><code class="language-[{">        &quot;functionArgs&quot;: [{
        ///             &quot;argName&quot;: &quot;header_operation_type&quot;,
        ///             &quot;argValue&quot;: &quot;add&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_name&quot;,
        ///             &quot;argValue&quot;: &quot;Accept-Encoding&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;header_value&quot;,
        ///             &quot;argValue&quot;: &quot;gzip&quot;
        ///         }, {
        ///             &quot;argName&quot;: &quot;duplicate&quot;,
        ///             &quot;argValue&quot;: &quot;off&quot;
        ///         }],
        ///         &quot;functionName&quot;: &quot;origin_request_header&quot;,
        ///         &quot;parentId&quot;: -1
        /// }]
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;: [{&quot;argName&quot;: &quot;key&quot;,&quot;argValue&quot;: &quot;Content-Encoding&quot;},{&quot;argName&quot;: &quot;value&quot;,&quot;argValue&quot;: &quot;gzip&quot;}],&quot;functionName&quot;: &quot;set_resp_header&quot;} ]</para>
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
