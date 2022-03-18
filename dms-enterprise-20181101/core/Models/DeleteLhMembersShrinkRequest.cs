// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteLhMembersShrinkRequest : TeaModel {
        [NameInMap("MemberIds")]
        [Validation(Required=false)]
        public string MemberIdsShrink { get; set; }

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
