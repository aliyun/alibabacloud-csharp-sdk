// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateSwimLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the lane group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The name of the ingress gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("IngressGatewayName")]
        [Validation(Required=false)]
        public string IngressGatewayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>istio-system</para>
        /// </summary>
        [NameInMap("IngressGatewayNamespace")]
        [Validation(Required=false)]
        public string IngressGatewayNamespace { get; set; }

        /// <summary>
        /// <para>The type of the gateway for ingress traffic. Only ASM ingress gateways are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASM</para>
        /// </summary>
        [NameInMap("IngressType")]
        [Validation(Required=false)]
        public string IngressType { get; set; }

        /// <summary>
        /// <para>Specifies whether the permissive mode is enabled for the lane group to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPermissive")]
        [Validation(Required=false)]
        public bool? IsPermissive { get; set; }

        /// <summary>
        /// <para>The request routing header of the lane group if you plan to create a lane group in permissive mode. This parameter must be specified when IsPermissive is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x-asm-prefer-tag</para>
        /// </summary>
        [NameInMap("RouteHeader")]
        [Validation(Required=false)]
        public string RouteHeader { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>A list of services associated with the lane group. The value is a JSON array. The format of a service is <c>$Cluster name/$Cluster ID/$Namespace/$Service name</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mocka\&quot;,\&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockb\&quot;,\&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockc\&quot;]</para>
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

        /// <summary>
        /// <para>The end-to-end (E2E) pass-through request header of the lane group if you plan to create a lane group in permissive mode. This parameter must be specified when IsPermissive is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-request-id</para>
        /// </summary>
        [NameInMap("TraceHeader")]
        [Validation(Required=false)]
        public string TraceHeader { get; set; }

    }

}
