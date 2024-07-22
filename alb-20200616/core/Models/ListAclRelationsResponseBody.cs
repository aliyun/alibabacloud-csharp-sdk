// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsResponseBody : TeaModel {
        /// <summary>
        /// The relations between the specified ACL and the listeners.
        /// </summary>
        [NameInMap("AclRelations")]
        [Validation(Required=false)]
        public List<ListAclRelationsResponseBodyAclRelations> AclRelations { get; set; }
        public class ListAclRelationsResponseBodyAclRelations : TeaModel {
            /// <summary>
            /// ACL ID
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// The listeners that are associated with the ACL.
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListAclRelationsResponseBodyAclRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListAclRelationsResponseBodyAclRelationsRelatedListeners : TeaModel {
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
                public int? ListenerPort { get; set; }

                /// <summary>
                /// The listener protocol.
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// The ID of the SLB instance.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The association status between the ACL and the listener.
                /// 
                /// *   **Associating**
                /// *   **Associated**
                /// *   **Dissociating**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
