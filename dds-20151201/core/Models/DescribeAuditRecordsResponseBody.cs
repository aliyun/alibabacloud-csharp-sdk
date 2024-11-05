// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information of audit log entries.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditRecordsResponseBodyItems Items { get; set; }
        public class DescribeAuditRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLRecord")]
            [Validation(Required=false)]
            public List<DescribeAuditRecordsResponseBodyItemsSQLRecord> SQLRecord { get; set; }
            public class DescribeAuditRecordsResponseBodyItemsSQLRecord : TeaModel {
                /// <summary>
                /// <para>The account of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The time when the statement was executed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-11T03:30:27Z</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                /// <summary>
                /// <para>The IP addresses of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.xxx.xxx.xxx</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The number of SQL audit log entries that are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// <para>The statement that was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ \&quot;atype\&quot; : \&quot;createCollection\&quot;, \&quot;param\&quot; : { \&quot;ns\&quot; : \&quot;123.test1\&quot; }, \&quot;result\&quot;: \&quot;OK\&quot; }</para>
                /// </summary>
                [NameInMap("Syntax")]
                [Validation(Required=false)]
                public string Syntax { get; set; }

                /// <summary>
                /// <para>The name of the collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the thread.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140682188297984</para>
                /// </summary>
                [NameInMap("ThreadID")]
                [Validation(Required=false)]
                public string ThreadID { get; set; }

                /// <summary>
                /// <para>The duration of the statement execution. Unit: microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>700</para>
                /// </summary>
                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public long? TotalExecutionTimes { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries on the current page.</para>
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
        /// <para>3278BEB8-503B-4E46-8F7E-D26E040C9769</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
