// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySourceUsageTrendShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group to which the resource belongs, such as cg_101. If this parameter is specified, a group workspace task is created, and the caller must be a valid group member. If this parameter is left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
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
        /// <para>MAIN</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The aggregation granularity. Valid values: hourly and daily.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The IDs of the knowledge base folders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;kb_9401&quot;]</para>
        /// </summary>
        [NameInMap("knowledgeBaseIds")]
        [Validation(Required=false)]
        public string KnowledgeBaseIdsShrink { get; set; }

        /// <summary>
        /// <para>The role scope type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_VISIBLE</b>: All members.</description></item>
        /// <item><description><b>PART_VISIBLE</b>: Partial members.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Report perspective: TENANT for enterprise knowledge, GROUP for a single workspace, ALL_GROUPS for all workspaces of the current tenant (platform super administrator only). Valid values: TENANT, GROUP, and ALL_GROUPS</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The IDs of the resource sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;src_9401&quot;]</para>
        /// </summary>
        [NameInMap("sourceIds")]
        [Validation(Required=false)]
        public string SourceIdsShrink { get; set; }

        /// <summary>
        /// <para>The resume channel source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The naming content of the source</para>
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
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
