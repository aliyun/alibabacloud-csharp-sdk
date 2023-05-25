// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLhMembersShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the users to be added.
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

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
