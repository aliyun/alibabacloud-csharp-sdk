// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListActionPlanActivitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of execution details of the execution plan.</para>
        /// </summary>
        [NameInMap("ActionPlanActivities")]
        [Validation(Required=false)]
        public List<ListActionPlanActivitiesResponseBodyActionPlanActivities> ActionPlanActivities { get; set; }
        public class ListActionPlanActivitiesResponseBodyActionPlanActivities : TeaModel {
            /// <summary>
            /// <para>The activity ID of the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>et-4119e3f60eb34fc4</para>
            /// </summary>
            [NameInMap("ActionPlanActivityId")]
            [Validation(Required=false)]
            public string ActionPlanActivityId { get; set; }

            /// <summary>
            /// <para>The increased capacity of this execution plan activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public float? CreatedCapacity { get; set; }

            /// <summary>
            /// <para>The capacity released by this execution plan activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DestroyCapacity")]
            [Validation(Required=false)]
            public float? DestroyCapacity { get; set; }

            /// <summary>
            /// <para>The end time of the execution plan activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10 18:28:05</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The list of Instant jobs involved in the execution plan.</para>
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListActionPlanActivitiesResponseBodyActionPlanActivitiesJobs> Jobs { get; set; }
            public class ListActionPlanActivitiesResponseBodyActionPlanActivitiesJobs : TeaModel {
                /// <summary>
                /// <para>The ID of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-hz12dqq8y3ormo1hz49h</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The operation type of the execution plan activity on the job. Possible values are as follows:</para>
                /// <list type="bullet">
                /// <item><description>Create</description></item>
                /// <item><description>Delete</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("JobOperationType")]
                [Validation(Required=false)]
                public string JobOperationType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The start time of the implementation of the planned activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10 18:28:05</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The implementation status of the execution plan activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InProcess</description></item>
            /// <item><description>Completed</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProcess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the read position returned by the current call. An empty value means all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86scXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total data count under the current request conditions (optional; not returned by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
