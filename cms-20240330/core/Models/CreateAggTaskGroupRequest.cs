// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAggTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the aggregation task group.
        /// Only the \<c>RecordingRuleYaml\\</c> format is supported. The configuration must follow the format of RecordingRule for open source Prometheus.</para>
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
        /// <para>The type of the aggregation task group configuration. The default value is \<c>RecordingRuleYaml\\</c>. This is the format of RecordingRule for open source Prometheus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RecordingRuleYaml</para>
        /// </summary>
        [NameInMap("aggTaskGroupConfigType")]
        [Validation(Required=false)]
        public string AggTaskGroupConfigType { get; set; }

        /// <summary>
        /// <para>The name of the aggregation task group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-group</para>
        /// </summary>
        [NameInMap("aggTaskGroupName")]
        [Validation(Required=false)]
        public string AggTaskGroupName { get; set; }

        /// <summary>
        /// <para>The cron expression for scheduling when \<c>scheduleMode\\</c> is set to \<c>Cron\\</c>. For example, \<c>0/1 \\* \\* \\* \\*\\</c> indicates that the task is scheduled every minute, starting from minute 0.</para>
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
        /// <para>The UNIX timestamp for the scheduling start time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724996015</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The maximum number of retries for an aggregation task. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum retry time for an aggregation task. Unit: seconds. The default value is 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>The dry run configuration. This parameter is not configured by default. The input string must be a parsable JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;xxx&quot;,&quot;query&quot;:&quot;scalar(sum(count_over_time(up{job=\&quot;_arms/kubelet/cadvisor\&quot;}[15s])) / 21)&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;promql&quot;}</para>
        /// </summary>
        [NameInMap("precheckString")]
        [Validation(Required=false)]
        public string PrecheckString { get; set; }

        /// <summary>
        /// <para>The scheduling mode. Valid values: \<c>Cron\\</c> and \<c>FixedRate\\</c>. The default value is \<c>FixedRate\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("scheduleMode")]
        [Validation(Required=false)]
        public string ScheduleMode { get; set; }

        /// <summary>
        /// <para>The scheduling time expression. The recommended values are \<c>@s\\</c> and \<c>@m\\</c>. This expression specifies the granularity to which the time window is snapped. The default value is \<c>@m\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("scheduleTimeExpr")]
        [Validation(Required=false)]
        public string ScheduleTimeExpr { get; set; }

        /// <summary>
        /// <para>The status of the aggregation task group. Valid values: \<c>Running\\</c> and \<c>Stopped\\</c>. The default value is \<c>Running\\</c>.</para>
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
        public List<CreateAggTaskGroupRequestTags> Tags { get; set; }
        public class CreateAggTaskGroupRequestTags : TeaModel {
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
        /// <para>The UNIX timestamp for the scheduling end time. Unit: seconds. A value of 0 means that scheduling does not stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite an existing resource with the same name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("overrideIfExists")]
        [Validation(Required=false)]
        public bool? OverrideIfExists { get; set; }

    }

}
