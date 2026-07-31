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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all clusters in a region, including their cluster IDs.</para>
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
        /// <para>The end of the time range to query. Specify the time in UTC in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/321868.html">DescribeSQLPatterns</a> operation to query information about all SQL patterns in a cluster within a specified time range, including the ID of each SQL pattern.</para>
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
        /// <para>The beginning of the time range to query. Specify the time in UTC in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query data from the last 14 days. If you specify a start time earlier than this period, an empty value is returned. For example, if the current date is August 22, 2022 (China Standard Time), the earliest valid start time is 2022-08-08T16:00:00Z.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The interval between the start time and the end time cannot exceed 24 hours.</description></item>
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
