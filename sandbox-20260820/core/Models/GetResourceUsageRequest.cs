// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetResourceUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. This time is exclusive. Specify a full hour in UTC. The latest allowed time is the start of the current hour. You can query a maximum of 7 days at a time. The end time must be later than the start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T02:00:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The granularity for aggregating usage. Set to All to view the cumulative usage for the entire query interval. Set to Hour to view hourly usage. Set to Day to aggregate usage every 24 hours from the start time. The last interval can be less than 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Specifies the keys by which to group the results. You can use any combination of teamID, templateID, snapshotID, and sandboxPlan. Each key can be specified only once. If this parameter is not specified, the results are aggregated for the entire query range. If you group by snapshotID, only the usage associated with snapshots is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The sandbox plan to query. Valid values: eco, std, pro, and ent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("sandboxPlan")]
        [Validation(Required=false)]
        public string SandboxPlan { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot for which you want to query historical usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("snapshotID")]
        [Validation(Required=false)]
        public string SnapshotID { get; set; }

        /// <summary>
        /// <para>The start time of the query. This time is inclusive. Specify a full hour in UTC, such as 00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Specifies the team ID. Required when querying by team. If this parameter is omitted, the usage of the current account is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0333-58d8-97ac-5336eb9179eb</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The ID of the template to query. You must also specify the teamID to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4hrtmghh2nzrsdh6yr65</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>Specifies 1 to 8 different usage item names for each request. For available usage items, refer to the resource usage metrics catalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;activeVCPU&quot;]</para>
        /// </summary>
        [NameInMap("usageNames")]
        [Validation(Required=false)]
        public List<string> UsageNames { get; set; }

    }

}
