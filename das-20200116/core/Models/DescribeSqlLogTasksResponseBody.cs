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
            /// <para>The list of tasks.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTasksResponseBodyDataList> List { get; set; }
            public class DescribeSqlLogTasksResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The analysis completion time, represented as a unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1712751923000</para>
                /// </summary>
                [NameInMap("AnalysisTaskFinishTime")]
                [Validation(Required=false)]
                public long? AnalysisTaskFinishTime { get; set; }

                /// <summary>
                /// <para>The status of the analysis task.</para>
                /// <remarks>
                /// <para>This is an internal parameter. You can ignore it.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SCAN_ANALYZE_COMPLETED</para>
                /// </summary>
                [NameInMap("AnalysisTaskStatus")]
                [Validation(Required=false)]
                public string AnalysisTaskStatus { get; set; }

                /// <summary>
                /// <para>The task creation time, represented as a unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1681363254423</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The task end time, represented as a unix timestamp in milliseconds.</para>
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
                /// <item><description><para><b>true</b>: The task has expired.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The task has not expired.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expire")]
                [Validation(Required=false)]
                public bool? Expire { get; set; }

                /// <summary>
                /// <para>A list of filter conditions.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<DescribeSqlLogTasksResponseBodyDataListFilters> Filters { get; set; }
                public class DescribeSqlLogTasksResponseBodyDataListFilters : TeaModel {
                    /// <summary>
                    /// <para>The filter parameter.</para>
                    /// <remarks>
                    /// <para>For information about the supported filter parameters and their valid values, see <b>Additional information about request parameters</b>.</para>
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
                /// <para>The VPC-internal URL for accessing the task result.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://das-sqllog-download-oss-cn-shanghai-internal.aliyuncs.com">https://das-sqllog-download-oss-cn-shanghai-internal.aliyuncs.com</a>
                /// /la</para>
                /// </summary>
                [NameInMap("InnerResult")]
                [Validation(Required=false)]
                public string InnerResult { get; set; }

                /// <summary>
                /// <para>The ID of the database instance.</para>
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
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL audit export 1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The progress of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The URL that is returned when <b>TaskType</b> is set to <b>Export</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://das-sqllog-download-cn-shanghai.oss-cn-shanghai.aliyuncs.com/la">https://das-sqllog-download-cn-shanghai.oss-cn-shanghai.aliyuncs.com/la</a></para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The total size of the scanned files, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("ScanFileSize")]
                [Validation(Required=false)]
                public long? ScanFileSize { get; set; }

                /// <summary>
                /// <para>The task start time, represented as a unix timestamp in milliseconds.</para>
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
                /// <item><description><para><b>INIT</b>: pending scheduling.</para>
                /// </description></item>
                /// <item><description><para><b>RUNNING</b>: running.</para>
                /// </description></item>
                /// <item><description><para><b>FAILED</b>: failed.</para>
                /// </description></item>
                /// <item><description><para><b>CANCELED</b>: canceled.</para>
                /// </description></item>
                /// <item><description><para><b>COMPLETED</b>: completed.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>You can view the result of an offline task only when its status is <b>COMPLETED</b>.</para>
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
                /// <item><description><para><b>Export</b>: an export task.</para>
                /// </description></item>
                /// <item><description><para><b>Query</b>: a query task.</para>
                /// </description></item>
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
            /// <para>The page size.</para>
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
        /// <para>The response message.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
