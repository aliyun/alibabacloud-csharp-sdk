// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of administrator account names.</para>
        /// </summary>
        [NameInMap("AdminNames")]
        [Validation(Required=false)]
        public List<string> AdminNames { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the workspace.</para>
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
        /// <para>The environments that the workspace contains. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>A workspace in basic mode has only the production environment (prod).</para>
        /// </description></item>
        /// <item><description><para>A workspace in standard mode has both the development environment (dev) and the production environment (prod).</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>Additional information. This parameter currently contains the tenant ID (TenantId).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TenantId&quot;: &quot;4286******98&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfos")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfos { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created. The time is in UTC and follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace was last modified. The time is in UTC and follows the ISO 8601 standard.</para>
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
        /// <item><description><para>false: The workspace is not the default workspace.</para>
        /// </description></item>
        /// <item><description><para>true: The workspace is the default workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The information about the workspace owner. This parameter is returned only when Verbose is set to true.</para>
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
            /// <para>The user UID.</para>
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
        /// <para>The status of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ENABLED: The workspace is running as normal.</para>
        /// </description></item>
        /// <item><description><para>INITIALIZING: The workspace is being initialized.</para>
        /// </description></item>
        /// <item><description><para>FAILURE: The workspace failed to be created.</para>
        /// </description></item>
        /// <item><description><para>DISABLED: The workspace is manually disabled.</para>
        /// </description></item>
        /// <item><description><para>FROZEN: The workspace is frozen due to an overdue payment.</para>
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
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
