// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The end time for a time-series query, exclusive. Specify a UTC time in whole seconds, which must be later than startTime. You can query data for up to 7 days at a time. The time range must include at least one time point aligned with period, and these time points cannot be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:02:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>For example, grouping by teamID allows you to view the metrics of each team separately. You can combine up to four different grouping keys. The available keys vary by metric. If not specified, the overall results for the query scope are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>Specifies 1 to 16 different metric names in each request. For available metrics and their applicable scopes, see the monitoring metrics folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cpuUsedCores&quot;]</para>
        /// </summary>
        [NameInMap("metricNames")]
        [Validation(Required=false)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// <para>Required for both single-point and time-series queries. In a time-series query, this parameter specifies the interval between adjacent data points in seconds. Valid values: 60, 300, 900, 1800, 3600, and 86400.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The ID of the sandbox to query. You must also specify the teamID and templateID to which the sandbox belongs, and select a metric that supports querying by sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-62105527-699e-48df-ad3b-7425001ae4f2</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>Queries the number of sandboxes by sandbox edition. This parameter applies only to sandboxCount. Valid values: eco, std, pro, and ent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("sandboxPlan")]
        [Validation(Required=false)]
        public string SandboxPlan { get; set; }

        /// <summary>
        /// <para>The start time for a time-series query, inclusive. Specify a UTC time accurate to seconds as shown in the example, and also specify endTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Required when you query by team. If omitted, the metrics of the current account are queried. Account quotas and team quotas must be queried separately.</para>
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
        /// <para>The point in time for a single-point query. Specify the current or a past UTC time, accurate to seconds. If time, startTime, and endTime are omitted, the current time is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:01:00Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
