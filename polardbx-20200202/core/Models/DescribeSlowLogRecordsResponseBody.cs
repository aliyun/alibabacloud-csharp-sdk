// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of slow log details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSlowLogRecordsResponseBodyItems> Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The compute node name. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-i-xxxx</para>
            /// </summary>
            [NameInMap("CNname")]
            [Validation(Required=false)]
            public string CNname { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdev</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The extension field. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tddl:5.4.19-20240927</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution failed. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public string Fail { get; set; }

            /// <summary>
            /// <para>The number of rows fetched. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Frows")]
            [Validation(Required=false)]
            public string Frows { get; set; }

            /// <summary>
            /// <para>The name and address of the client that connects to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>[</b></b>] @ [1XX.XX.XX.XX]</para>
            /// </summary>
            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            /// <summary>
            /// <para>The instance name. This field is available only for DN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-xdb-s-xxxx</para>
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// <para>Indicates whether the Prepare mode is used. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public string IsBind { get; set; }

            /// <summary>
            /// <para>The lock duration. Unit: milliseconds (ms). This field is available only for DN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockTimeMS")]
            [Validation(Required=false)]
            public string LockTimeMS { get; set; }

            /// <summary>
            /// <para>The parameters in Prepare mode. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1&quot;]</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// <para>The number of rows scanned. This field is available only for DN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ParseRowCounts")]
            [Validation(Required=false)]
            public string ParseRowCounts { get; set; }

            /// <summary>
            /// <para>The timestamp in the YYYY-MM-ddTHH:mm.ss.SSSZ format (UTC).</para>
            /// <list type="bullet">
            /// <item><description>In CN slow logs, this field indicates the execution start time.</description></item>
            /// <item><description>In DN slow logs, this field indicates the execution end time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-22T02:22:22.444Z</para>
            /// </summary>
            [NameInMap("QueryStartTime")]
            [Validation(Required=false)]
            public string QueryStartTime { get; set; }

            /// <summary>
            /// <para>The execution duration of the SQL statement. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.000</para>
            /// </summary>
            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

            /// <summary>
            /// <para>The execution duration of the SQL statement. Unit: milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000.000</para>
            /// </summary>
            [NameInMap("QueryTimeMS")]
            [Validation(Required=false)]
            public string QueryTimeMS { get; set; }

            /// <summary>
            /// <para>The number of rows returned. This field is available only for DN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public string ReturnRowCounts { get; set; }

            /// <summary>
            /// <para>The number of rows affected or returned. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>The number of physical SQL statements. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SCNT")]
            [Validation(Required=false)]
            public string SCNT { get; set; }

            /// <summary>
            /// <para>The unique identifier of the SQL statement in slow query log statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8df07e5d45cd68da8b4771c2016e20b</para>
            /// </summary>
            [NameInMap("SQLHash")]
            [Validation(Required=false)]
            public string SQLHash { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from test</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The SQL type. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The kernel template ID. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>af33ffee</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement is too long. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TooLong")]
            [Validation(Required=false)]
            public string TooLong { get; set; }

            /// <summary>
            /// <para>The trace ID. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17a5c5c840006000</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <para>The transaction policy. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XA</para>
            /// </summary>
            [NameInMap("TransactionPolicy")]
            [Validation(Required=false)]
            public string TransactionPolicy { get; set; }

            /// <summary>
            /// <para>The transaction ID. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17a5c5c840006000</para>
            /// </summary>
            [NameInMap("TrxId")]
            [Validation(Required=false)]
            public string TrxId { get; set; }

            /// <summary>
            /// <para>The workload type. This field is available only for CN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TP</para>
            /// </summary>
            [NameInMap("WT")]
            [Validation(Required=false)]
            public string WT { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
