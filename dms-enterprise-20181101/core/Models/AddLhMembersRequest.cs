/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLhMembersRequest : TeaModel {
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddLhMembersRequestMembers> Members { get; set; }
        public class AddLhMembersRequestMembers : TeaModel {
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public long? ObjectId { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
