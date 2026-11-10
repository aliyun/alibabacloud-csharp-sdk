// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateContextDatabaseWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the workspace belongs. This parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the cluster selection logic that prioritizes account-exclusive storage is used.</description></item>
        /// <item><description><c>default</c>: The shared cluster is used.</description></item>
        /// <item><description>Cluster IDs starting with <c>acc-</c>: The associated dedicated cluster is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate an initial API key. This parameter is optional. Default value: <c>true</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Generates the first API key and returns the key name and plaintext key.</description></item>
        /// <item><description><c>false</c>: Does not generate an initial API key. The ApiKeyName and ApiKey fields in the response are empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GenerateInitialKey")]
        [Validation(Required=false)]
        public bool? GenerateInitialKey { get; set; }

        /// <summary>
        /// <para>The name of the first member when the workspace is created. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-member</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The permission mode selected when the workspace is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>compatibility</c>: The compatibility mode. This mode is used if you do not specify this parameter.</description></item>
        /// <item><description><c>advanced</c>: The advanced permission mode. Only the Alibaba Cloud account can select this mode. It takes effect immediately after the workspace is created and cannot be disabled.</description></item>
        /// </list>
        /// <para>This parameter is a string, not a Boolean switch. Valid values are case-insensitive and ignore leading and trailing whitespace. If you explicitly pass an empty string, pure whitespace, or other values, <c>InvalidParameter</c> (HTTP 400) is returned. If a RAM user selects <c>advanced</c>, <c>NoPermission</c> (HTTP 403) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("PermissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
