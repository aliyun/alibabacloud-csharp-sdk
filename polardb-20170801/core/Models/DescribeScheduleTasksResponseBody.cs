// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScheduleTasksResponseBodyData Data { get; set; }
        public class DescribeScheduleTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Details of scheduled tasks.</para>
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<DescribeScheduleTasksResponseBodyDataTimerInfos> TimerInfos { get; set; }
            public class DescribeScheduleTasksResponseBodyDataTimerInfos : TeaModel {
                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateDBNodes</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The ID of the scheduled O\&amp;M task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86293c29-a03d-4872-b625-***********</para>
                /// </summary>
                [NameInMap("CrontabJobId")]
                [Validation(Required=false)]
                public string CrontabJobId { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The cluster description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_cluster</para>
                /// </summary>
                [NameInMap("DbClusterDescription")]
                [Validation(Required=false)]
                public string DbClusterDescription { get; set; }

                /// <summary>
                /// <para>The cluster status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DbClusterStatus")]
                [Validation(Required=false)]
                public string DbClusterStatus { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// <remarks>
                /// <para>This parameter is returned only if <c>Action</c> is <b>CreateDBNodes</b> or <b>ModifyDBNodeClass</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>208161753******</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The latest start time of the task. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:30Z</para>
                /// </summary>
                [NameInMap("PlannedEndTime")]
                [Validation(Required=false)]
                public string PlannedEndTime { get; set; }

                /// <summary>
                /// <para>The scheduled time for the transient switchover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:30Z</para>
                /// </summary>
                [NameInMap("PlannedFlashingOffTime")]
                [Validation(Required=false)]
                public string PlannedFlashingOffTime { get; set; }

                /// <summary>
                /// <para>The scheduled start time of the task. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:00Z</para>
                /// </summary>
                [NameInMap("PlannedStartTime")]
                [Validation(Required=false)]
                public string PlannedStartTime { get; set; }

                /// <summary>
                /// <para>The estimated start time of the task. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:16Z</para>
                /// </summary>
                [NameInMap("PlannedTime")]
                [Validation(Required=false)]
                public string PlannedTime { get; set; }

                /// <summary>
                /// <para>The region ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the scheduled task can be canceled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TaskCancel")]
                [Validation(Required=false)]
                public bool? TaskCancel { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53879cdb-9a00-428e-acaf-ff4cff******</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. Otherwise, an error message is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>936C7025-27A5-4CB1-BB31-540E1F0CCA12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
