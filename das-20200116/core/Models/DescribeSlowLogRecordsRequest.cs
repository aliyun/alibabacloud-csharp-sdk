// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. The default value is <b>true</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sorts the results in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Sorts the results in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value must be a UNIX timestamp in milliseconds.</para>
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
            /// <para>The filter key.</para>
            /// <remarks>
            /// <para>For details, refer to the supplementary information.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value for the filter key.</para>
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
        /// <item><description><para><b>MySQL</b></para>
        /// <list type="bullet">
        /// <item><description><para>QueryTimeSeconds: the query execution time in seconds.</para>
        /// </description></item>
        /// <item><description><para>LockTimeSeconds: the lock duration in seconds.</para>
        /// </description></item>
        /// <item><description><para>RowsSent: the number of rows sent.</para>
        /// </description></item>
        /// <item><description><para>RowsExamined: the number of rows examined.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// <list type="bullet">
        /// <item><description><para>QueryTime: the query execution time.</para>
        /// </description></item>
        /// <item><description><para>Timestamp: the end time of the query execution.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// <list type="bullet">
        /// <item><description><para>QueryTime: the query execution time.</para>
        /// </description></item>
        /// <item><description><para>Timestamp: the end time of the query execution.</para>
        /// </description></item>
        /// <item><description><para>KeysExamined: the number of keys examined.</para>
        /// </description></item>
        /// <item><description><para>DocExamined: the number of documents scanned.</para>
        /// </description></item>
        /// <item><description><para>ReturnNum: the number of rows returned.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>RDS for PostgreSQL, PolarDB for PostgreSQL, and SQL Server do not support sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QueryTimeSeconds</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Page numbering starts at 1.</para>
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
        /// <para>The start of the time range to query. The value must be a UNIX timestamp in milliseconds.</para>
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
