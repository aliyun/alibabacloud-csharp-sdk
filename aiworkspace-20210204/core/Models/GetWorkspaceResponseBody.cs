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
        /// <para>The user ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1157******94123</para>
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
        /// <para>The environments included in the workspace.</para>
        /// <list type="bullet">
        /// <item><description>Simple mode includes only the production environment (prod).</description></item>
        /// <item><description>Standard mode includes the development environment (dev) and the production environment (prod).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>The extra information, which currently includes TenantId (tenant ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TenantId&quot;: &quot;4286******98&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfos")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfos { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created. The time is displayed in UTC and formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace was modified. The time is displayed in UTC and formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the workspace is the default workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The workspace is not the default workspace.</description></item>
        /// <item><description>true: The workspace is the default workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The workspace owner information. Displayed when Verbose is set to true.</para>
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
        /// <para>The workspace status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: Normal.</description></item>
        /// <item><description>INITIALIZING: Initializing.</description></item>
        /// <item><description>FAILURE: Failed.</description></item>
        /// <item><description>DISABLED: Manually disabled.</description></item>
        /// <item><description>FROZEN: Frozen due to overdue payment.</description></item>
        /// <item><description>UPDATING: Updating.</description></item>
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
