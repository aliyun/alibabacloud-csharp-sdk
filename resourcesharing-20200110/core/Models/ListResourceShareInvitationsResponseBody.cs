// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareInvitationsResponseBody : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of `NextToken`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resource sharing invitations.
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
            /// The information about the failure.
            /// </summary>
            [NameInMap("InvitationFailedDetails")]
            [Validation(Required=false)]
            public List<ListResourceShareInvitationsResponseBodyResourceShareInvitationsInvitationFailedDetails> InvitationFailedDetails { get; set; }
            public class ListResourceShareInvitationsResponseBodyResourceShareInvitationsInvitationFailedDetails : TeaModel {
                /// <summary>
                /// The type of the sharing operation. Valid values:
                /// 
                /// *   Associate
                /// *   Disassociate
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
                /// *   UnsupportedOperation: The operation is not allowed because another association exists.
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
