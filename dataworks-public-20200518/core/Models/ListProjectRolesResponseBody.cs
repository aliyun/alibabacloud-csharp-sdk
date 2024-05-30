// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectRolesResponseBody : TeaModel {
        /// <summary>
        /// The roles in the DataWorks workspace.
        /// </summary>
        [NameInMap("ProjectRoleList")]
        [Validation(Required=false)]
        public List<ListProjectRolesResponseBodyProjectRoleList> ProjectRoleList { get; set; }
        public class ListProjectRolesResponseBodyProjectRoleList : TeaModel {
            /// <summary>
            /// The code of the role in the DataWorks workspace.
            /// </summary>
            [NameInMap("ProjectRoleCode")]
            [Validation(Required=false)]
            public string ProjectRoleCode { get; set; }

            /// <summary>
            /// The ID of the role in the DataWorks workspace.
            /// </summary>
            [NameInMap("ProjectRoleId")]
            [Validation(Required=false)]
            public int? ProjectRoleId { get; set; }

            /// <summary>
            /// The name of the role in the DataWorks workspace.
            /// </summary>
            [NameInMap("ProjectRoleName")]
            [Validation(Required=false)]
            public string ProjectRoleName { get; set; }

            /// <summary>
            /// The type of the role in the DataWorks workspace.
            /// </summary>
            [NameInMap("ProjectRoleType")]
            [Validation(Required=false)]
            public string ProjectRoleType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
