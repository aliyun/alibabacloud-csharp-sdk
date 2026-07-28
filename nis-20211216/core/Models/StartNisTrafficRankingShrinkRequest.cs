// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class StartNisTrafficRankingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp of the query, in milliseconds.</para>
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
        /// <para>In: Traffic flowing into the target resource.
        /// Out: Traffic flowing out of the target resource.</para>
        /// <list type="bullet">
        /// <item><description><para>VPC flow log scenario (<c>TraffficScenario = VpcFlowLogAll</c> / <c>VpcFlowLogInternet</c>):</para>
        /// <list type="bullet">
        /// <item><description>In: Traffic flowing into the ENI.</description></item>
        /// <item><description>Out: Traffic flowing out of the ENI.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>TR flow log scenario (<c>TraffficScenario = TRFlowlog</c>):</para>
        /// <list type="bullet">
        /// <item><description>In: Traffic flowing into the TR.</description></item>
        /// <item><description>Out: Traffic flowing out of the TR.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Internet Shared Bandwidth metric analysis scenario (<c>TraffficScenario = CbwpMetric</c>):</para>
        /// <list type="bullet">
        /// <item><description>In: Traffic flowing into the EIP.</description></item>
        /// <item><description>Out: Traffic flowing out of the EIP.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373700099</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies additional filter conditions for focused network traffic analysis.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>Specifies multiple traffic dimensions for aggregation and sorting.</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupByShrink { get; set; }

        /// <summary>
        /// <para>The language. Valid values: zh-CN, en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or when no more results are available. If a next query exists, set this value to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Based on the <c>TrafficScenario</c> field, the following metrics are supported for ranking traffic:</para>
        /// <list type="bullet">
        /// <item><description><para><c>TrafficScenario = VpcFlowLogAll</c> / <c>VpcFlowLogInternet</c> (VPC flow log scenario):</para>
        /// <list type="bullet">
        /// <item><description><c>Bytes</c>: Bandwidth</description></item>
        /// <item><description><c>Packets</c>: Packets</description></item>
        /// <item><description><c>RoundTripTime</c>: TCP RTT</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>TrafficScenario = TRFlowlog</c> (TR flow log scenario):</para>
        /// <list type="bullet">
        /// <item><description><c>Bytes</c>: Bandwidth</description></item>
        /// <item><description><c>Packets</c>: Packets</description></item>
        /// <item><description><c>PacketsLostNoRoute</c>: Packet loss due to no routing</description></item>
        /// <item><description><c>PacketsLostBlackhole</c>: Packet loss due to blackhole routing</description></item>
        /// <item><description><c>PacketsLostTTLExpired</c>: Packet loss due to TTL timeout</description></item>
        /// <item><description><c>BytesIncrease</c>: Bandwidth increase</description></item>
        /// <item><description><c>BytesIncreaseRatio</c>: Bandwidth increase ratio</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>TrafficScenario = CbwpMetric</c> (Internet Shared Bandwidth metric analysis scenario):</para>
        /// <list type="bullet">
        /// <item><description><c>Bytes</c>: Bandwidth</description></item>
        /// <item><description><c>Packets</c>: Packets</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bytes</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The region where the resource resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The sorting method for network traffic analysis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: Sorts in ascending order.</description></item>
        /// <item><description>DESC: Sorts in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The storage bucket precision property.</para>
        /// <para>The storage bucket precision specifies the storage aggregation epoch to query. Two precision levels are supported: high precision (such as 1 minute) and long epoch (such as 1 day). The specific precision is determined by the network traffic analysis sampling interval configured for high-precision traffic statistics or long-epoch traffic statistics when creating or editing the network traffic analysis instance.</para>
        /// <list type="bullet">
        /// <item><description><para>The storage precision supported by the corresponding tuple of the network traffic analysis instance:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: In minutes (1 minute)</description></item>
        /// <item><description><c>10</c>: In minutes (10 minutes)</description></item>
        /// <item><description><c>60</c>: In minutes (60 minutes, or 1 hour)</description></item>
        /// <item><description><c>1440</c>: In minutes (1440 minutes, or 1 day)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The storage bucket precision can be used for two typical purposes:</para>
        /// <list type="bullet">
        /// <item><description>High-precision traffic statistics: Aggregation at 1-minute, 10-minute, or 60-minute intervals.</description></item>
        /// <item><description>Long-epoch traffic statistics: Aggregation at 1440-minute (1-day) intervals.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Pass a value for this field during the query to specify the storage aggregation epoch. For example:</para>
        /// <list type="bullet">
        /// <item><description>Pass <c>10</c>: Queries short-epoch data aggregated at 10-minute granularity.</description></item>
        /// <item><description>Pass <c>1440</c>: Queries long-epoch data aggregated at 1-day granularity.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Note: The active storage precision values depend on the configuration of the network traffic analysis instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StorageInterval")]
        [Validation(Required=false)]
        public int? StorageInterval { get; set; }

        /// <summary>
        /// <para>The number of entries for the network traffic analysis sorting query.</para>
        /// <para>You can specify a custom number. If this field is not specified, all traffic data that meets the specified conditions is sorted and analyzed within the performance capacity of the network traffic analysis feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <para>The ID of the network traffic analysis instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nta-262****ca07f</para>
        /// </summary>
        [NameInMap("TrafficAnalyzerId")]
        [Validation(Required=false)]
        public string TrafficAnalyzerId { get; set; }

        /// <summary>
        /// <para>Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC flow log analysis</description></item>
        /// <item><description>Public VPC flow log analysis</description></item>
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
        /// <para>The storage aggregation dimension of the network traffic analysis instance.</para>
        /// <para>Based on the TraffficScenario:</para>
        /// <list type="bullet">
        /// <item><description><para>VpcFlowLogAll/VpcFlowLog: Required. Specifies the storage aggregation view to query, which corresponds to the storage aggregation property configured in the network traffic analysis instance.</para>
        /// </description></item>
        /// <item><description><para>TRFlowLog/CbwpMetric: Optional. Automatically adapts based on the storage aggregation property of the network traffic analysis instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tuple1</para>
        /// </summary>
        [NameInMap("TupleDimension")]
        [Validation(Required=false)]
        public string TupleDimension { get; set; }

    }

}
