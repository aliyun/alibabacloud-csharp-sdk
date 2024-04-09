// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AddRdMemberListRequest : TeaModel {
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<AddRdMemberListRequestMemberList> MemberList { get; set; }
        public class AddRdMemberListRequestMemberList : TeaModel {
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
