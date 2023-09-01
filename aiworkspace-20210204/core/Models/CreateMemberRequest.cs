// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateMemberRequest : TeaModel {
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<CreateMemberRequestMembers> Members { get; set; }
        public class CreateMemberRequestMembers : TeaModel {
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
