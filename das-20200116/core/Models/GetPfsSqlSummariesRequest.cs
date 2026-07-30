// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSummariesRequest : TeaModel {
        /// <summary>
        /// <para>Sort in ascending order. Default is <b>false</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>End time of the query, in Unix timestamp format, in milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. You can query data for any seven-day period within the last 30 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1679297005999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Database instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf61swc4cru0b****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Keywords in the SQL text. Separate multiple keywords with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select update</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>Node ID.</para>
        /// <remarks>
        /// <para>Provide a node ID for RDS MySQL Cluster Edition or PolarDB for MySQL database instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>Field to sort by. Default is <b>count</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>count</b>: Number of executions.</para>
        /// </description></item>
        /// <item><description><para><b>avgLatency</b>: Average execution time.</para>
        /// </description></item>
        /// <item><description><para><b>rowsExamined</b>: Total number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>rowsExaminedAvg</b>: Average number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>rowsSentAvg</b>: Average number of returned rows.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Page number for paged queries. Start from 1. Default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Maximum number of records per page for paged queries. Default is 10. Maximum is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>SQL ID.</para>
        /// <remarks>
        /// <para>If you specify an SQL ID, the system returns statistics for that SQL ID only. If you leave this parameter empty, the system returns statistics for the entire database instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>651b56fe9418d48edb8fdf0980ec****</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>Start time of the query, in Unix timestamp format, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1675833788056</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
