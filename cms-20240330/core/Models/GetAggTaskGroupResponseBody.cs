// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAggTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The aggregation task group.</para>
        /// </summary>
        [NameInMap("aggTaskGroup")]
        [Validation(Required=false)]
        public GetAggTaskGroupResponseBodyAggTaskGroup AggTaskGroup { get; set; }
        public class GetAggTaskGroupResponseBodyAggTaskGroup : TeaModel {
            /// <summary>
            /// <para>The configuration of the aggregation task group.</para>
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
            /// <para>The summary of the aggregation task group configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54136xxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupConfigHash")]
            [Validation(Required=false)]
            public string AggTaskGroupConfigHash { get; set; }

            /// <summary>
            /// <para>The ID of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aggTaskGroup-xx</para>
            /// </summary>
            [NameInMap("aggTaskGroupId")]
            [Validation(Required=false)]
            public string AggTaskGroupId { get; set; }

            /// <summary>
            /// <para>The name of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline-aggtask-group</para>
            /// </summary>
            [NameInMap("aggTaskGroupName")]
            [Validation(Required=false)]
            public string AggTaskGroupName { get; set; }

            /// <summary>
            /// <para>The scheduling expression of the aggregation task group when the scheduling mode is set to Cron.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 1 3 * * ? *</para>
            /// </summary>
            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            /// <summary>
            /// <para>The fixed delay time for scheduling, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            /// <summary>
            /// <para>The description of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp in seconds that corresponds to the start time of the scheduling. This parameter is not yet in effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409495</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>The maximum number of retries to execute the aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public int? MaxRetries { get; set; }

            /// <summary>
            /// <para>The maximum runtime of the aggregation task, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxRunTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunTimeInSeconds { get; set; }

            /// <summary>
            /// <para>The dry run configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;policy&quot;:&quot;skip&quot;,&quot;prometheusId&quot;:&quot;rw-xx&quot;,&quot;query&quot;:&quot;noPrecheck&quot;,&quot;threshold&quot;:0.5,&quot;timeout&quot;:15,&quot;type&quot;:&quot;none&quot;}</para>
            /// </summary>
            [NameInMap("precheckString")]
            [Validation(Required=false)]
            public string PrecheckString { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The scheduling mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FixedRate</para>
            /// </summary>
            [NameInMap("scheduleMode")]
            [Validation(Required=false)]
            public string ScheduleMode { get; set; }

            /// <summary>
            /// <para>The scheduling time expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@m</para>
            /// </summary>
            [NameInMap("scheduleTimeExpr")]
            [Validation(Required=false)]
            public string ScheduleTimeExpr { get; set; }

            /// <summary>
            /// <para>The ID of the source Prometheus instance for the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("sourcePrometheusId")]
            [Validation(Required=false)]
            public string SourcePrometheusId { get; set; }

            /// <summary>
            /// <para>The status of the aggregation task group.</para>
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
            public List<GetAggTaskGroupResponseBodyAggTaskGroupTags> Tags { get; set; }
            public class GetAggTaskGroupResponseBodyAggTaskGroupTags : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("targetPrometheusId")]
            [Validation(Required=false)]
            public string TargetPrometheusId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp in seconds that corresponds to the end time of the scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409495</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

            /// <summary>
            /// <para>The time when the aggregation task group was updated. This is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user to which the aggregation task group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68DAF543-35DF-5762-BE90-F5C00B5DC036</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
