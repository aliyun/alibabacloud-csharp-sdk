// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of aggregation task groups.</para>
        /// </summary>
        [NameInMap("aggTaskGroups")]
        [Validation(Required=false)]
        public List<ListAggTaskGroupsResponseBodyAggTaskGroups> AggTaskGroups { get; set; }
        public class ListAggTaskGroupsResponseBodyAggTaskGroups : TeaModel {
            /// <summary>
            /// <para>The summary of the aggregation task group configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a54136014xxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupConfigHash")]
            [Validation(Required=false)]
            public string AggTaskGroupConfigHash { get; set; }

            /// <summary>
            /// <para>The ID of the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aggTaskGroup-xxxx</para>
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
            /// <para>The scheduling expression for the aggregation task group when the scheduling mode is \<c>Cron\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 10 8 1 * ? *</para>
            /// </summary>
            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            /// <summary>
            /// <para>The fixed delay for scheduling, in seconds.</para>
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
            /// <para>workspace api monitor update test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp that indicates the scheduling start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>The scheduling interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-24 00:00:00,2025-04-24 00:00:00</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>The maximum number of retries for an aggregation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public int? MaxRetries { get; set; }

            /// <summary>
            /// <para>The maximum retry duration for an aggregation task, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("maxRunTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunTimeInSeconds { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
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
            /// <para>The ID of the target Prometheus instance for the aggregation task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("targetPrometheusId")]
            [Validation(Required=false)]
            public string TargetPrometheusId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp that indicates the scheduling end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

            /// <summary>
            /// <para>The time when the aggregation task group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to use to retrieve the next page of results. This value is empty when there are no more results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa9d0e569b880xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BF1F4D6-B9A8-5F0B-8C1D-4347FFCB798E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
