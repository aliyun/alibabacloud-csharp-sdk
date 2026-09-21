// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. Default value: <b>true</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sort in ascending order.</description></item>
        /// <item><description><b>false</b>: Sort in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634972640000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSlowLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeSlowLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter.</para>
            /// <remarks>
            /// <para>For more information, refer to the supplementary description.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-8vbk4xz99su8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-d9j9fe7wq7t9i****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para><b>Common to all engines</b> </para>
        /// <list type="bullet">
        /// <item><description>QueryTimeSeconds: query duration (seconds).</description></item>
        /// <item><description>Timestamp: timestamp.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SQL-based engines (MySQL / PolarDB for MySQL / PostgreSQL / PolarDB for PostgreSQL / PolarDB for Oracle / PolarDB-X DN)</b></para>
        /// <list type="bullet">
        /// <item><description>LockTimeSeconds: lock time (seconds).</description></item>
        /// <item><description>RowsExamined: rows examined.</description></item>
        /// <item><description>RowsSent: rows returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// <list type="bullet">
        /// <item><description>KeysExamined: number of indexes scanned.</description></item>
        /// <item><description>DocExamined: number of documents scanned.</description></item>
        /// <item><description>ReturnNum: rows returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SQL Server</b></para>
        /// <list type="bullet">
        /// <item><description>CPUTimeSeconds: CPU time.</description></item>
        /// <item><description>IOWrites: number of I/O writes.</description></item>
        /// <item><description>LastRowsCountAffected: last rows affected.</description></item>
        /// <item><description>LogicalIOReads: logical I/O reads.</description></item>
        /// <item><description>PhysicalIOReads: physical I/O reads.</description></item>
        /// <item><description>RowsCountAffected: rows affected.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>PolarDB-X CN</b></para>
        /// <list type="bullet">
        /// <item><description>RowsSent: rows returned or updated.</description></item>
        /// <item><description>Frows: rows fetched.</description></item>
        /// <item><description>Scnt: number of physical SQL statements.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>QueryTimeSeconds</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
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
        /// <para>The start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
