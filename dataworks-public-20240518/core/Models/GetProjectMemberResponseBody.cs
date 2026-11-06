// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the workspace member.</para>
        /// </summary>
        [NameInMap("ProjectMember")]
        [Validation(Required=false)]
        public GetProjectMemberResponseBodyProjectMember ProjectMember { get; set; }
        public class GetProjectMemberResponseBodyProjectMember : TeaModel {
            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88757</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of workspace roles assigned to the workspace member.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<GetProjectMemberResponseBodyProjectMemberRoles> Roles { get; set; }
            public class GetProjectMemberResponseBodyProjectMemberRoles : TeaModel {
                /// <summary>
                /// <para>The code of the workspace role. Built-in workspace roles in DataWorks:</para>
                /// <list type="bullet">
                /// <item><description>role_project_admin: workspace administrator</description></item>
                /// <item><description>role_project_dev: developer</description></item>
                /// <item><description>role_project_dg_admin: data governance administrator</description></item>
                /// <item><description>role_project_guest: guest</description></item>
                /// <item><description>role_project_security: security administrator</description></item>
                /// <item><description>role_project_deploy: deployer</description></item>
                /// <item><description>role_project_owner: workspace owner</description></item>
                /// <item><description>role_project_data_analyst: data analyst</description></item>
                /// <item><description>role_project_pe: operator</description></item>
                /// <item><description>role_project_erd: model designer</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>role_project_guest</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the workspace role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Visitors</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the workspace role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UserCustom: custom role</description></item>
                /// <item><description>System: system role</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the workspace member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The member is normal.</description></item>
            /// <item><description>Forbidden: The member is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123422344899</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The cloud account name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liusan</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
