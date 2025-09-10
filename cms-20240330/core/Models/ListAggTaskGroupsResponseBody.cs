// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsResponseBody : TeaModel {
        [NameInMap("aggTaskGroups")]
        [Validation(Required=false)]
        public List<ListAggTaskGroupsResponseBodyAggTaskGroups> AggTaskGroups { get; set; }
        public class ListAggTaskGroupsResponseBodyAggTaskGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a54136014xxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupConfigHash")]
            [Validation(Required=false)]
            public string AggTaskGroupConfigHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aggTaskGroup-xxxx</para>
            /// </summary>
            [NameInMap("aggTaskGroupId")]
            [Validation(Required=false)]
            public string AggTaskGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pipeline-aggtask-group</para>
            /// </summary>
            [NameInMap("aggTaskGroupName")]
            [Validation(Required=false)]
            public string AggTaskGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 10 8 1 * ? *</para>
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
            /// <para>workspace api monitor update test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-24 00:00:00,2025-04-24 00:00:00</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public int? MaxRetries { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("maxRunTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunTimeInSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>rw-xxx</para>
            /// </summary>
            [NameInMap("sourcePrometheusId")]
            [Validation(Required=false)]
            public string SourcePrometheusId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListAggTaskGroupsResponseBodyAggTaskGroupsTags> Tags { get; set; }
            public class ListAggTaskGroupsResponseBodyAggTaskGroupsTags : TeaModel {
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
            /// <b>Example:</b>
            /// <para>rw-xxx</para>
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
            /// <para>1757409499000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aa9d0e569b880xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BF1F4D6-B9A8-5F0B-8C1D-4347FFCB798E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
