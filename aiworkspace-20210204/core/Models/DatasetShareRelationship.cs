// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetShareRelationship : TeaModel {
        /// <summary>
        /// <para>The allowed permissions for the shared dataset. When a user accesses the shared dataset, their permissions are limited to this list. The default value is \<c>[&quot;RO&quot;]\\</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>RO: Read-only permission. The recipient can only read the dataset.</para>
        /// </description></item>
        /// <item><description><para>RW: Read and write permission. The recipient can read and modify the dataset.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AllowedMountAccessLevels")]
        [Validation(Required=false)]
        public List<string> AllowedMountAccessLevels { get; set; }

        /// <summary>
        /// <para>The expiration time. The time is in ISO 8601 format.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the sharing relationship never expires.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T12:23:58Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>Additional configurations for the sharing relationship. This parameter is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>AllowExportModel: Specifies whether to allow the export of trained models.</para>
        /// </description></item>
        /// <item><description><para>AllowAccessDLCWebTerminal: Specifies whether to allow users to log on to the container in a DLC task.</para>
        /// </description></item>
        /// <item><description><para>AllowAccessDLCFullLog: Specifies whether to allow access to the full task logs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AllowExportModel&quot;:false,&quot;AllowAccessDLCWebTerminal&quot;:false,&quot;AllowAccessDLCFullLog&quot;:false}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security protection for the shared dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSecureMode")]
        [Validation(Required=false)]
        public bool? IsSecureMode { get; set; }

        /// <summary>
        /// <para>The time when the dataset was shared. The time is in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-27T12:23:58Z</para>
        /// </summary>
        [NameInMap("SharedAt")]
        [Validation(Required=false)]
        public string SharedAt { get; set; }

        /// <summary>
        /// <para>The ID of the tenant that owns the source dataset. The user who shares the dataset must be a workspace administrator or the root account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>148***************115</para>
        /// </summary>
        [NameInMap("SourceTenantId")]
        [Validation(Required=false)]
        public string SourceTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the source dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33**19</para>
        /// </summary>
        [NameInMap("SourceWorkspaceId")]
        [Validation(Required=false)]
        public string SourceWorkspaceId { get; set; }

        /// <summary>
        /// <para>The status of the sharing relationship.</para>
        /// <list type="bullet">
        /// <item><description><para>ACTIVE: The sharing relationship is active. Complete dataset information is displayed only in this state.</para>
        /// </description></item>
        /// <item><description><para>EXPIRED: The sharing relationship has expired.</para>
        /// </description></item>
        /// <item><description><para>REVOKED: The sharing relationship was revoked by the sharer.</para>
        /// </description></item>
        /// <item><description><para>INVALID: The sharing relationship is invalid. This can happen if the source dataset is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the target tenant. This must be a root account ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you set a sharing relationship.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>153***************249</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the target workspace. This ID must be different from the source workspace ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you set a sharing relationship.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>42**2</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
