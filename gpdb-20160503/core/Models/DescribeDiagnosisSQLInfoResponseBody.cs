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
        /// <para>The execution duration of the query. Unit: seconds.</para>
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
        /// <para>The information about the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;children\&quot;:********\&quot;startTime\&quot;:1660719602199}</para>
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
        /// <para>The ID of the session that contains the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>658****</para>
        /// </summary>
        [NameInMap("SessionID")]
        [Validation(Required=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// <para>The sequence of metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;costSort\&quot;:******:\&quot;Seq Scan-9\&quot;,\&quot;value\&quot;:0.0}]}</para>
        /// </summary>
        [NameInMap("SortedMetrics")]
        [Validation(Required=false)]
        public string SortedMetrics { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660719602199</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The execution state of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>finished</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
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
