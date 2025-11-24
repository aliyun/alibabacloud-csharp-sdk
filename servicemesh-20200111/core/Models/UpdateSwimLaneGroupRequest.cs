// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateSwimLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the baseline lane in the lane group if the lane group is in permissive mode. This parameter is valid only for a lane group in permissive mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s1</para>
        /// </summary>
        [NameInMap("FallbackTarget")]
        [Validation(Required=false)]
        public string FallbackTarget { get; set; }

        /// <summary>
        /// <para>The name of the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

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

        [NameInMap("ServiceLevelFallbackTarget")]
        [Validation(Required=false)]
        public string ServiceLevelFallbackTarget { get; set; }

        /// <summary>
        /// <para>The Service Mesh (ASM) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>A list of services associated with the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mocka&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockb&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockc&quot;]</para>
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

        /// <summary>
        /// <para>The weight-based request routing rules for a lane group. You can specify this parameter only when the IngressRoutingStrategy parameter is set to weighted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Domains&quot;:[&quot;*&quot;],&quot;MatchRequests&quot;:[{&quot;URI&quot;:{&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;/mock&quot;},&quot;Headers&quot;:[{&quot;Name&quot;:&quot;test&quot;,&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;yes&quot;}]}]}</para>
        /// </summary>
        [NameInMap("WeightedIngressRule")]
        [Validation(Required=false)]
        public string WeightedIngressRule { get; set; }

    }

}
