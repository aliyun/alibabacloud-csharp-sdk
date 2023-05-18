// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountResponseBody : TeaModel {
        /// <summary>
        /// The information of the member.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public GetAccountResponseBodyAccount Account { get; set; }
        public class GetAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the member.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account name of the member.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The display name of the member.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The status of the modification for the email address bound to the member. Valid values:
            /// 
            /// *   WAIT_MODIFY: in progress
            /// *   CANCELLED: canceled
            /// *   EXPIRED: expired
            /// 
            /// If the value of this parameter is empty, no modification is performed for the email address.
            /// </summary>
            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public string EmailStatus { get; set; }

            /// <summary>
            /// The ID of the folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The real-name verification information.
            /// </summary>
            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            /// <summary>
            /// The way in which the member joins the resource directory. Valid values:
            /// 
            /// *   invited: The member is invited to join the resource directory.
            /// *   created: The member is directly created in the resource directory.
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// The time when the member joined the resource directory.
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// The location of the member in the resource directory.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The time when the member was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The path of the member in the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryPath")]
            [Validation(Required=false)]
            public string ResourceDirectoryPath { get; set; }

            /// <summary>
            /// The status of the member. Valid values:
            /// 
            /// *   CreateSuccess: The member is created.
            /// *   PromoteVerifying: The upgrade of the member is being confirmed.
            /// *   PromoteFailed: The upgrade of the member fails.
            /// *   PromoteExpired: The upgrade of the member expires.
            /// *   PromoteCancelled: The upgrade of the member is canceled.
            /// *   PromoteSuccess: The member is upgraded.
            /// *   InviteSuccess: The member accepts the invitation.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags that are added to the member.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAccountResponseBodyAccountTags> Tags { get; set; }
            public class GetAccountResponseBodyAccountTags : TeaModel {
                /// <summary>
                /// A tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// A tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the member. Valid values:
            /// 
            /// *   CloudAccount: cloud account
            /// *   ResourceAccount: resource account
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
