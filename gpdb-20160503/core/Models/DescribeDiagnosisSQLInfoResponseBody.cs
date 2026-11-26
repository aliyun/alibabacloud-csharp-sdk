// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbtest</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The total execution duration of the query, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The maximum number of output rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxOutputRows")]
        [Validation(Required=false)]
        public string MaxOutputRows { get; set; }

        /// <summary>
        /// <para>The query ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71403480878****</para>
        /// </summary>
        [NameInMap("QueryID")]
        [Validation(Required=false)]
        public string QueryID { get; set; }

        /// <summary>
        /// <para>The operator information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;children&quot;:********&quot;startTime&quot;:1660719602199}</para>
        /// </summary>
        [NameInMap("QueryPlan")]
        [Validation(Required=false)]
        public string QueryPlan { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425AAA6A-63E0-1929-A1CE-3D9036CBC463</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select n_live_tup, n_live_tup + n_dead_tup, pg_relation_size(table_name), last_vacuum from pg_stat_user_tables where relid = table_name::regclass</para>
        /// </summary>
        [NameInMap("SQLStmt")]
        [Validation(Required=false)]
        public string SQLStmt { get; set; }

        /// <summary>
        /// <para>The ID of the session to which the query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>658****</para>
        /// </summary>
        [NameInMap("SessionID")]
        [Validation(Required=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// <para>The sorting structure based on metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;costSort&quot;:******:&quot;Seq Scan-9&quot;,&quot;value&quot;:0.0}]}</para>
        /// </summary>
        [NameInMap("SortedMetrics")]
        [Validation(Required=false)]
        public string SortedMetrics { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660719602199</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b>: The SQL statement is being executed.</description></item>
        /// <item><description><b>finished</b>: The execution of the SQL statement is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The query plan information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Seq Scan on example_table</para>
        /// </summary>
        [NameInMap("TextPlan")]
        [Validation(Required=false)]
        public string TextPlan { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpguser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
