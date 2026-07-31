// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of an enterprise edition, basic edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of a Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~~612397~~~">DescribeDBClusters</a> operation to query the IDs of all clusters in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1hx5n1o8f61****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range. The time is in UTC and must be in the <em>yyyy-MM-ddTHH:mmZ</em> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The time range cannot exceed two days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-11T15:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The key of the performance metric. Separate multiple keys with commas (,). For a list of supported metrics, see <a href="https://help.aliyun.com/document_detail/2863211.html">metric overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AnalyticDB_CPU_Usage_Percentage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612393.html">DescribeRegions</a> operation to query the regions and availability zones supported by AnalyticDB for MySQL, including the region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the resource pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// <para>The start of the time range. The time is in UTC and must be in the <em>yyyy-MM-ddTHH:mmZ</em> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-10T23:56Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
