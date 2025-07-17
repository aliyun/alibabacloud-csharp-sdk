// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the member in the workspace.</para>
        /// </summary>
        [NameInMap("ProjectMember")]
        [Validation(Required=false)]
        public GetProjectMemberResponseBodyProjectMember ProjectMember { get; set; }
        public class GetProjectMemberResponseBodyProjectMember : TeaModel {
            /// <summary>
            /// <para>The DataWorks workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88757</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The roles that are assigned to the member in the workspace.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<GetProjectMemberResponseBodyProjectMemberRoles> Roles { get; set; }
            public class GetProjectMemberResponseBodyProjectMemberRoles : TeaModel {
                /// <summary>
                /// <para>The code of the role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>role_project_admin: Workspace Administrator</description></item>
                /// <item><description>role_project_dev: Develop</description></item>
                /// <item><description>role_project_dg_admin: Data Governance Administrator</description></item>
                /// <item><description>role_project_guest: Visitor</description></item>
                /// <item><description>role_project_security: Security Administrator</description></item>
                /// <item><description>role_project_deploy: Deploy</description></item>
                /// <item><description>role_project_owner: Workspace Owner</description></item>
                /// <item><description>role_project_data_analyst: Data Analyst</description></item>
                /// <item><description>role_project_pe: O\&amp;M</description></item>
                /// <item><description>role_project_erd: Model Designer</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>role_project_guest</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Visitors</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UserCustom: custom role</description></item>
                /// <item><description>System: built-in role</description></item>
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
            /// <para>The status of the member.</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Forbidden</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the account used by the member in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123422344899</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
