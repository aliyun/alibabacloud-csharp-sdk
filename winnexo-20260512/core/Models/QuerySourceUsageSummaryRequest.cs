// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySourceUsageSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group to which the resource belongs, such as cg_101. If you specify this parameter, a group workspace task is created, and the caller must be a valid group member. If you leave this parameter empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The actual end timestamp of the live stream, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T23:59:59+08:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserOperator</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base folder.</para>
        /// </summary>
        [NameInMap("knowledgeBaseIds")]
        [Validation(Required=false)]
        public List<string> KnowledgeBaseIds { get; set; }

        /// <summary>
        /// <para>The role scope type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_VISIBLE</b>: All members.</description></item>
        /// <item><description><b>PART_VISIBLE</b>: Partial members.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Report perspective: TENANT for enterprise knowledge, GROUP for a single workspace, and ALL_GROUPS for all workspaces of the current tenant (platform super administrator only). Valid values: TENANT, GROUP, and ALL_GROUPS</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// </summary>
        [NameInMap("sourceIds")]
        [Validation(Required=false)]
        public List<string> SourceIds { get; set; }

        /// <summary>
        /// <para>The resume channel source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The name of the source</para>
        /// </summary>
        [NameInMap("sourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tenant ID, which is a common parameter. If you use winnexo-cli, pass this parameter explicitly by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
