// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDefaultWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the creation stages of the default workspace.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<GetDefaultWorkspaceResponseBodyConditions> Conditions { get; set; }
        public class GetDefaultWorkspaceResponseBodyConditions : TeaModel {
            /// <summary>
            /// <para>The status code. A value of 200 indicates that the request was successful. Other values indicate that the request failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is empty if the status code is 200.</para>
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
            /// <item><description><para>CREATING: Creating.</para>
            /// </description></item>
            /// <item><description><para>WORKSPACE_CREATED: The workspace is created.</para>
            /// </description></item>
            /// <item><description><para>MEMBERS_ADDED: Members are added.</para>
            /// </description></item>
            /// <item><description><para>ENABLED: The process is complete.</para>
            /// </description></item>
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
        /// <para>The Alibaba Cloud account that created the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17915******4216</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description of the workspace.</para>
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
        /// <para>The environments in the workspace.</para>
        /// <list type="bullet">
        /// <item><description><para>A workspace in basic mode contains only the production (prod) environment.</para>
        /// </description></item>
        /// <item><description><para>A workspace in standard mode contains the development (dev) and production (prod) environments.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created. The time is in Coordinated Universal Time (UTC) and is formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace was last modified. The time is in UTC and is formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that created the workspace.</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public GetDefaultWorkspaceResponseBodyOwner Owner { get; set; }
        public class GetDefaultWorkspaceResponseBodyOwner : TeaModel {
            /// <summary>
            /// <para>The UID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17915******4216</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The UID of the user.</para>
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
        /// <para>The status of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ENABLED: Normal.</para>
        /// </description></item>
        /// <item><description><para>INITIALIZING: Initializing.</para>
        /// </description></item>
        /// <item><description><para>FAILURE: Failed.</para>
        /// </description></item>
        /// <item><description><para>DISABLED: Disabled.</para>
        /// </description></item>
        /// <item><description><para>FROZEN: Frozen due to an overdue payment.</para>
        /// </description></item>
        /// <item><description><para>UPDATING: The workspace is being updated.</para>
        /// </description></item>
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
        /// <para>The name of the workspace. The name must be unique within the same region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
