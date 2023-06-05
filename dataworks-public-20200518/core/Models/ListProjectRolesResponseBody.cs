// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectRolesResponseBody : TeaModel {
        /// <summary>
        /// The role ID of the workspace.
        /// </summary>
        [NameInMap("ProjectRoleList")]
        [Validation(Required=false)]
        public List<ListProjectRolesResponseBodyProjectRoleList> ProjectRoleList { get; set; }
        public class ListProjectRolesResponseBodyProjectRoleList : TeaModel {
            [NameInMap("ProjectRoleCode")]
            [Validation(Required=false)]
            public string ProjectRoleCode { get; set; }

            /// <summary>
            /// The role type of the workspace. Valid values:
            /// </summary>
            [NameInMap("ProjectRoleId")]
            [Validation(Required=false)]
            public int? ProjectRoleId { get; set; }

            /// <summary>
            /// The role Code of the workspace.
            /// </summary>
            [NameInMap("ProjectRoleName")]
            [Validation(Required=false)]
            public string ProjectRoleName { get; set; }

            /// <summary>
            /// The role name of the workspace.
            /// </summary>
            [NameInMap("ProjectRoleType")]
            [Validation(Required=false)]
            public string ProjectRoleType { get; set; }

        }

        /// <summary>
        /// The roles of the workspace.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
