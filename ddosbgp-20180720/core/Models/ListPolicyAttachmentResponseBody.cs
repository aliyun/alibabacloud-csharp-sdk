// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyAttachmentResponseBody : TeaModel {
        /// <summary>
        /// The records of attachments to the mitigation policy.
        /// </summary>
        [NameInMap("AttachmentList")]
        [Validation(Required=false)]
        public List<ListPolicyAttachmentResponseBodyAttachmentList> AttachmentList { get; set; }
        public class ListPolicyAttachmentResponseBodyAttachmentList : TeaModel {
            /// <summary>
            /// The IP address of the protected object.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The UID of the member to which the IP address of the protected object belongs.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicyRemark")]
            [Validation(Required=false)]
            public string PolicyRemark { get; set; }

            /// <summary>
            /// The type of the policy. Valid values:
            /// 
            /// *   **l3**: IP-specific mitigation policies.
            /// *   **l4**: port-specific mitigation policies.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The port number of the protected object.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The protocol type of the protected object. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The region to which the IP address of the protected object belongs.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of attachments to the mitigation policy.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
