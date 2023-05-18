// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateCloudAccountResponseBody : TeaModel {
        /// <summary>
        /// The information of the member account.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public CreateCloudAccountResponseBodyAccount Account { get; set; }
        public class CreateCloudAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// The ID of the member account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the member account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The display name of the member account.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The ID of the folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The way in which the member account joined the resource directory. Valid values:
            /// 
            /// *   invited: The member account is invited to join the resource directory.
            /// *   created: The member account is directly created in the resource directory.
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// The time when the member account was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The account record ID.
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The status of the member account. Valid values:
            /// 
            /// *   CreateSuccess: The member account is created.
            /// *   CreateVerifying: The creation of the member account is under confirmation.
            /// *   CreateFailed: The member account failed to be created.
            /// *   CreateExpired: The creation of the member account expired.
            /// *   CreateCancelled: The creation of the member account is canceled.
            /// *   PromoteVerifying: The upgrade of the member account is under confirmation.
            /// *   PromoteFailed: The member account failed to be upgraded.
            /// *   PromoteExpired: The upgrade of the member account expired.
            /// *   PromoteCancelled: The upgrade of the member account is canceled.
            /// *   PromoteSuccess: The member account is upgraded.
            /// *   InviteSuccess: The owner of the member account accepted the invitation.
            /// *   Removed: The member account is removed from the resource directory.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the member account. The value CloudAccount indicates that the member account is a cloud account.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
