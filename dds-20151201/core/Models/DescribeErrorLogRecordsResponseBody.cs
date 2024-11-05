// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeErrorLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Details about the log entries returned.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeErrorLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeErrorLogRecordsResponseBodyItemsLogRecords : TeaModel {
                /// <summary>
                /// <para>The category of the log entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NETWORK: network connection log</description></item>
                /// <item><description>ACCESS: access control log</description></item>
                /// <item><description>\-: general log</description></item>
                /// <item><description>COMMAND: slow query log</description></item>
                /// <item><description>SHARDING: sharded cluster log</description></item>
                /// <item><description>STORAGE: storage engine log</description></item>
                /// <item><description>CONNPOOL: connection pool log</description></item>
                /// <item><description>ASIO: asynchronous I/O operation log</description></item>
                /// <item><description>WRITE: slow update log</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NETWORK</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The connection information of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conn18xxxxxx</para>
                /// </summary>
                [NameInMap("ConnInfo")]
                [Validation(Required=false)]
                public string ConnInfo { get; set; }

                /// <summary>
                /// <para>The content of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the log entry was generated. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T12:09:34Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111111111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BCBEC2-1E66-471F-A1A8-E3C60C0A80B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
