// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The address pools.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The weight of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// <para>The mode of the address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SMART</b>: smart return</description></item>
            /// <item><description><b>ONLINE</b>: always online</description></item>
            /// <item><description><b>OFFLINE</b>: always offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SMART</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The address in the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The ID of the GTM instance for which you want to create an address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds. Set the value to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The monitored nodes.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The code of the city where the monitored node is deployed. For more information about specific values, see the response parameters of DescribeGtmMonitorAvailableConfig.</para>
            /// 
            /// <b>Example:</b>
            /// <para>546</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>The code of the Internet service provider (ISP) to which the monitored node belongs. For more information about specific values, see the response parameters of DescribeGtmMonitorAvailableConfig.</description></item>
            /// <item><description>If the value of the GroupType parameter is BGP or OVERSEAS, IspCode is optional. The default value is 465.</description></item>
            /// <item><description>If the value of the GroupType parameter is not BGP or OVERSEAS, IspCode is required and is used together with CityCode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The language of the values of specific response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The extended information. The required parameters vary based on the value of ProtocolType.</para>
        /// <para>When ProtocolType is set to HTTP or HTTPS:</para>
        /// <list type="bullet">
        /// <item><description>port: the port that you want to check</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// <item><description>code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value. Valid values: 400 and 500.</description></item>
        /// <item><description>host: the host settings</description></item>
        /// <item><description>path: the URL path</description></item>
        /// </list>
        /// <para>When ProtocolType is set to PING:</para>
        /// <list type="bullet">
        /// <item><description>packetNum: the number of ping packets</description></item>
        /// <item><description>packetLossRate: the packet loss rate</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// </list>
        /// <para>When ProtocolType is set to TCP:</para>
        /// <list type="bullet">
        /// <item><description>port: the port that you want to check</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;host&quot;:&quot;aliyun.com&quot;,&quot;port&quot;:80}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OPEN</b>: enables the health check.</description></item>
        /// <item><description><b>CLOSE</b>: disables the health check. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud cluster</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The health check protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>Ping</description></item>
        /// <item><description>TCP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IP</b>: IPv4 address</description></item>
        /// <item><description><b>DOMAIN</b>: domain name</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
