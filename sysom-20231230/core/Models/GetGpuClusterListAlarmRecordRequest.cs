// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterListAlarmRecordRequest : TeaModel {
        /// <summary>
        /// <para>The cluster to query. Specify a cluster, such as &quot;cluster1&quot;. To query multiple clusters, separate them with commas, such as &quot;cluster1,cluster2,cluster3&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;cluster1&quot;</para>
        /// </summary>
        [NameInMap("alarmCluster")]
        [Validation(Required=false)]
        public string AlarmCluster { get; set; }

        /// <summary>
        /// <para>The instance ID or container used to filter anomalies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance id</para>
        /// </summary>
        [NameInMap("alarmExtInfo")]
        [Validation(Required=false)]
        public string AlarmExtInfo { get; set; }

        /// <summary>
        /// <para>The task to query. Specify a task, such as &quot;task1&quot;. To query multiple tasks, separate them with commas, such as &quot;task1,task2,task3&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task id</para>
        /// </summary>
        [NameInMap("alarmTask")]
        [Validation(Required=false)]
        public string AlarmTask { get; set; }

        /// <summary>
        /// <para>The specific time or time range to query. Specify a specific time, such as &quot;2025-08-22 18:16:25&quot;. To specify a time range, use the &quot;start,end&quot; format, such as &quot;2025-08-22 18:16:25,2025-08-23 18:16:25&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2025-08-22 18:16:25,2025-08-23 18:16:25&quot;</para>
        /// </summary>
        [NameInMap("alarmTime")]
        [Validation(Required=false)]
        public string AlarmTime { get; set; }

        /// <summary>
        /// <para>The anomaly type used to filter results, such as GPU memory access out of bounds or task hang.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cuda error</para>
        /// </summary>
        [NameInMap("alarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        /// <summary>
        /// <para>The current page number for pagination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>The number of entries per page for pagination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The task status used to filter results. Valid values: blocking, running, exited, and restart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
