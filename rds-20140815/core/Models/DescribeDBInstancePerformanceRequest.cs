// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The interval between the start time and end time must be greater than the monitoring frequency of your instance. Otherwise, an empty list may be returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-18T15:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics that you want to query. Separate multiple values with commas (,). You can specify up to 30 metrics. For more information, see <a href="https://help.aliyun.com/document_detail/26316.html">Performance parameters</a>.</para>
        /// <remarks>
        /// <para>If <b>Key</b> is set to <b>MySQL_SpaceUsage</b> or <b>SQLServer_SpaceUsage</b>, only monitoring data within the last day can be queried.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_NetworkTraffic</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The unique identifier of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>339****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The interval between the start time and end time must be greater than the monitoring frequency of your instance. Otherwise, an empty list may be returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-08T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
