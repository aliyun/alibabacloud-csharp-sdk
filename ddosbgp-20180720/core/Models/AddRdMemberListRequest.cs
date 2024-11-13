// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AddRdMemberListRequest : TeaModel {
        /// <summary>
        /// <para>The list of the members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<AddRdMemberListRequestMemberList> MemberList { get; set; }
        public class AddRdMemberListRequestMemberList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19510843762****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
