// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDefaultWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The conditions of the default workspace in the creation process.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<GetDefaultWorkspaceResponseBodyConditions> Conditions { get; set; }
        public class GetDefaultWorkspaceResponseBodyConditions : TeaModel {
            /// <summary>
            /// <para>The returned status code. HTTP status code 200 indicates that the request was successful. Other HTTP status codes indicate that the request failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            /// <summary>
            /// <para>The error message. If the returned status code is 200, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create Failed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The workspace is being created.</description></item>
            /// <item><description>WORKSPACE_CREATED: The workspace is created.</description></item>
            /// <item><description>MEMBERS_ADDED: The member is added.</description></item>
            /// <item><description>ENABLED: The workspace is created and the member is added.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17915******4216</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The workspace description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace description example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The environments of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Workspaces in basic mode can run only in the production environment.</description></item>
        /// <item><description>Workspaces in standard mode can run in both the development and production environments.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace was modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public GetDefaultWorkspaceResponseBodyOwner Owner { get; set; }
        public class GetDefaultWorkspaceResponseBodyOwner : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17915******4216</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17915******4216</para>
            /// </summary>
            [NameInMap("UserKp")]
            [Validation(Required=false)]
            public string UserKp { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workspace status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED</description></item>
        /// <item><description>INITIALIZING</description></item>
        /// <item><description>FAILURE</description></item>
        /// <item><description>DISABLED</description></item>
        /// <item><description>FROZEN</description></item>
        /// <item><description>UPDATING</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The workspace name, which is unique in a region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
