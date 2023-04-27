// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLhMembersRequest : TeaModel {
        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddLhMembersRequestMembers> Members { get; set; }
        public class AddLhMembersRequestMembers : TeaModel {
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

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
