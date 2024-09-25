// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The result data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScheduleTasksResponseBodyData Data { get; set; }
        public class DescribeScheduleTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the scheduled task.</para>
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<DescribeScheduleTasksResponseBodyDataTimerInfos> TimerInfos { get; set; }
            public class DescribeScheduleTasksResponseBodyDataTimerInfos : TeaModel {
                /// <summary>
                /// <para>The type of the scheduled tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateDBNodes</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

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
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_cluster</para>
                /// </summary>
                [NameInMap("DbClusterDescription")]
                [Validation(Required=false)]
                public string DbClusterDescription { get; set; }

                /// <summary>
                /// <para>The state of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DbClusterStatus")]
                [Validation(Required=false)]
                public string DbClusterStatus { get; set; }

                /// <summary>
                /// <para>The ID of the order.</para>
                /// <remarks>
                /// <para> This parameter is returned only when you set the <c>Action</c> parameter to <b>CreateDBNodes</b> or <b>ModifyDBNodeClass</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>208161753******</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The latest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:30Z</para>
                /// </summary>
                [NameInMap("PlannedEndTime")]
                [Validation(Required=false)]
                public string PlannedEndTime { get; set; }

                [NameInMap("PlannedFlashingOffTime")]
                [Validation(Required=false)]
                public string PlannedFlashingOffTime { get; set; }

                /// <summary>
                /// <para>The earliest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:00Z</para>
                /// </summary>
                [NameInMap("PlannedStartTime")]
                [Validation(Required=false)]
                public string PlannedStartTime { get; set; }

                /// <summary>
                /// <para>The expected start time of the task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-28T12:16Z</para>
                /// </summary>
                [NameInMap("PlannedTime")]
                [Validation(Required=false)]
                public string PlannedTime { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the scheduled task runs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The state of the scheduled task.</para>
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
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TaskCancel")]
                [Validation(Required=false)]
                public bool? TaskCancel { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53879cdb-9a00-428e-acaf-ff4cff******</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
