// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLhMembersShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

        /// <summary>
        /// The ID of the user to be added. You can call the [ListUsers](~~141938~~) or [GetUser](~~147098~~) operation to obtain the user ID.
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// The type of the object. Valid values:
        /// 
        /// *   **0**: workspace
        /// *   **1**: task flow
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
