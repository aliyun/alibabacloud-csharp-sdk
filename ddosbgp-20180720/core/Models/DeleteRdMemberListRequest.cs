// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DeleteRdMemberListRequest : TeaModel {
        /// <summary>
        /// The list of the members.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<DeleteRdMemberListRequestMemberList> MemberList { get; set; }
        public class DeleteRdMemberListRequestMemberList : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the member.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
