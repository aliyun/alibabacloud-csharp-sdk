// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DeleteRdMemberListRequest : TeaModel {
        /// <summary>
        /// <para>The list of the members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<DeleteRdMemberListRequestMemberList> MemberList { get; set; }
        public class DeleteRdMemberListRequestMemberList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>136548010379****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
