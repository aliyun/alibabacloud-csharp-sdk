// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBNodePerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the node in the PolarDB cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-*************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The granularity of the performance data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>5</para>
        /// </description></item>
        /// <item><description><para>30</para>
        /// </description></item>
        /// <item><description><para>60</para>
        /// </description></item>
        /// <item><description><para>600</para>
        /// </description></item>
        /// <item><description><para>1800</para>
        /// </description></item>
        /// <item><description><para>3600</para>
        /// </description></item>
        /// <item><description><para>86400</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics to query. Separate multiple metrics with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/141787.html">Performance metrics</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can query a maximum of five performance metrics.</para>
        /// </description></item>
        /// <item><description><para>If your cluster has Serverless enabled for fixed specifications, querying PolarDBCPU or PolarDBMemory alone ignores the Interval parameter and returns performance metrics per second. To get data at your specified Interval, query multiple metrics.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBDiskUsage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in Coordinated Universal Time (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>A special metric. Currently, only orca is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orca</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
