// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The relations between the specified ACL and the listeners.</para>
        /// </summary>
        [NameInMap("AclRelations")]
        [Validation(Required=false)]
        public List<ListAclRelationsResponseBodyAclRelations> AclRelations { get; set; }
        public class ListAclRelationsResponseBodyAclRelations : TeaModel {
            /// <summary>
            /// <para>ACL ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacl-hp34s2h0xx1ht4nwo****</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The listeners that are associated with the ACL.</para>
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListAclRelationsResponseBodyAclRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListAclRelationsResponseBodyAclRelationsRelatedListeners : TeaModel {
                /// <summary>
                /// <para>The listener ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lsr-bp1bpn0kn908w4nbw****</para>
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
                public int? ListenerPort { get; set; }

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
                /// <para>The ID of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1b6c719dfa08ex****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The association status between the ACL and the listener.</para>
                /// <list type="bullet">
                /// <item><description><b>Associating</b></description></item>
                /// <item><description><b>Associated</b></description></item>
                /// <item><description><b>Dissociating</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Associated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
