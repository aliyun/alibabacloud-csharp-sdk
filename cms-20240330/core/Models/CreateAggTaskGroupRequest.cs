// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAggTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>Aggregation task group configuration.
        /// Currently, only the “RecordingRuleYaml” format is supported, which must comply with the format requirements of open-source Prometheus RecordingRules.</para>
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
        /// <para>Aggregation task group configuration type, default is “RecordingRuleYaml” (open-source Prometheus RecordingRule format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>RecordingRuleYaml</para>
        /// </summary>
        [NameInMap("aggTaskGroupConfigType")]
        [Validation(Required=false)]
        public string AggTaskGroupConfigType { get; set; }

        /// <summary>
        /// <para>Aggregation task group name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-group</para>
        /// </summary>
        [NameInMap("aggTaskGroupName")]
        [Validation(Required=false)]
        public string AggTaskGroupName { get; set; }

        /// <summary>
        /// <para>When the scheduling mode is selected as “Cron”, this is the specific scheduling expression. For example, “0/1 * * * *” means starting from 0 minutes and scheduling every 1 minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/1 * * * *</para>
        /// </summary>
        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        /// <summary>
        /// <para>Fixed delay time for scheduling, in seconds, default is 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// <para>Description of the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The second-level timestamp corresponding to the start time of the schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724996015</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>Maximum number of retries for executing the aggregation task, default is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// <para>Maximum retry time for executing the aggregation task, in seconds, default is 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>Pre-check configuration, no configuration by default. The input string needs to be correctly parsed as JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;xxx&quot;,&quot;query&quot;:&quot;scalar(sum(count_over_time(up{job=\&quot;_arms/kubelet/cadvisor\&quot;}[15s])) / 21)&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;promql&quot;}</para>
        /// </summary>
        [NameInMap("precheckString")]
        [Validation(Required=false)]
        public string PrecheckString { get; set; }

        /// <summary>
        /// <para>Scheduling mode, either “Cron” or “FixedRate”, default is “FixedRate”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("scheduleMode")]
        [Validation(Required=false)]
        public string ScheduleMode { get; set; }

        /// <summary>
        /// <para>Scheduling time expression, recommended “@s” or “@m”, indicating the alignment granularity of the scheduling time window, default is “@m”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("scheduleTimeExpr")]
        [Validation(Required=false)]
        public string ScheduleTimeExpr { get; set; }

        /// <summary>
        /// <para>Status of the aggregation task group, either “Running” or “Stopped”. Default is Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Resource group tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateAggTaskGroupRequestTags> Tags { get; set; }
        public class CreateAggTaskGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>Key of the resource group tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Value of the resource group tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The target Prometheus instance ID of the aggregation task group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

        /// <summary>
        /// <para>The second-level timestamp corresponding to the end time of the schedule, 0 indicates that the scheduling does not stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <para>Whether to overwrite and update if a resource with the same name exists when creating an aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("overrideIfExists")]
        [Validation(Required=false)]
        public bool? OverrideIfExists { get; set; }

    }

}
