// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAggTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Aggregation task group.</para>
        /// </summary>
        [NameInMap("aggTaskGroup")]
        [Validation(Required=false)]
        public GetAggTaskGroupResponseBodyAggTaskGroup AggTaskGroup { get; set; }
        public class GetAggTaskGroupResponseBodyAggTaskGroup : TeaModel {
            /// <summary>
            /// <para>Aggregation task group configuration.</para>
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
            /// <para>Summary of the aggregation task group configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54136xxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupConfigHash")]
            [Validation(Required=false)]
            public string AggTaskGroupConfigHash { get; set; }

            /// <summary>
            /// <para>ID of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aggTaskGroup-xx</para>
            /// </summary>
            [NameInMap("aggTaskGroupId")]
            [Validation(Required=false)]
            public string AggTaskGroupId { get; set; }

            /// <summary>
            /// <para>Name of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline-aggtask-group</para>
            /// </summary>
            [NameInMap("aggTaskGroupName")]
            [Validation(Required=false)]
            public string AggTaskGroupName { get; set; }

            /// <summary>
            /// <para>Scheduling expression for the aggregation task group when the scheduling mode is \&quot;Cron\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 1 3 * * ? *</para>
            /// </summary>
            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            /// <summary>
            /// <para>Fixed delay time (in seconds) for scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            /// <summary>
            /// <para>Description of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Second-level timestamp corresponding to the start time of scheduling (not yet effective).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409495</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>Maximum number of retries for executing the aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public int? MaxRetries { get; set; }

            /// <summary>
            /// <para>Maximum retry time for executing the aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxRunTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunTimeInSeconds { get; set; }

            /// <summary>
            /// <para>Pre-check configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;rw-xx&quot;,&quot;query&quot;:&quot;noPrecheck&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;none&quot;}</para>
            /// </summary>
            [NameInMap("precheckString")]
            [Validation(Required=false)]
            public string PrecheckString { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Scheduling mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FixedRate</para>
            /// </summary>
            [NameInMap("scheduleMode")]
            [Validation(Required=false)]
            public string ScheduleMode { get; set; }

            /// <summary>
            /// <para>Scheduling time expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@m</para>
            /// </summary>
            [NameInMap("scheduleTimeExpr")]
            [Validation(Required=false)]
            public string ScheduleTimeExpr { get; set; }

            /// <summary>
            /// <para>ID of the source Prometheus instance for the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("sourcePrometheusId")]
            [Validation(Required=false)]
            public string SourcePrometheusId { get; set; }

            /// <summary>
            /// <para>Status of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Resource group tags</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetAggTaskGroupResponseBodyAggTaskGroupTags> Tags { get; set; }
            public class GetAggTaskGroupResponseBodyAggTaskGroupTags : TeaModel {
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
            /// <para>The target Prometheus instance ID of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("targetPrometheusId")]
            [Validation(Required=false)]
            public string TargetPrometheusId { get; set; }

            /// <summary>
            /// <para>The second-level timestamp corresponding to the end time of the scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409495</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

            /// <summary>
            /// <para>The update time (timestamp) of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user to whom the aggregation task group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>68DAF543-35DF-5762-BE90-F5C00B5DC036</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
