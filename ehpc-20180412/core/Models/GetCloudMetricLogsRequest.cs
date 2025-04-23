// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsRequest : TeaModel {
        /// <summary>
        /// <para>The data aggregation interval. Unit: seconds.</para>
        /// <para>Valid values: 1, 10, 60, 600, and 3600.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregationInterval")]
        [Validation(Required=false)]
        public int? AggregationInterval { get; set; }

        /// <summary>
        /// <para>The data aggregation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sum: the sum of the data</description></item>
        /// <item><description>avg: the average value</description></item>
        /// <item><description>max: the maximum value</description></item>
        /// <item><description>min: the minimum value</description></item>
        /// </list>
        /// <para>Aggregation is disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg</para>
        /// </summary>
        [NameInMap("AggregationType")]
        [Validation(Required=false)]
        public string AggregationType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-jeJki6****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The filter conditions. A JSON-formatted string that contains several key-value pairs. Valid values of the key:</para>
        /// <list type="bullet">
        /// <item><description>InstanceId: the ID of the node</description></item>
        /// <item><description>Hostname: the hostname of the node</description></item>
        /// <item><description>NetworkInterface: the name of the network interface</description></item>
        /// <item><description>DiskDevice: the name of the disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Hostname&quot;:&quot;compute000&quot;}</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583907780</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>The category of the output performance metrics. Separate multiple metrics with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpu</description></item>
        /// <item><description>memory</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpu</para>
        /// </summary>
        [NameInMap("MetricCategories")]
        [Validation(Required=false)]
        public string MetricCategories { get; set; }

        /// <summary>
        /// <para>The dimensions of the performance metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>machine</description></item>
        /// <item><description>process</description></item>
        /// <item><description>network</description></item>
        /// <item><description>disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>network</para>
        /// </summary>
        [NameInMap("MetricScope")]
        [Validation(Required=false)]
        public string MetricScope { get; set; }

        /// <summary>
        /// <para>Specifies whether to return logs in reverse order of timestamps. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583907790</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
