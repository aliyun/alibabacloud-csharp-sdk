// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteLhMembersShrinkRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteLhMembers**.
        /// </summary>
        [NameInMap("MemberIds")]
        [Validation(Required=false)]
        public string MemberIdsShrink { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
