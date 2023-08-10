// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareInvitationsResponseBody : TeaModel {
        /// <summary>
        /// The `token` that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource sharing invitations.
        /// </summary>
        [NameInMap("ResourceShareInvitations")]
        [Validation(Required=false)]
        public List<ListResourceShareInvitationsResponseBodyResourceShareInvitations> ResourceShareInvitations { get; set; }
        public class ListResourceShareInvitationsResponseBodyResourceShareInvitations : TeaModel {
            /// <summary>
            /// The time when the invitation was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the invitee.
            /// </summary>
            [NameInMap("ReceiverAccountId")]
            [Validation(Required=false)]
            public string ReceiverAccountId { get; set; }

            /// <summary>
            /// The ID of the resource share.
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// The ID of the invitation.
            /// </summary>
            [NameInMap("ResourceShareInvitationId")]
            [Validation(Required=false)]
            public string ResourceShareInvitationId { get; set; }

            /// <summary>
            /// The name of the resource share.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the inviter.
            /// </summary>
            [NameInMap("SenderAccountId")]
            [Validation(Required=false)]
            public string SenderAccountId { get; set; }

            /// <summary>
            /// The status of the invitation. Valid values:
            /// 
            /// *   Pending: The invitation is waiting for confirmation.
            /// *   Accepted: The invitation is accepted.
            /// *   Cancelled: The invitation is canceled.
            /// *   Rejected: The invitation is rejected.
            /// *   Expired: The invitation has expired.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
