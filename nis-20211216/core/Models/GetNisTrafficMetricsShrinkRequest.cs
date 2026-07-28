// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisTrafficMetricsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp, in milliseconds. If not specified, the most recent 1 hour is queried by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239092000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The network traffic direction based on Alibaba Cloud resources.</para>
        /// <para>In: traffic flowing into the target resource.
        /// Out: traffic flowing out of the target resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end timestamp, in milliseconds. If not specified, the most recent 1 hour is queried by default. If only BeginTime is specified, the 1 hour after BeginTime is queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373700099</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies additional filter conditions for the traffic to perform focused network traffic analysis.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>In VPC scenarios, this parameter specifies the paging size. In TR and Internet Shared Bandwidth scenarios, this parameter specifies the SQL query limit. If not specified, the backend defaults to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The metric name.
        /// Common parameters supported in network traffic analysis scenarios:
        ///   bps: bits per second.
        ///   pps: packets per second.
        /// Parameters specific to the Internet scenario:
        ///   rtt: round-trip time when establishing a TCP protocol connection.
        ///   RetransmitRate: retransmission rate.
        /// Parameters specific to the area-level bandwidth scenario:
        ///   RatelimitDropPps: rate of packet loss due to rate limiting.
        ///   BandwidthUtilization: bandwidth utilization.
        /// Parameters specific to the NAT scenario:
        ///   ActiveSessionCount: number of concurrent sessions.
        ///   NewSessionPerSecond: number of new sessions per second.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The token for the next query. You do not need to specify this parameter for the first query or when no more results exist. If a next page exists, set this parameter to the NextToken value returned by the previous API invoke. This parameter is valid only in VPC scenarios. TR and Internet Shared Bandwidth scenarios do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f7zUd3gArYj/xjPttJo5L5dK0R+gSbfHElLqi8C2IPWMQxtV8XckOg5lk7F2bhC+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:
        /// TimestampAscending: sorts by time in ascending order.
        /// TimestampDescending: sorts by time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimestampAscending</para>
        /// </summary>
        [NameInMap("ScanBy")]
        [Validation(Required=false)]
        public string ScanBy { get; set; }

        /// <summary>
        /// <para>The aggregation step for time series data, in minutes. The final query granularity is the larger value between StepMinutes and the underlying storage granularity. The number of data points calculated by (EndTime-BeginTime)/StepMinutes cannot exceed 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StepMinutes")]
        [Validation(Required=false)]
        public int? StepMinutes { get; set; }

        /// <summary>
        /// <para>The storage bucket precision property.</para>
        /// <para>The storage bucket precision specifies the storage aggregation epoch to query. Two precision levels are supported: high precision (such as 1 minute) or long epoch (such as 1 day). The specific precision is determined by the network traffic analysis sampling interval configured for high-precision traffic statistics or long-epoch traffic statistics when creating or editing the network traffic analysis analyzer.</para>
        /// <list type="bullet">
        /// <item><description><para>The storage precisions active for the corresponding tuples of the network traffic analysis analyzer are:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: in minutes (1 minute)</description></item>
        /// <item><description><c>10</c>: in minutes (10 minutes)</description></item>
        /// <item><description><c>60</c>: in minutes (60 minutes, i.e., 1 hour)</description></item>
        /// <item><description><c>1440</c>: in minutes (1440 minutes, i.e., 1 day)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The storage bucket precision can be used for two typical purposes:</para>
        /// <list type="bullet">
        /// <item><description>High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation</description></item>
        /// <item><description>Long-epoch traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specify a value for this field during the query to select the storage aggregation epoch. For example:</para>
        /// <list type="bullet">
        /// <item><description>Pass <c>10</c>: queries short-epoch data with a 10-minute aggregation granularity</description></item>
        /// <item><description>Pass <c>1440</c>: queries long-epoch data with a 1-day aggregation granularity</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StorageInterval")]
        [Validation(Required=false)]
        public int? StorageInterval { get; set; }

        /// <summary>
        /// <para>The ID of the network traffic analysis analyzer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nta-e093cb80c7c047afbd1d</para>
        /// </summary>
        [NameInMap("TrafficAnalyzerId")]
        [Validation(Required=false)]
        public string TrafficAnalyzerId { get; set; }

        /// <summary>
        /// <para>The supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC flow log analysis</description></item>
        /// <item><description>Internet VPC flow log analysis</description></item>
        /// <item><description>All TR flow log analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VpcFlowLogAll</para>
        /// </summary>
        [NameInMap("TrafficScenario")]
        [Validation(Required=false)]
        public string TrafficScenario { get; set; }

        /// <summary>
        /// <para>The traffic storage aggregation dimension.</para>
        /// <para>Based on the TrafficScenario:</para>
        /// <list type="bullet">
        /// <item><description><para>VpcFlowLogAll/VpcFlowLog: required. Specifies the storage aggregation view to query, which corresponds to the storage aggregation property configured in the network traffic analysis analyzer.</para>
        /// </description></item>
        /// <item><description><para>TRFlowLog/CbwpMetric: optional. Automatically adapts based on the storage aggregation property of the network traffic analysis analyzer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tuple2</para>
        /// </summary>
        [NameInMap("TupleDimension")]
        [Validation(Required=false)]
        public string TupleDimension { get; set; }

    }

}
