// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RemoveProjectMemberFromRoleRequest : TeaModel {
        /// <summary>
        /// The DataWorks workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The code of the role in the DataWorks workspace. You can call the ListProjectRoles operation to query the codes of all roles in a DataWorks workspace. Valid values:
        /// 
        /// *   role_project_owner: workspace owner
        /// *   role_project_admin: workspace administrator
        /// *   role_project_dev: developer
        /// *   role_project_pe: O\\&M engineer
        /// *   role_project_deploy: deployment expert
        /// *   role_project_guest: visitor
        /// *   role_project_security: security administrator
        /// *   role_project_tester: experiencer
        /// *   role_project_erd: model designer
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// The user ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
