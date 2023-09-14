// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPolicyRelationsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The security policies and the listeners that are associated with the security policies.
        /// </summary>
        [NameInMap("SecrityPolicyRelations")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations> SecrityPolicyRelations { get; set; }
        public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations : TeaModel {
            /// <summary>
            /// The listeners that are associated with the security policy.
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners : TeaModel {
                /// <summary>
                /// The listener ID.
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// The listener port.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                /// <summary>
                /// The listener protocol.
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// The Server Load Balancer (SLB) instance ID.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// The security policy ID.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

        }

    }

}
