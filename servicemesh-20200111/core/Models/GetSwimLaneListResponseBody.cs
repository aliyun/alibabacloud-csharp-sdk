// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneListResponseBody : TeaModel {
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
        /// <para>The swimlanes.</para>
        /// </summary>
        [NameInMap("SwimLaneList")]
        [Validation(Required=false)]
        public List<GetSwimLaneListResponseBodySwimLaneList> SwimLaneList { get; set; }
        public class GetSwimLaneListResponseBodySwimLaneList : TeaModel {
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
            /// <para>The request routing rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Domains&quot;:[&quot;<em>&quot;],&quot;RouteName&quot;:&quot;r1&quot;,&quot;MatchRequest&quot;:{&quot;Headers&quot;:[{&quot;Name&quot;:&quot;x-asm-prefer-tag&quot;,&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;s1&quot;}],&quot;URI&quot;:{&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;/mock&quot;}},&quot;RouteDestinations&quot;:[{&quot;Destination&quot;:{&quot;Host&quot;:&quot;mocka.default.svc.cluster.local&quot;,&quot;Subset&quot;:&quot;s1&quot;}}]},{&quot;Domains&quot;:[&quot;</em>&quot;],&quot;RouteName&quot;:&quot;hello&quot;,&quot;MatchRequest&quot;:{&quot;Headers&quot;:[{&quot;Name&quot;:&quot;x-asm-prefer-tag&quot;,&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;s1&quot;}],&quot;URI&quot;:{&quot;MatchingMode&quot;:&quot;exact&quot;,&quot;MatchingContent&quot;:&quot;/mocktest&quot;}},&quot;RouteDestinations&quot;:[{&quot;Destination&quot;:{&quot;Host&quot;:&quot;mocka.default.svc.cluster.local&quot;,&quot;Subset&quot;:&quot;s1&quot;}}]}]</para>
            /// </summary>
            [NameInMap("IngressRule")]
            [Validation(Required=false)]
            public string IngressRule { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mocka.default.svc.cluster.local</para>
            /// </summary>
            [NameInMap("IngressService")]
            [Validation(Required=false)]
            public string IngressService { get; set; }

            /// <summary>
            /// <para>The label key of the associated service workload. The value is fixed as <c>ASM_TRAFFIC_TAG</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASM_TRAFFIC_TAG</para>
            /// </summary>
            [NameInMap("LabelSelectorKey")]
            [Validation(Required=false)]
            public string LabelSelectorKey { get; set; }

            /// <summary>
            /// <para>The label value of the associated service workload. The value is fixed as <c>ASM_TRAFFIC_TAG</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("LabelSelectorValue")]
            [Validation(Required=false)]
            public string LabelSelectorValue { get; set; }

            /// <summary>
            /// <para>The name of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Services associated with the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mocka&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockb&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockc&quot;]</para>
            /// </summary>
            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

            /// <summary>
            /// <para>The verification messages of the lane group. If the service does not exist in the lane group, the verification message is displayed in the verification messages of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;code&quot;:&quot;CODE_UNEFFECTED_SWIMLANE_LABEL&quot;,&quot;level&quot;:&quot;warning&quot;,&quot;message&quot;:&quot;The label selector defined in the ASMSwimLane has no effect on any workload instance.&quot;}]</para>
            /// </summary>
            [NameInMap("ValidationMessage")]
            [Validation(Required=false)]
            public string ValidationMessage { get; set; }

            /// <summary>
            /// <para>This parameter is returned only when the IngressRoutingStrategy parameter is set to weighted. This parameter indicates the domain name of Services in each lane and the request routing weight. The value of this parameter is a serialized JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;RouteDestination&quot;:{&quot;Host&quot;:&quot;mocka.default.svc.cluster.local&quot;,&quot;Subset&quot;:&quot;s1&quot;},&quot;Weight&quot;:40}</para>
            /// </summary>
            [NameInMap("WeightedIngressDestinatin")]
            [Validation(Required=false)]
            public string WeightedIngressDestinatin { get; set; }

        }

    }

}
