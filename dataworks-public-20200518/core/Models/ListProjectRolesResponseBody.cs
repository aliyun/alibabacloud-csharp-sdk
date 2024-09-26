// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The roles in the DataWorks workspace.</para>
        /// </summary>
        [NameInMap("ProjectRoleList")]
        [Validation(Required=false)]
        public List<ListProjectRolesResponseBodyProjectRoleList> ProjectRoleList { get; set; }
        public class ListProjectRolesResponseBodyProjectRoleList : TeaModel {
            /// <summary>
            /// <para>The code of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_project_guest</para>
            /// </summary>
            [NameInMap("ProjectRoleCode")]
            [Validation(Required=false)]
            public string ProjectRoleCode { get; set; }

            /// <summary>
            /// <para>The ID of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProjectRoleId")]
            [Validation(Required=false)]
            public int? ProjectRoleId { get; set; }

            /// <summary>
            /// <para>The name of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>visitor</para>
            /// </summary>
            [NameInMap("ProjectRoleName")]
            [Validation(Required=false)]
            public string ProjectRoleName { get; set; }

            /// <summary>
            /// <para>The type of the role in the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProjectRoleType")]
            [Validation(Required=false)]
            public string ProjectRoleType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
