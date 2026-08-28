// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTasksResponseBodyData Data { get; set; }
        public class DescribeSqlLogTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTasksResponseBodyDataList> List { get; set; }
            public class DescribeSqlLogTasksResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The analysis task completion time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1712751923000</para>
                /// </summary>
                [NameInMap("AnalysisTaskFinishTime")]
                [Validation(Required=false)]
                public long? AnalysisTaskFinishTime { get; set; }

                /// <summary>
                /// <para>The analysis task status.</para>
                /// <remarks>
                /// <para>This is an internal system parameter. You do not need to pay attention to it.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SCAN_ANALYZE_COMPLETED</para>
                /// </summary>
                [NameInMap("AnalysisTaskStatus")]
                [Validation(Required=false)]
                public string AnalysisTaskStatus { get; set; }

                /// <summary>
                /// <para>The task creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1681363254423</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The task end time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1705975320000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <para>Indicates whether the task has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The task has expired.</description></item>
                /// <item><description><b>false</b>: The task has not expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expire")]
                [Validation(Required=false)]
                public bool? Expire { get; set; }

                /// <summary>
                /// <para>The list of query filter conditions.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<DescribeSqlLogTasksResponseBodyDataListFilters> Filters { get; set; }
                public class DescribeSqlLogTasksResponseBodyDataListFilters : TeaModel {
                    /// <summary>
                    /// <para>The filter parameter.</para>
                    /// <remarks>
                    /// <para>For supported filter parameters and their values, refer to <b>Supplementary description of request parameters</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>keyWords</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the filter parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The VPC internal endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://das-sqllog-download-oss-cn-shanghai-internal.aliyuncs.com">https://das-sqllog-download-oss-cn-shanghai-internal.aliyuncs.com</a>
                /// /la</para>
                /// </summary>
                [NameInMap("InnerResult")]
                [Validation(Required=false)]
                public string InnerResult { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1nti25tc7bq5****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The total number of logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99999</para>
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL audit export 1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The task progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The link address when the task type is <b>Export</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://das-sqllog-download-cn-shanghai.oss-cn-shanghai.aliyuncs.com/la">https://das-sqllog-download-cn-shanghai.oss-cn-shanghai.aliyuncs.com/la</a></para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The number of scanned files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("ScanFileSize")]
                [Validation(Required=false)]
                public long? ScanFileSize { get; set; }

                /// <summary>
                /// <para>The task start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683859555482</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INIT</b>: Pending scheduling.</description></item>
                /// <item><description><b>RUNNING</b>: Running.</description></item>
                /// <item><description><b>FAILED</b>: Failed.</description></item>
                /// <item><description><b>CANCELED</b>: Canceled.</description></item>
                /// <item><description><b>COMPLETED</b>: Completed.</description></item>
                /// </list>
                /// <remarks>
                /// <para>When the task is in the <b>COMPLETED</b> state, you can view the results of the batch task.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9a4f5c4494dbd6713185d87a97aa53e8</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Export</b>: export task.</description></item>
                /// <item><description><b>Query</b>: query task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Export</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned.</para>
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
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
