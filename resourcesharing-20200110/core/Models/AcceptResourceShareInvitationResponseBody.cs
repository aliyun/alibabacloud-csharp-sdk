// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AcceptResourceShareInvitationResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resource sharing invitation.
        /// </summary>
        [NameInMap("ResourceShareInvitation")]
        [Validation(Required=false)]
        public AcceptResourceShareInvitationResponseBodyResourceShareInvitation ResourceShareInvitation { get; set; }
        public class AcceptResourceShareInvitationResponseBodyResourceShareInvitation : TeaModel {
            /// <summary>
            /// The information about the failure.
            /// </summary>
            [NameInMap("AcceptInvitationFailedDetails")]
            [Validation(Required=false)]
            public List<AcceptResourceShareInvitationResponseBodyResourceShareInvitationAcceptInvitationFailedDetails> AcceptInvitationFailedDetails { get; set; }
            public class AcceptResourceShareInvitationResponseBodyResourceShareInvitationAcceptInvitationFailedDetails : TeaModel {
                /// <summary>
                /// The type of the sharing operation. Valid values:
                /// 
                /// *   Associate
                /// </summary>
                [NameInMap("AssociateType")]
                [Validation(Required=false)]
                public string AssociateType { get; set; }

                [NameInMap("FailureDescription")]
                [Validation(Required=false)]
                public string FailureDescription { get; set; }

                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// The ID of the shared resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the shared resource.
                /// 
                /// For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The failure status. Valid values:
                /// 
                /// *   Unavailable: The resource cannot be shared.
                /// *   LimitExceeded: The number of shared resources within the Alibaba Cloud account exceeds the upper limit.
                /// *   ZonalResourceInaccessible: The resource is unavailable in this region.
                /// *   InternalError: An internal error occurred during the check.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The failure cause.
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

            }

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
            /// The ID of the resource sharing invitation.
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
            /// *   Pending
            /// *   Accepted
            /// *   Cancelled
            /// *   Rejected
            /// *   Expired
            /// *   AcceptFailed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
