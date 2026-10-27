// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of result items.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTasksResponseBodyItems> Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The start time of the task. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-20T19:40:00Z</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The name of the database associated with the task. This field is usually empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DBName</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The end time of the task. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-20T20:00:00Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The task progress, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The detailed progress of the task. This field is usually empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ProgressInfo</para>
            /// </summary>
            [NameInMap("ProgressInfo")]
            [Validation(Required=false)]
            public string ProgressInfo { get; set; }

            /// <summary>
            /// <para>The scale-out token. If the task is a scale-out task, this field returns a scale-out ID, which is a unique backend key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
            /// </summary>
            [NameInMap("ScaleOutToken")]
            [Validation(Required=false)]
            public string ScaleOutToken { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: The task is running.</description></item>
            /// <item><description><b>FAILED</b>: The task failed and was interrupted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task action. This is a unique key for the backend task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>multi_scale_out</para>
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// <para>The error code of the failed task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskErrorCode</para>
            /// </summary>
            [NameInMap("TaskErrorCode")]
            [Validation(Required=false)]
            public string TaskErrorCode { get; set; }

            /// <summary>
            /// <para>The error message of the failed task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskErrorMessage</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20089398</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

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
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6045D78-C119-5A17-9DEA-0F810394E008</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
