// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Details about slow query logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowLog")]
            [Validation(Required=false)]
            public List<DescribeSlowLogsResponseBodyItemsSQLSlowLog> SQLSlowLog { get; set; }
            public class DescribeSlowLogsResponseBodyItemsSQLSlowLog : TeaModel {
                /// <summary>
                /// <para>The date when the data was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-30Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDB_MySQL</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-***************</para>
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// <para>The longest execution duration of a specific SQL statement in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                [NameInMap("MaxExecutionTimeMs")]
                [Validation(Required=false)]
                public string MaxExecutionTimeMs { get; set; }

                /// <summary>
                /// <para>The longest lock duration that was caused by a specific SQL statement in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were parsed by a specific SQL statement in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                /// <summary>
                /// <para>The total number of rows that were parsed by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were returned by a specific SQL statement in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                /// <summary>
                /// <para>The total number of rows that were returned by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                /// <summary>
                /// <para>The unique ID of the SQL statement. The ID is used to obtain the slow query logs of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U2FsdGVkxxxx</para>
                /// </summary>
                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                /// <summary>
                /// <para>The SQL statement that is executed in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select id,name from tb_table</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The total number of executions of the SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalExecutionCounts")]
                [Validation(Required=false)]
                public long? TotalExecutionCounts { get; set; }

                /// <summary>
                /// <para>The total duration that was caused by all SQL statements in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public long? TotalExecutionTimes { get; set; }

                /// <summary>
                /// <para>The total lock duration that was caused by all SQL statements in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of SQL statements that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2553A660-E4EB-4AF4-A402-8AFF70A49143</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
