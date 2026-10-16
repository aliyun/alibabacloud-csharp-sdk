// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role information.</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateRoleResponseBodyRole Role { get; set; }
        public class CreateRoleResponseBodyRole : TeaModel {
            /// <summary>
            /// <para>The time when the role was created. The time is displayed in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data analyst role</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The type of the role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: the default role that is automatically provisioned when the user pool is created</description></item>
            /// <item><description>Manual: a custom role that is manually created by calling an API operation</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the role was updated. The time is displayed in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
