// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetHandshakeResponseBody : TeaModel {
        /// <summary>
        /// The information of the invitation.
        /// </summary>
        [NameInMap("Handshake")]
        [Validation(Required=false)]
        public GetHandshakeResponseBodyHandshake Handshake { get; set; }
        public class GetHandshakeResponseBodyHandshake : TeaModel {
            /// <summary>
            /// The time when the invitation was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the invitation expires. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The ID of the invitation.
            /// </summary>
            [NameInMap("HandshakeId")]
            [Validation(Required=false)]
            public string HandshakeId { get; set; }

            /// <summary>
            /// The real-name verification information of the invitee.
            /// 
            /// > This parameter is available only when an invitee calls this operation.
            /// </summary>
            [NameInMap("InvitedAccountRealName")]
            [Validation(Required=false)]
            public string InvitedAccountRealName { get; set; }

            /// <summary>
            /// The ID of the management account of the resource directory.
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// The name of the management account of the resource directory.
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// The real-name verification information of the management account of the resource directory.
            /// 
            /// > This parameter is available only when an invitee calls this operation.
            /// </summary>
            [NameInMap("MasterAccountRealName")]
            [Validation(Required=false)]
            public string MasterAccountRealName { get; set; }

            /// <summary>
            /// The time when the invitation was modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The description of the invitation.
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The status of the invitation. Valid values:
            /// 
            /// *   Pending: The invitation is waiting for confirmation.
            /// *   Accepted: The invitation is accepted.
            /// *   Cancelled: The invitation is canceled.
            /// *   Declined: The invitation is rejected.
            /// *   Expired: The invitation expires.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID or logon email address of the invited account.
            /// </summary>
            [NameInMap("TargetEntity")]
            [Validation(Required=false)]
            public string TargetEntity { get; set; }

            /// <summary>
            /// The type of the invited account. Valid values:
            /// 
            /// *   Account: indicates the ID of the account.
            /// *   Email: indicates the logon email address of the account.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
