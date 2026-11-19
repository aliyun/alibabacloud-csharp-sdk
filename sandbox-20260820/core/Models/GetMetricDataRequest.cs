// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time series query. This time is exclusive. Specify a UTC time accurate to seconds. The end time must be later than the start time. You can query metrics for a maximum of 7 days at a time. The time range must include at least one time point aligned with the period, and these time points cannot be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:02:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Groups metrics by a specific key. For example, you can group metrics by teamID to view the metrics of each team separately. You can combine up to four different grouping keys. The available keys vary by metric. If you do not specify this parameter, the overall results within the query scope are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The names of the metrics to query. You can query 1 to 16 different metrics at a time. For available metrics and query scopes, refer to the metric catalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cpuUsedCores&quot;]</para>
        /// </summary>
        [NameInMap("metricNames")]
        [Validation(Required=false)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// <para>The time interval for time series queries, in seconds. Valid values: 60, 300, 900, 1800, 3600, and 86400. A value of 60 corresponds to exact minutes, and 86400 corresponds to 00:00:00 UTC every day. The calculation duration of some statistical metrics varies with the interval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The ID of the sandbox to query. You must also specify the teamID and templateID to which the sandbox belongs, and select a metric that supports sandbox-level queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-62105527-699e-48df-ad3b-7425001ae4f2</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>Queries the number of sandboxes by sandbox plan. This parameter applies only to the sandboxCount metric. Valid values: eco, std, pro, and ent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("sandboxPlan")]
        [Validation(Required=false)]
        public string SandboxPlan { get; set; }

        /// <summary>
        /// <para>The start time of the time series query. This time is inclusive. Specify a UTC time accurate to seconds, and also specify the endTime parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the team to query. If you leave this parameter empty, the metrics of the current account are queried.</para>
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
        /// <para>The specific point in time to query. If you query metrics at a specific point in time, specify only this parameter. Specify a current or past UTC time accurate to seconds. If you omit all time parameters, the metrics at the current time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:01:00Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
