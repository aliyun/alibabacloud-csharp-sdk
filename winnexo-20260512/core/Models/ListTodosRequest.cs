// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListTodosRequest : TeaModel {
        /// <summary>
        /// <para>The platform application token issued by the console. If specified, the operation is performed as the user identified by opsUserId or opsUserCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The collaboration workspace ID. This is an optional filter. If not specified, all workspaces are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy search in the title or summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approval</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 100. This parameter takes precedence over pageSize if both are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Use the nextToken value returned in the previous response. This parameter takes precedence over page if both are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The proxy user code, which is unique within the tenant. This parameter is used only when the application credential is configured as source_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The proxy user ID, which is the WINNEXO platform user ID. This parameter is used only when the application credential is configured as winnexo_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is ignored if nextToken is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The priority filter. Valid values: HIGH, MEDIUM, LOW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HIGH&quot;,&quot;MEDIUM&quot;]</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public List<string> Priorities { get; set; }

        /// <summary>
        /// <para>The read status filter. Valid values: UNREAD, READ. The status is determined by the readAt time of the assignee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;UNREAD&quot;,&quot;READ&quot;]</para>
        /// </summary>
        [NameInMap("readStatus")]
        [Validation(Required=false)]
        public List<string> ReadStatus { get; set; }

        /// <summary>
        /// <para>The sorting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The to-do type filter. Valid values: WORKFLOW, OPEN_API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;WORKFLOW&quot;,&quot;OPEN_API&quot;]</para>
        /// </summary>
        [NameInMap("sourceTypes")]
        [Validation(Required=false)]
        public List<string> SourceTypes { get; set; }

        /// <summary>
        /// <para>The to-do status filter. Valid values: PENDING, COMPLETED, CANCELLED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;PENDING&quot;,&quot;COMPLETED&quot;]</para>
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
