// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePatternPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all clusters in the specified region, including the cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6li1r3do8m****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the <i>yyyy-MM-ddTHH:mmZ</i> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-22T01:06:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the SQL pattern.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/321868.html">DescribeSQLPatterns</a> operation to query the list of all SQL patterns in the specified cluster within a specified time period, including the SQL pattern IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3847585356974******</para>
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in UTC and follows the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the current date is August 22, 2022 (UTC+8), the earliest data you can query is from August 9, 2022 (UTC+8), which corresponds to 2022-08-08T16:00:00Z in UTC. If the specified start time is earlier than August 9, 2022 (UTC+8) or 2022-08-08T16:00:00Z in UTC, an empty response is returned.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The interval between the start time and the end time of the query cannot exceed 24 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-21T02:15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
