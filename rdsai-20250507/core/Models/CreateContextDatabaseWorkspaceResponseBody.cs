// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateContextDatabaseWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The plaintext API key. This value is returned only once at creation time. The caller must persist it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ctxdb-*****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The name of the first API key. The value is fixed as default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ApiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-28T17:59:55Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the first member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mb-cz51tnnp8****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The name of the first member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-member</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role of the first member. The value is fixed as owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The workspace status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: running normally.</description></item>
        /// <item><description>Locked: locked due to overdue payment or expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The workspace type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>personal: individual account.</description></item>
        /// <item><description>enterprise: enterprise account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>personal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the new workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
