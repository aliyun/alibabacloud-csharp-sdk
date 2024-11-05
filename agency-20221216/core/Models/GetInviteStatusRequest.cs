// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusRequest : TeaModel {
        /// <summary>
        /// <para>inviteId list</br>
        /// <c>Sub-levels &lt;= 5</c></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InviteStatusList")]
        [Validation(Required=false)]
        public List<GetInviteStatusRequestInviteStatusList> InviteStatusList { get; set; }
        public class GetInviteStatusRequestInviteStatusList : TeaModel {
            /// <summary>
            /// <para>Invitation ID, From interface InviteSubAccount</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InviteId")]
            [Validation(Required=false)]
            public long? InviteId { get; set; }

        }

    }

}
