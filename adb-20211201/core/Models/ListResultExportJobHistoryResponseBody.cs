// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListResultExportJobHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation status code or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInput</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned. A status code of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListResultExportJobHistoryResponseBodyItems> Items { get; set; }
        public class ListResultExportJobHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the Resource Access Management (RAM) user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120010511678****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The time when the result set export task was created. Specify the time in the <i>yyyy-mm-ddThh:mm:ssZ</i> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-01T09:50:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (3.0) cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-7xv5ty5m9o4v****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The name of the database account associated with the Resource Access Management (RAM) user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram_user</para>
            /// </summary>
            [NameInMap("DatabaseUser")]
            [Validation(Required=false)]
            public string DatabaseUser { get; set; }

            /// <summary>
            /// <para>The end time of the query. Specify the time in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format. The time must be in UTC.</para>
            /// <remarks>
            /// <para>The end time must be later than the start time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-15T02:13:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The engine used to execute the task. Only XIHE is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XIHE</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The unique identifier of the result set export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export_2024051319271219802100800401300****</para>
            /// </summary>
            [NameInMap("ExportJobId")]
            [Validation(Required=false)]
            public string ExportJobId { get; set; }

            /// <summary>
            /// <para>The complete address of the result set.</para>
            /// </summary>
            [NameInMap("ExportPath")]
            [Validation(Required=false)]
            public string ExportPath { get; set; }

            /// <summary>
            /// <para>The number of exported rows. This parameter is returned only when the operation call is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ExportRows")]
            [Validation(Required=false)]
            public string ExportRows { get; set; }

            /// <summary>
            /// <para>The export type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>Indicates whether the task has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: The task has not expired.</description></item>
            /// <item><description><b>true</b>: The task has expired.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// <para>The error message of the SQL execution for the result set export. This message is returned only when the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to execute SQL</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The SQL query ID returned for diagnostics.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612495.html">DescribeDiagnosisSQLInfo</a> operation to diagnose the query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>202306121421111720161451770345339****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The export progress. Unit: percentage (%). Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The resource group in which the task is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lake_db</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The details of the SQL statement used in the result set export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM <c>ADB_SampleData_TPCH</c>.<c>supplier</c> LIMIT 20</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The start time of the task. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-03T04:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the export task. Valid values:</para>
            /// <ol>
            /// <item><description><b>SUBMITTED</b>: The task is submitted.</description></item>
            /// <item><description><b>RUNNING</b>: The task is running.</description></item>
            /// <item><description><b>SUCCEEDED</b>: The task succeeded.</description></item>
            /// <item><description><b>FAILED</b>: The task failed.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time consumed for data export, in milliseconds.</para>
            /// <remarks>
            /// <para>The time is calculated from the start of the data export task to the end of the export.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>560</para>
            /// </summary>
            [NameInMap("TimeCost")]
            [Validation(Required=false)]
            public long? TimeCost { get; set; }

        }

        /// <summary>
        /// <para>The additional information about the call result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ok</b>: The request is normal.                                </description></item>
        /// <item><description>Specific error code: An exception occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number, which is the same as the value passed in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
