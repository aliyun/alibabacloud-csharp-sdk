// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAggTaskGroupRequest : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>RecordingRuleYaml</para>
        /// </summary>
        [NameInMap("aggTaskGroupConfigType")]
        [Validation(Required=false)]
        public string AggTaskGroupConfigType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-group</para>
        /// </summary>
        [NameInMap("aggTaskGroupName")]
        [Validation(Required=false)]
        public string AggTaskGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0/1 * * * *</para>
        /// </summary>
        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724996015</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;xxx&quot;,&quot;query&quot;:&quot;scalar(sum(count_over_time(up{job=\&quot;_arms/kubelet/cadvisor\&quot;}[15s])) / 21)&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;promql&quot;}</para>
        /// </summary>
        [NameInMap("precheckString")]
        [Validation(Required=false)]
        public string PrecheckString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("scheduleMode")]
        [Validation(Required=false)]
        public string ScheduleMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("scheduleTimeExpr")]
        [Validation(Required=false)]
        public string ScheduleTimeExpr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateAggTaskGroupRequestTags> Tags { get; set; }
        public class CreateAggTaskGroupRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("overrideIfExists")]
        [Validation(Required=false)]
        public bool? OverrideIfExists { get; set; }

    }

}
