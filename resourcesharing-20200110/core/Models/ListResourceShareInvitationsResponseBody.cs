// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareInvitationsResponseBody : TeaModel {
        /// <summary>
        /// The status of the invitation. Valid values:
        /// 
        /// *   Pending: The invitation is waiting for confirmation.
        /// *   Accepted: The invitation is accepted.
        /// *   Cancelled: The invitation is canceled.
        /// *   Rejected: The invitation is rejected.
        /// *   Expired: The invitation has expired.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The time when the invitation was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource share.
        /// </summary>
        [NameInMap("ResourceShareInvitations")]
        [Validation(Required=false)]
        public List<ListResourceShareInvitationsResponseBodyResourceShareInvitations> ResourceShareInvitations { get; set; }
        public class ListResourceShareInvitationsResponseBodyResourceShareInvitations : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the inviter.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ReceiverAccountId")]
            [Validation(Required=false)]
            public string ReceiverAccountId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the invitee.
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            [NameInMap("ResourceShareInvitationId")]
            [Validation(Required=false)]
            public string ResourceShareInvitationId { get; set; }

            /// <summary>
            /// The ID of the invitation.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            [NameInMap("SenderAccountId")]
            [Validation(Required=false)]
            public string SenderAccountId { get; set; }

            /// <summary>
            /// The name of the resource share.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
