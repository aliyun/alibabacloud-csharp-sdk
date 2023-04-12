// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class InviteAccountToResourceDirectoryRequest : TeaModel {
        /// <summary>
        /// The description of the invitation.
        /// 
        /// The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InviteAccountToResourceDirectoryRequestTag> Tag { get; set; }
        public class InviteAccountToResourceDirectoryRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID or logon email address of the account that you want to invite.
        /// </summary>
        [NameInMap("TargetEntity")]
        [Validation(Required=false)]
        public string TargetEntity { get; set; }

        /// <summary>
        /// The type of the account. Valid values:
        /// 
        /// *   Account: indicates the ID of the account.
        /// *   Email: indicates the logon email address of the account.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
