// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateASMGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The YAML content that is used to create the ASM gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;apiVersion&quot;:&quot;istio.alibabacloud.com/v1beta1&quot;,&quot;kind&quot;:&quot;IstioGateway&quot;,&quot;metadata&quot;:{&quot;name&quot;:&quot;ingressgateway&quot;,&quot;namespace&quot;:&quot;istio-system&quot;},&quot;spec&quot;:{&quot;gatewayType&quot;:&quot;ingress&quot;,&quot;clusterIds&quot;:[&quot;xxxxx&quot;],&quot;ports&quot;:[{&quot;name&quot;:&quot;http-0&quot;,&quot;port&quot;:80,&quot;targetPort&quot;:80,&quot;protocol&quot;:&quot;TCP&quot;},{&quot;name&quot;:&quot;https-1&quot;,&quot;port&quot;:443,&quot;targetPort&quot;:443,&quot;protocol&quot;:&quot;TCP&quot;}],&quot;serviceAnnotations&quot;:{&quot;service.beta.kubernetes.io/alicloud-loadbalancer-address-type&quot;:&quot;internet&quot;,&quot;service.beta.kubernetes.io/alibaba-cloud-loadbalancer-spec&quot;:&quot;slb.s1.small&quot;},&quot;replicaCount&quot;:2,&quot;resources&quot;:{&quot;limits&quot;:{&quot;cpu&quot;:&quot;2&quot;,&quot;memory&quot;:&quot;4G&quot;},&quot;requests&quot;:{&quot;cpu&quot;:&quot;200m&quot;,&quot;memory&quot;:&quot;256Mi&quot;}},&quot;serviceType&quot;:&quot;LoadBalancer&quot;,&quot;maxReplicas&quot;:2,&quot;minReplicas&quot;:2}}</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The name of the ASM gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
