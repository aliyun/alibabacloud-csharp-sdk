// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusRequest : TeaModel {
        /// <summary>
        /// inviteId list</br>
        /// `Sub-levels <= 5`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InviteStatusList")]
        [Validation(Required=false)]
        public List<GetInviteStatusRequestInviteStatusList> InviteStatusList { get; set; }
        public class GetInviteStatusRequestInviteStatusList : TeaModel {
            /// <summary>
            /// Invitation ID, From interface InviteSubAccount
            /// </summary>
            [NameInMap("InviteId")]
            [Validation(Required=false)]
            public long? InviteId { get; set; }

        }

    }

}
