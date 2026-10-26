// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAggTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the aggregation task group. Only the RecordingRuleYaml format is supported. The configuration must meet the format requirements of RecordingRule in open-source Prometheus.</para>
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
        /// <para>The configuration type of the aggregation task group. Default value: RecordingRuleYaml, which is the RecordingRule format of open-source Prometheus.</para>
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
        /// <para>The cron expression used when the scheduling mode is set to Cron. For example, 0/1 * * * * indicates that the task is scheduled every 1 minute starting from minute 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/1 * * * *</para>
        /// </summary>
        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        /// <summary>
        /// <para>The fixed delay time for scheduling, in seconds. Default value: 30.</para>
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
        /// <para>The timestamp of the scheduling start time, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724996015</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The maximum number of retries for executing the aggregation task. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum retry time to execute the aggregation node, in seconds. Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>The precheck configuration. By default, this parameter is not configured. The input string must be a valid JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;xxx&quot;,&quot;query&quot;:&quot;scalar(sum(count_over_time(up{job=\&quot;_arms/kubelet/cadvisor\&quot;}[15s])) / 21)&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;promql&quot;}</para>
        /// </summary>
        [NameInMap("precheckString")]
        [Validation(Required=false)]
        public string PrecheckString { get; set; }

        /// <summary>
        /// <para>The scheduling mode. Valid values: Cron and FixedRate. Default value: FixedRate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("scheduleMode")]
        [Validation(Required=false)]
        public string ScheduleMode { get; set; }

        /// <summary>
        /// <para>The scheduling time expression. Use @s or @m to specify the alignment granularity of the scheduling time window. Default value: @m.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("scheduleTimeExpr")]
        [Validation(Required=false)]
        public string ScheduleTimeExpr { get; set; }

        /// <summary>
        /// <para>The status of the aggregation task group. Valid values: Running and Stopped. Default value: Running.</para>
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
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The target Prometheus instance ID of the aggregation node group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

        /// <summary>
        /// <para>The timestamp of the scheduling end time, in seconds. A value of 0 indicates that the scheduling does not stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
