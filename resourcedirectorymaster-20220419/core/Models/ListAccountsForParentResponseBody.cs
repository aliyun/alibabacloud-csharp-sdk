// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAccountsForParentResponseBody : TeaModel {
        /// <summary>
        /// The information of the members.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListAccountsForParentResponseBodyAccounts Accounts { get; set; }
        public class ListAccountsForParentResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListAccountsForParentResponseBodyAccountsAccount> Account { get; set; }
            public class ListAccountsForParentResponseBodyAccountsAccount : TeaModel {
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
                /// The ID of the folder.
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

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
                /// The time when the member joined the resource directory. The time is displayed in UTC.
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public string JoinTime { get; set; }

                /// <summary>
                /// The time when the member was modified. The time is displayed in UTC.
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
                public ListAccountsForParentResponseBodyAccountsAccountTags Tags { get; set; }
                public class ListAccountsForParentResponseBodyAccountsAccountTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListAccountsForParentResponseBodyAccountsAccountTagsTag> Tag { get; set; }
                    public class ListAccountsForParentResponseBodyAccountsAccountTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

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

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
