// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLhMembersRequest : TeaModel {
        /// <summary>
        /// The information about the users to be added.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AddLhMembersRequestMembers> Members { get; set; }
        public class AddLhMembersRequestMembers : TeaModel {
            /// <summary>
            /// The role. Valid values:
            /// 
            /// *   **ADMIN**: workspace administrator. You can add a workspace administrator only as a DMS administrator or a DBA.
            /// *   **MEMBER**: workspace member.
            /// *   **DEVELOPER**: task flow developer. Only a workspace member can be added as a task flow developer.
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// The ID of the user to be added. You can call the [ListUsers](~~141938~~) or [GetUser](~~147098~~) operation to obtain the user ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// The ID of the object.
        /// 
        /// *   If the object is a workspace, you can call the [GetLhSpaceByName](~~424379~~) operation to obtain the workspace ID.
        /// *   If the object is a task flow, you can call the [ListLhTaskFlowAndScenario](~~426672~~) operation to obtain the task flow ID.
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

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
