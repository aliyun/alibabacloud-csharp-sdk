// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the cluster in Enterprise Edition, Basic Edition, or Data Lakehouse Edition.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~~612397~~~">DescribeDBClusters</a> operation to query the IDs of all clusters in a specified region.</para>
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
        /// <para>The end time of the query. Specify the time in UTC in the format of <i>yyyy-MM-ddTHH:mmZ</i>.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the interval between the start time and end time cannot exceed two days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-11T15:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the performance metric (metric key) to query. Separate multiple values with commas (,). For more information about supported metrics, see <a href="https://help.aliyun.com/document_detail/2863211.html">Monitoring metrics overview</a>.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612393.html">DescribeRegions</a> operation to query the regions and zones supported by AnalyticDB for MySQL, including region IDs.</para>
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
        /// <para>The resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in UTC in the format of <i>yyyy-MM-ddTHH:mmZ</i>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-10T23:56Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
