// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class RejectResourceShareInvitationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the resource share.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the resource share.
        /// </summary>
        [NameInMap("ResourceShareInvitation")]
        [Validation(Required=false)]
        public RejectResourceShareInvitationResponseBodyResourceShareInvitation ResourceShareInvitation { get; set; }
        public class RejectResourceShareInvitationResponseBodyResourceShareInvitation : TeaModel {
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

            /// <summary>
            /// The Alibaba Cloud account ID of the inviter.
            /// </summary>
            [NameInMap("ResourceShareInvitationId")]
            [Validation(Required=false)]
            public string ResourceShareInvitationId { get; set; }

            /// <summary>
            /// The time when the invitation was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// The status of the invitation. Valid values:
            /// 
            /// *   Pending: The invitation is waiting for confirmation.
            /// *   Accepted: The invitation is accepted.
            /// *   Cancelled: The invitation is canceled.
            /// *   Rejected: The invitation is rejected.
            /// *   Expired: The invitation has expired.
            /// </summary>
            [NameInMap("SenderAccountId")]
            [Validation(Required=false)]
            public string SenderAccountId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
