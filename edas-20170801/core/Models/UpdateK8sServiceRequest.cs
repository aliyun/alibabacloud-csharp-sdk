// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-</b></b>-a286-781659d9f54c</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The policy used for external traffic management. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Local: local mode</description></item>
        /// <item><description>Cluster: cluster mode</description></item>
        /// </list>
        /// <para>Default value: Local.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("ExternalTrafficPolicy")]
        [Validation(Required=false)]
        public string ExternalTrafficPolicy { get; set; }

        /// <summary>
        /// <para>The name of the service in a Kubernetes cluster.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must start with a letter and end with a letter or digit.</description></item>
        /// <item><description>The name can be 2 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-http</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The mappings between service ports. Set this parameter to a JSON array. The following parameters are included in the configurations:</para>
        /// <list type="bullet">
        /// <item><description><b>protocol</b>: the protocol used by the service. Valid values: TCP and UDP. This parameter is required.</description></item>
        /// <item><description><b>port</b>: the frontend service port. Valid values: 1 to 65535. This parameter is required.</description></item>
        /// <item><description><b>targetPort</b>: the backend container port. Valid values: 1 to 65535. This parameter is required.</description></item>
        /// </list>
        /// <para>Example: <c>[{&quot;protocol&quot;: &quot;TCP&quot;, &quot;port&quot;: 80, &quot;targetPort&quot;: 8080},{&quot;protocol&quot;: &quot;TCP&quot;, &quot;port&quot;: 81, &quot;targetPort&quot;: 8081}]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;protocol&quot;:&quot;TCP&quot;,&quot;port&quot;:80,&quot;targetPort&quot;:8080}]</para>
        /// </summary>
        [NameInMap("ServicePorts")]
        [Validation(Required=false)]
        public string ServicePorts { get; set; }

        /// <summary>
        /// <para>The type of the service in a Kubernetes cluster. Set the value to ClusterIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClusterIP</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
