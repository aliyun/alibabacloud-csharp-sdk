// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort results in ascending order. Default value: <b>true</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: ascending order.</description></item>
        /// <item><description><b>false</b>: descending order.</description></item>
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
        /// <item><description><b>MySQL</b> <list type="bullet">
        /// <item><description>QueryTimeSeconds: query duration in seconds.</description></item>
        /// <item><description>LockTimeSeconds: lock time in seconds.</description></item>
        /// <item><description>RowsSent: rows sent.</description></item>
        /// <item><description>RowsExamined: rows examined.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Redis</b><list type="bullet">
        /// <item><description>QueryTime: query duration.</description></item>
        /// <item><description>Timestamp: execution end time.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>MongoDB</b><list type="bullet">
        /// <item><description>QueryTime: query duration.</description></item>
        /// <item><description>Timestamp: execution end time.</description></item>
        /// <item><description>KeysExamined: keys examined.</description></item>
        /// <item><description>DocExamined: documents examined.</description></item>
        /// <item><description>ReturnNum: rows returned.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><notice>RDS PostgreSQL, PolarDB for PostgreSQL, and SQL Server do not support sorting.</notice></para>
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
