// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of aggregation task groups.</para>
        /// </summary>
        [NameInMap("aggTaskGroups")]
        [Validation(Required=false)]
        public List<ListAggTaskGroupsResponseBodyAggTaskGroups> AggTaskGroups { get; set; }
        public class ListAggTaskGroupsResponseBodyAggTaskGroups : TeaModel {
            /// <summary>
            /// <para>Hash of the aggregation task group configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54136014xxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupConfigHash")]
            [Validation(Required=false)]
            public string AggTaskGroupConfigHash { get; set; }

            /// <summary>
            /// <para>ID of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aggTaskGroup-xxxx</para>
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
            /// <para>Cron expression for the aggregation task group when the scheduling mode is set to \&quot;Cron\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 10 8 1 * ? *</para>
            /// </summary>
            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            /// <summary>
            /// <para>Fixed delay time (in seconds) for scheduling.</para>
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
            /// <para>workspace api monitor update test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Start time of the schedule in seconds since epoch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>Scheduling interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-24 00:00:00,2025-04-24 00:00:00</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>Maximum number of retries for the aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public int? MaxRetries { get; set; }

            /// <summary>
            /// <para>Maximum retry time (in seconds) for the aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("maxRunTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunTimeInSeconds { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
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
            /// <para>The source Prometheus instance ID of the aggregation task group.</para>
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
            public List<ListAggTaskGroupsResponseBodyAggTaskGroupsTags> Tags { get; set; }
            public class ListAggTaskGroupsResponseBodyAggTaskGroupsTags : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("targetPrometheusId")]
            [Validation(Required=false)]
            public string TargetPrometheusId { get; set; }

            /// <summary>
            /// <para>The second-level timestamp corresponding to the end time of scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

            /// <summary>
            /// <para>Update time of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa9d0e569b880xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BF1F4D6-B9A8-5F0B-8C1D-4347FFCB798E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
