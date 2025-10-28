// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateK8sServiceRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
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
        /// <item><description>Local: The network traffic can be routed to pods on the node where the Service is deployed.</description></item>
        /// <item><description>Cluster: The network traffic can be routed to pods on other nodes in the cluster.</description></item>
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
        /// <para>The name of the Kubernetes Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-http</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port mapping of the Kubernetes Service. Set this parameter to a JSON array. The following parameters are included in the configurations:</para>
        /// <list type="bullet">
        /// <item><description><b>protocol</b>: the protocol used by the Service. Valid values: TCP and UDP. This parameter is mandatory.</description></item>
        /// <item><description><b>port</b>: the frontend service port. Valid values: 1 to 65535. This parameter is mandatory.</description></item>
        /// <item><description><b>targetPort</b>: the backend container port. Valid values: 1 to 65535. This parameter is mandatory.</description></item>
        /// </list>
        /// <para>Example: <c>[{&quot;protocol&quot;: &quot;TCP&quot;, &quot;port&quot;: 80, &quot;targetPort&quot;: 8080},{&quot;protocol&quot;: &quot;TCP&quot;, &quot;port&quot;: 81, &quot;targetPort&quot;: 8081}]</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;protocol&quot;:&quot;TCP&quot;,&quot;port&quot;:80,&quot;targetPort&quot;:8080}]</para>
        /// </summary>
        [NameInMap("ServicePorts")]
        [Validation(Required=false)]
        public string ServicePorts { get; set; }

        /// <summary>
        /// <para>The type of the Kubernetes Service. Set the value to ClusterIP.</para>
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
