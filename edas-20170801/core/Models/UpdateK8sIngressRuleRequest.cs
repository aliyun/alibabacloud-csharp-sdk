// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sIngressRuleRequest : TeaModel {
        /// <summary>
        /// <para>The annotations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;nginx.ingress.kubernetes.io/ssl-redirect\&quot;:\&quot;true\&quot;,\&quot;nginx.ingress.kubernetes.io/configuration-snippet\&quot;:\&quot;set $test value\&quot;}</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>The ID of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2b4ab4-efbc-4a81-9c45-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The routing rules of the Ingress. Set this parameter to a JSON string in the following format:</para>
        /// <pre><c>{
        ///   &quot;rules&quot;: [
        ///     {
        ///       &quot;host&quot;: &quot;abc.com&quot;,
        ///       &quot;secretName&quot;: &quot;tls-secret&quot;,
        ///       &quot;paths&quot;: [
        ///         {
        ///           &quot;path&quot;: &quot;/path&quot;,
        ///           &quot;backend&quot;: {
        ///             &quot;servicePort&quot;: 80,
        ///             &quot;serviceName&quot;: &quot;xxx&quot;
        ///           }
        ///         }
        ///       ]
        ///     }
        ///   ]
        /// }
        /// </c></pre>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description>rules: the list of routing rules.</description></item>
        /// <item><description>host: the domain name to be accessed.</description></item>
        /// <item><description>secretName: the name of the Secret that stores the information about the Transport Layer Security (TLS) certificate. The certificate is required if you need to use the HTTPS protocol.</description></item>
        /// <item><description>paths: the list of paths to be accessed.</description></item>
        /// <item><description>path: the path to be accessed.</description></item>
        /// <item><description>backend: the configuration of the backend service. You can specify a service that is created in the Enterprise Distributed Application Service (EDAS) console.</description></item>
        /// <item><description>serviceName: the name of the backend service.</description></item>
        /// <item><description>servicePort: the port of the backend service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rules&quot;:[{&quot;host&quot;:&quot;abc.com&quot;,&quot;secretName&quot;:&quot;tls-secret&quot;,&quot;paths&quot;:[{&quot;path&quot;:&quot;/path&quot;,&quot;backend&quot;:{&quot;servicePort&quot;:80,&quot;serviceName&quot;:&quot;xxx&quot;}}]}]}</para>
        /// </summary>
        [NameInMap("IngressConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> IngressConf { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;test-label\&quot;:\&quot;test-label-value\&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The name of the Ingress. The name can contain lowercase letters, digits, and hyphens (-). It must start with a lowercase letter but cannot end with a hyphen (-). The name can be up to 63 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-ingress-rule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
