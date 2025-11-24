// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the lane group.</para>
        /// </summary>
        [NameInMap("SwimLaneGroupList")]
        [Validation(Required=false)]
        public List<GetSwimLaneGroupListResponseBodySwimLaneGroupList> SwimLaneGroupList { get; set; }
        public class GetSwimLaneGroupListResponseBodySwimLaneGroupList : TeaModel {
            /// <summary>
            /// <para>The name of the baseline lane of the lane group in permissive mode. This parameter is valid only for a lane group in permissive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s1</para>
            /// </summary>
            [NameInMap("FallbackTarget")]
            [Validation(Required=false)]
            public string FallbackTarget { get; set; }

            /// <summary>
            /// <para>The name of a lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The name of the ASM ingress gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingressgateway</para>
            /// </summary>
            [NameInMap("IngressGatewayName")]
            [Validation(Required=false)]
            public string IngressGatewayName { get; set; }

            /// <summary>
            /// <para>The policy used to route requests among multiple lanes in a lane group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>weighted: a weight-based request routing policy. Requests are matched based on uniform rules and then routed to different lanes in a lane group at a specified ratio.</description></item>
            /// <item><description>rule-based: a rule-based request routing policy. Each lane is configured with request routing rules. Only requests that match the request routing rules of a specific lane are routed to the lane.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>weighted</para>
            /// </summary>
            [NameInMap("IngressRoutingStrategy")]
            [Validation(Required=false)]
            public string IngressRoutingStrategy { get; set; }

            /// <summary>
            /// <para>The type of gateways in which you can configure request routing rules. You can configure request routing rules only in ASM gateways.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASM</para>
            /// </summary>
            [NameInMap("IngressType")]
            [Validation(Required=false)]
            public string IngressType { get; set; }

            /// <summary>
            /// <para>Indicates whether the lane group is in permissive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsPermissive")]
            [Validation(Required=false)]
            public bool? IsPermissive { get; set; }

            /// <summary>
            /// <para>The request routing header of the lane group. It is valid only for a lane group in permissive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x-asm-prefer-tag</para>
            /// </summary>
            [NameInMap("RouteHeader")]
            [Validation(Required=false)]
            public string RouteHeader { get; set; }

            [NameInMap("ServiceLevelFallbackTarget")]
            [Validation(Required=false)]
            public string ServiceLevelFallbackTarget { get; set; }

            /// <summary>
            /// <para>The Services associated with the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mocka&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockb&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockc&quot;]</para>
            /// </summary>
            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

            /// <summary>
            /// <para>A serialized JSON string. The keys of the JSON object are the keys of the labels owned by all services in the lane group, and the values of the JSON object are arrays of all possible label values of the services in the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ASM_TRAFFIC_TAG&quot;:[&quot;v2&quot;,&quot;v3&quot;,&quot;v1&quot;],&quot;version&quot;:[&quot;v3&quot;,&quot;v1&quot;,&quot;v2&quot;]}</para>
            /// </summary>
            [NameInMap("SwimLaneLabels")]
            [Validation(Required=false)]
            public string SwimLaneLabels { get; set; }

            /// <summary>
            /// <para>The end-to-end (E2E) pass-through request header of the lane group. It is valid only for a lane group in permissive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-request-id</para>
            /// </summary>
            [NameInMap("TraceHeader")]
            [Validation(Required=false)]
            public string TraceHeader { get; set; }

            /// <summary>
            /// <para>The weight-based request routing rules for a lane group. This parameter is returned only when the IngressRoutingStrategy parameter is set to weighted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Domains&quot;:[&quot;*&quot;],&quot;MatchRequests&quot;:[{&quot;URI&quot;:{&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;/mock&quot;},&quot;Headers&quot;:[{&quot;Name&quot;:&quot;test&quot;,&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;yes&quot;}]}]}</para>
            /// </summary>
            [NameInMap("WeightedIngressRule")]
            [Validation(Required=false)]
            public string WeightedIngressRule { get; set; }

        }

    }

}
