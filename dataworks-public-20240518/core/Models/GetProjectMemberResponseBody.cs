// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Workspace member.</para>
        /// </summary>
        [NameInMap("ProjectMember")]
        [Validation(Required=false)]
        public GetProjectMemberResponseBodyProjectMember ProjectMember { get; set; }
        public class GetProjectMemberResponseBodyProjectMember : TeaModel {
            /// <summary>
            /// <para>The ID of the Workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88757</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Roles assigned to the Workspace member.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<GetProjectMemberResponseBodyProjectMemberRoles> Roles { get; set; }
            public class GetProjectMemberResponseBodyProjectMemberRoles : TeaModel {
                /// <summary>
                /// <para>The code of the Workspace role.</para>
                /// <para>The built-in system roles in a DataWorks Workspace include:</para>
                /// <list type="bullet">
                /// <item><description><para>role_project_admin: Workspace Administrator</para>
                /// </description></item>
                /// <item><description><para>role_project_dev: Developer</para>
                /// </description></item>
                /// <item><description><para>role_project_dg_admin: Data Governance Administrator</para>
                /// </description></item>
                /// <item><description><para>role_project_guest: Guest</para>
                /// </description></item>
                /// <item><description><para>role_project_security: Security Administrator</para>
                /// </description></item>
                /// <item><description><para>role_project_deploy: Deployment</para>
                /// </description></item>
                /// <item><description><para>role_project_owner: Workspace Owner</para>
                /// </description></item>
                /// <item><description><para>role_project_data_analyst: Data Analyst</para>
                /// </description></item>
                /// <item><description><para>role_project_pe: O\&amp;M (Operations &amp; Maintenance)</para>
                /// </description></item>
                /// <item><description><para>role_project_erd: Model Designer</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>role_project_guest</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the Workspace role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Visitors</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the Workspace role.</para>
                /// <list type="bullet">
                /// <item><description><para>UserCustom: A user-defined role.</para>
                /// </description></item>
                /// <item><description><para>System: A built-in System Role.</para>
                /// </description></item>
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
            /// <para>The status of the Workspace member.</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: The member is active.</para>
            /// </description></item>
            /// <item><description><para>Disabled: The member is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123422344899</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
