// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleAssignmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role assignment.</para>
        /// </summary>
        [NameInMap("RoleAssignment")]
        [Validation(Required=false)]
        public CreateRoleAssignmentResponseBodyRoleAssignment RoleAssignment { get; set; }
        public class CreateRoleAssignmentResponseBodyRoleAssignment : TeaModel {
            /// <summary>
            /// <para>The time when the role assignment was created, in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the principal. When PrincipalType is User, this is the user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the principal. When PrincipalType is User, this is the username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the principal. Only User is currently supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The ID of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// <para>The name of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analyst</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The ID of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

        }

    }

}
