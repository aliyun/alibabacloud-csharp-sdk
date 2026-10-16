// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleAssignmentRequest : TeaModel {
        /// <summary>
        /// <para>The name of the principal. When PrincipalType is set to User, specify the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// <para>The type of the principal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: User. Only this value is currently supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The name of the role to assign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyst</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
