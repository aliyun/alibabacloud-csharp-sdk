// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the administrator accounts.</para>
        /// </summary>
        [NameInMap("AdminNames")]
        [Validation(Required=false)]
        public List<string> AdminNames { get; set; }

        /// <summary>
        /// <para>The ID of the user who creates the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1157******94123</para>
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
        /// <para>The environment information of the workspace.</para>
        /// <list type="bullet">
        /// <item><description>Workspaces in basic mode can run only in the production environment.</description></item>
        /// <item><description>Workspaces in standard mode can run in both the development and production environments.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>The additional information, which only contains the TenantId field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TenantId&quot;: &quot;4286******98&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfos")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfos { get; set; }

        /// <summary>
        /// <para>The time when the workspace is created, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace is modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the workspace is the default workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The information about the workspace owner. This parameter is valid only when Verbose is set to true.</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public GetWorkspaceResponseBodyOwner Owner { get; set; }
        public class GetWorkspaceResponseBodyOwner : TeaModel {
            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mings****t</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1157******94123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1157******94123</para>
            /// </summary>
            [NameInMap("UserKp")]
            [Validation(Required=false)]
            public string UserKp { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mings****t</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0F049F0-8D69-5BAC-8F10-B4DED1B5A34C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwp7rkyq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The workspace state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED</description></item>
        /// <item><description>INITIALIZING</description></item>
        /// <item><description>FAILURE:</description></item>
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
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
