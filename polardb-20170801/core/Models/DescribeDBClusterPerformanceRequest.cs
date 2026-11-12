// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB cluster. Before you query performance data, the cluster must be in the Running state. You can call the DescribeDBClusters operation and check the DBClusterStatus parameter to confirm the cluster status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data granularity of the performance data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5</description></item>
        /// <item><description>30</description></item>
        /// <item><description>60</description></item>
        /// <item><description>600</description></item>
        /// <item><description>1800</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics to query. Separate multiple values with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/141787.html">Performance metrics</a>.</para>
        /// <remarks>
        /// <para>You can specify up to 5 performance metrics.</para>
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
        /// <para>The start time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the subgroup for the performance metrics. Specify this parameter only when the queried metrics contain a subgroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-name</para>
        /// </summary>
        [NameInMap("SubGroupName")]
        [Validation(Required=false)]
        public string SubGroupName { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orca</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
