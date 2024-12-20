// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried SQL execution logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogsResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The database account that executes the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testadmin</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpgadmin</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The role of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("DBRole")]
            [Validation(Required=false)]
            public string DBRole { get; set; }

            /// <summary>
            /// <para>The execution duration of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExecuteCost")]
            [Validation(Required=false)]
            public float? ExecuteCost { get; set; }

            /// <summary>
            /// <para>The execution status of the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>fail</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ExecuteState")]
            [Validation(Required=false)]
            public string ExecuteState { get; set; }

            /// <summary>
            /// <para>The type of the query language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DQL</para>
            /// </summary>
            [NameInMap("OperationClass")]
            [Validation(Required=false)]
            public string OperationClass { get; set; }

            /// <summary>
            /// <para>The time when the SQL statement was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15T17:02:32Z</para>
            /// </summary>
            [NameInMap("OperationExecuteTime")]
            [Validation(Required=false)]
            public string OperationExecuteTime { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            /// <summary>
            /// <para>The SQL execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("SQLPlan")]
            [Validation(Required=false)]
            public string SQLPlan { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select 1</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The number of entries scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanRowCounts")]
            [Validation(Required=false)]
            public long? ScanRowCounts { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.<b>.</b>.90</para>
            /// </summary>
            [NameInMap("SourceIP")]
            [Validation(Required=false)]
            public string SourceIP { get; set; }

            /// <summary>
            /// <para>The number of the source port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50514</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public int? SourcePort { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7941C94-B92F-46A0-BD3E-2D**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
