// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetCdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The features that you want to configure. Format:</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>functionName</b>: The name of the feature. Separate multiple values with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/388460.html">A list of features</a>.</description></item>
        /// <item><description><b>argName</b>: The feature parameters for <b>functionName</b>.</description></item>
        /// <item><description><b>argValue</b>: The parameter values set for <b>functionName</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <pre><c>    [
        ///      {
        ///        &quot;functionArgs&quot;: [
        ///         {
        ///          &quot;argName&quot;: &quot;Parameter A&quot;, 
        ///          &quot;argValue&quot;: &quot;Value of Parameter A&quot;
        ///         }, 
        ///       {
        ///         &quot;argName&quot;: &quot;Parameter B&quot;, 
        ///         &quot;argValue&quot;: &quot;Value of Parameter B&quot;
        ///          }
        ///      ], 
        ///      &quot;functionName&quot;: &quot;Feature name&quot;
        ///         }
        ///     ]
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;enable&quot;,&quot;argValue&quot;:&quot;on&quot;},{&quot;argName&quot;:&quot;pri&quot;,&quot;argValue&quot;:&quot;1&quot;},{&quot;argName&quot;:&quot;rule&quot;,&quot;argValue&quot;:&quot;xxx&quot;}],&quot;functionName&quot;:&quot;edge_function&quot;}]</para>
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

    }

}
