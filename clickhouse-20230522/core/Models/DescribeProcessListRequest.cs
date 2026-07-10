// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeProcessListRequest : TeaModel {
        /// <summary>
        /// <para>The computing group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-gs5j3sua77******-clickhouse</para>
        /// </summary>
        [NameInMap("ComputingGroupId")]
        [Validation(Required=false)]
        public string ComputingGroupId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-xxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The query ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InitialQueryId")]
        [Validation(Required=false)]
        public string InitialQueryId { get; set; }

        /// <summary>
        /// <para>The query user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("InitialUser")]
        [Validation(Required=false)]
        public string InitialUser { get; set; }

        /// <summary>
        /// <para>The keyword in the query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

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
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The minimum query execution duration, in milliseconds (ms). Only queries that run for this duration or longer are returned. The minimum value is 1,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("QueryDurationMs")]
        [Validation(Required=false)]
        public string QueryDurationMs { get; set; }

        /// <summary>
        /// <para>The criteria by which to sort the results. The results are sorted in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Sorts by <c>query_duration_ms</c>.</para>
        /// </description></item>
        /// <item><description><para>1: Sorts by <c>query_duration_ms</c> and <c>query_start_time</c>.</para>
        /// </description></item>
        /// <item><description><para>2: Sorts by <c>query_duration_ms</c>, <c>query_start_time</c>, and <c>user</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QueryOrder")]
        [Validation(Required=false)]
        public long? QueryOrder { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
