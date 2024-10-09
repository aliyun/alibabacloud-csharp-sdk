// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine that the instance runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 30 to 100.</para>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The number of logical reads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PhysicalIORead")]
        [Validation(Required=false)]
        public long? PhysicalIORead { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The slow query logs returned.</para>
        /// </summary>
        [NameInMap("SlowLogs")]
        [Validation(Required=false)]
        public List<DescribeDatabaseSlowLogRecordsResponseBodySlowLogs> SlowLogs { get; set; }
        public class DescribeDatabaseSlowLogRecordsResponseBodySlowLogs : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDB</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The time when the execution of the SQL statement started. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// <remarks>
            /// <para> The time displayed in the Simple Application Server console is in the format of UTC+8.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T01:40:44Z</para>
            /// </summary>
            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            /// <summary>
            /// <para>The name and IP address of the client that is connected to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx[xxx] @ [1xx.xxx.xxx.xx]</para>
            /// </summary>
            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            /// <summary>
            /// <para>The lock duration of the SQL statement. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LockTimes")]
            [Validation(Required=false)]
            public long? LockTimes { get; set; }

            /// <summary>
            /// <para>The number of rows parsed by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParseRowCounts")]
            [Validation(Required=false)]
            public long? ParseRowCounts { get; set; }

            /// <summary>
            /// <para>The execution duration of the slow query. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("QueryTimeMS")]
            [Validation(Required=false)]
            public long? QueryTimeMS { get; set; }

            /// <summary>
            /// <para>The execution duration of the slow query. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("QueryTimes")]
            [Validation(Required=false)]
            public long? QueryTimes { get; set; }

            /// <summary>
            /// <para>The number of rows returned by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            /// <summary>
            /// <para>The details of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select sleep(2)</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
