// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListResultExportJobHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInput</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The queried result set export jobs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListResultExportJobHistoryResponseBodyItems> Items { get; set; }
        public class ListResultExportJobHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The RAM user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120010511678****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The time when the result set export job was created. The time follows the ISO 8601 standard in the <em>yyyy-mm-ddThh:mm:ssZ</em> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-01T09:50:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-7xv5ty5m9o4v****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The name of the database account that is associated with the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram_user</para>
            /// </summary>
            [NameInMap("DatabaseUser")]
            [Validation(Required=false)]
            public string DatabaseUser { get; set; }

            /// <summary>
            /// <para>The end time of the result set export job. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
            /// <remarks>
            /// <para> The end time must be later than the start time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-15T02:13:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The engine that is used to execute the result set export job. Only XIHE is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XIHE</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The unique identifier of the result set export job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export_2024051319271219802100800401300****</para>
            /// </summary>
            [NameInMap("ExportJobId")]
            [Validation(Required=false)]
            public string ExportJobId { get; set; }

            /// <summary>
            /// <para>The complete URL of the path to store the exported result set.</para>
            /// </summary>
            [NameInMap("ExportPath")]
            [Validation(Required=false)]
            public string ExportPath { get; set; }

            /// <summary>
            /// <para>The number of exported rows. This parameter is returned only when the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ExportRows")]
            [Validation(Required=false)]
            public string ExportRows { get; set; }

            /// <summary>
            /// <para>The type of the result set export job.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>Indicates whether the result set export job has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// <para>The returned message. This parameter is returned only when the request failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to execute SQL</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The query ID that can be used for diagnostics.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612495.html">DescribeDiagnosisSQLInfo</a> operation to query the execution information about a query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>202306121421111720161451770345339****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The progress of the result set export job. Unit: %. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The name of the resource group that runs the result set export job.</para>
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
            /// <para>The SQL statement that is used in the result set export job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM <c>ADB_SampleData_TPCH</c>.<c>supplier</c> LIMIT 20</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The start time of the result set export job. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-03T04:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the result set export job. Valid values:</para>
            /// <ol>
            /// <item><description><b>SUBMITTED</b></description></item>
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>SUCCEEDED</b></description></item>
            /// <item><description><b>FAILED</b></description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The amount of time consumed to export execution records. Unit: milliseconds.</para>
            /// <remarks>
            /// <para> The value is the duration between the time when the result set export job starts and the time when the result set export job ends.</para>
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
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, an <b>OK</b> message is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
