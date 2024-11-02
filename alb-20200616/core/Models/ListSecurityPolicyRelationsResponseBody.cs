// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPolicyRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security policies and the listeners that are associated with the security policies.</para>
        /// </summary>
        [NameInMap("SecrityPolicyRelations")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations> SecrityPolicyRelations { get; set; }
        public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations : TeaModel {
            /// <summary>
            /// <para>The listeners that are associated with the security policy.</para>
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners : TeaModel {
                /// <summary>
                /// <para>The listener ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lsn-0bfuc****</para>
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                /// <summary>
                /// <para>The listener protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS</para>
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// <para>The Server Load Balancer (SLB) instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1o94dp5i6ea****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// <para>The security policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scp-bp1bpn0kn9****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

        }

    }

}
