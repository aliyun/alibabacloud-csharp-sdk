// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The parameter used to specify the diagnostic object. Examples of parameters for different types of diagnostic objects:</para>
        /// <para>node:</para>
        /// <pre><c>{&quot;name&quot;: &quot;cn-shanghai.10.10.10.107&quot;}
        /// </c></pre>
        /// <para>pod</para>
        /// <pre><c>{&quot;namespace&quot;: &quot;kube-system&quot;, &quot;name&quot;: &quot;csi-plugin-2cg9f&quot;}
        /// </c></pre>
        /// <para>network</para>
        /// <pre><c>{&quot;src&quot;: &quot;10.10.10.108&quot;, &quot;dst&quot;: &quot;10.11.247.16&quot;, &quot;dport&quot;: &quot;80&quot;}
        /// </c></pre>
        /// <para>ingress</para>
        /// <pre><c>{&quot;url&quot;: &quot;https://example.com&quot;}
        /// </c></pre>
        /// <para>memory</para>
        /// <pre><c>{&quot;node&quot;:&quot;cn-hangzhou.172.16.9.240&quot;}
        /// </c></pre>
        /// <para>service</para>
        /// <pre><c>{&quot;namespace&quot;: &quot;kube-system&quot;, &quot;name&quot;: &quot;nginx-ingress-lb&quot;}
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;namespace&quot;: &quot;kube-system&quot;, &quot;name&quot;: &quot;csi-plugin-2cg9f&quot;}</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public Dictionary<string, object> Target { get; set; }

        /// <summary>
        /// <para>The type of the diagnostic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>node</description></item>
        /// <item><description>ingress</description></item>
        /// <item><description>cluster</description></item>
        /// <item><description>memory</description></item>
        /// <item><description>pod</description></item>
        /// <item><description>service</description></item>
        /// <item><description>network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>node</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
