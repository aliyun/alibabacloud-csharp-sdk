// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAggTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the aggregation task group. Currently, only the RecordingRuleYaml format is supported. The configuration must comply with the RecordingRule format of open source Prometheus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groups:</para>
        /// <list type="bullet">
        /// <item><description>name: &quot;node.rules&quot;
        /// interval: &quot;60s&quot;
        /// rules:<list type="bullet">
        /// <item><description>record: &quot;node_namespace_pod:kube_pod_info:&quot;
        /// expr: &quot;max(label_replace(kube_pod_info{job=\&quot;kubernetes-pods-kube-state-metrics\&quot;\
        ///   }, \&quot;pod\&quot;, \&quot;$1\&quot;, \&quot;pod\&quot;, \&quot;(.*)\&quot;)) by (node, namespace, pod, cluster)&quot;</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("aggTaskGroupConfig")]
        [Validation(Required=false)]
        public string AggTaskGroupConfig { get; set; }

        /// <summary>
        /// <para>The type of the aggregation task group configuration. The default value is RecordingRuleYaml, which is the RecordingRule format of open source Prometheus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RecordingRuleYaml</para>
        /// </summary>
        [NameInMap("aggTaskGroupConfigType")]
        [Validation(Required=false)]
        public string AggTaskGroupConfigType { get; set; }

        /// <summary>
        /// <para>The name of the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-group</para>
        /// </summary>
        [NameInMap("aggTaskGroupName")]
        [Validation(Required=false)]
        public string AggTaskGroupName { get; set; }

        /// <summary>
        /// <para>The cron expression for scheduling when the scheduling mode is set to Cron. For example, \<c>0/1 \\* \\* \\* \\*\\</c> indicates that the task is scheduled every 1 minute, starting from the 0th minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/1 * * * *</para>
        /// </summary>
        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        /// <summary>
        /// <para>The fixed delay for scheduling. Unit: seconds. The default value is 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// <para>The description of the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp in seconds that indicates the start time of the scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724996015</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The maximum number of retries to execute the aggregation task. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum retry time to execute the aggregation task. Unit: seconds. The default value is 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>The dry run configuration. This parameter is not configured by default. The input string must be a valid JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;xxx&quot;,&quot;query&quot;:&quot;scalar(sum(count_over_time(up{job=\&quot;_arms/kubelet/cadvisor\&quot;}[15s])) / 21)&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;promql&quot;}</para>
        /// </summary>
        [NameInMap("precheckString")]
        [Validation(Required=false)]
        public string PrecheckString { get; set; }

        /// <summary>
        /// <para>The scheduling mode. Valid values: Cron and FixedRate. The default value is FixedRate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("scheduleMode")]
        [Validation(Required=false)]
        public string ScheduleMode { get; set; }

        /// <summary>
        /// <para>The scheduling time expression. Recommended values are \<c>@s\\</c> and \<c>@m\\</c>. This expression indicates the granularity at which the scheduling time window is snapped. The default value is \<c>@m\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("scheduleTimeExpr")]
        [Validation(Required=false)]
        public string ScheduleTimeExpr { get; set; }

        /// <summary>
        /// <para>The status of the aggregation task group. Valid values: Running and Stopped. The default value is Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the resource group.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<UpdateAggTaskGroupRequestTags> Tags { get; set; }
        public class UpdateAggTaskGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the resource group tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource group tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the target Prometheus instance for the aggregation task group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp in seconds that indicates the end time of the scheduling. A value of 0 indicates that the scheduling does not stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
