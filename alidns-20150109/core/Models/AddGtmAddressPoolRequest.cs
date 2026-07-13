// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The list of addresses in the address pool.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The weight of the address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// <para>The mode of the address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SMART</b>: smart return</para>
            /// </description></item>
            /// <item><description><para><b>ONLINE</b>: always online</para>
            /// </description></item>
            /// <item><description><para><b>OFFLINE</b>: always offline</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SMART</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failed health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds. The value must be 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The list of city nodes for monitoring.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code of the monitoring node. For information about valid values, see the response of DescribeGtmMonitorAvailableConfig.</para>
            /// 
            /// <b>Example:</b>
            /// <para>546</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>For information about valid values, see the response of DescribeGtmMonitorAvailableConfig.</para>
            /// </description></item>
            /// <item><description><para>If GroupType is set to Border Gateway Protocol (BGP) or Overseas, IspCityNode.N.IspCode is optional. The default value is 465.</para>
            /// </description></item>
            /// <item><description><para>If GroupType is not set to BGP or Overseas, IspCityNode.N.IspCode is required and must be used with IspCityNode.N.CityCode.</para>
            /// </description></item>
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
        /// <para>The response language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The extended information. The parameters that you must configure vary based on the health check protocol.</para>
        /// <para>HTTP and HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>code: The return code. A response with a return code greater than the specified value is considered abnormal. Valid values: 400 and 500.</para>
        /// </description></item>
        /// <item><description><para>host: The host setting.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// </list>
        /// <para>PING:</para>
        /// <list type="bullet">
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// </list>
        /// <para>TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;host&quot;:&quot;aliyun.com&quot;,&quot;port&quot;:80}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The status of the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OPEN</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b> (default): disabled</para>
        /// </description></item>
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
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The health check protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP</para>
        /// </description></item>
        /// <item><description><para>HTTPS</para>
        /// </description></item>
        /// <item><description><para>Ping</para>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IP</b>: IPv4 address</para>
        /// </description></item>
        /// <item><description><para><b>DOMAIN</b>: domain name</para>
        /// </description></item>
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
