// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAccountResponseBody : TeaModel {
        /// <summary>
        /// The information of the member.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public UpdateAccountResponseBodyAccount Account { get; set; }
        public class UpdateAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account that corresponds to the member.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account that corresponds to the member.
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
            /// *   InviteSuccess: The member accepts the invitation.
            /// *   Removed: The member is removed.
            /// *   SwitchSuccess: The type of the member is switched.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
