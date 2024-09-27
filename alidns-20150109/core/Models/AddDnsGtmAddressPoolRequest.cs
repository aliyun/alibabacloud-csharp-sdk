// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The address pools.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The address in the address pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// <para>The information about the source region of the address. The value of this parameter is a JSON string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>lineCode: the line code of the source region for the address</para>
            /// </description></item>
            /// <item><description><para>lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NO_NEED: no need for rectification</description></item>
            /// <item><description>RECTIFIED: rectified</description></item>
            /// <item><description>AUTO: automatic rectification</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

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
            /// <para>The return mode of the addresses: Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SMART: smart return</description></item>
            /// <item><description>ONLINE: always online</description></item>
            /// <item><description>OFFLINE: always offline</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The description of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The nodes for monitoring.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code.</para>
            /// <para>Specify the parameter according to the value of CityCode returned by the DescribeGtmMonitorAvailableConfig operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>The Internet service provider (ISP) node. Specify the parameter according to the value of IspCode returned by the DescribeGtmMonitorAvailableConfig operation.</description></item>
            /// <item><description>If the returned value of GroupType for the DescribeGtmMonitorAvailableConfig operation is BGP or Overseas, IspCode is not required and is set to 465 by default.</description></item>
            /// <item><description>If the returned value of GroupType for the DescribeGtmMonitorAvailableConfig operation is not BGP or Overseas, IspCode is required. When IspCode is specified, CityCode is required.</description></item>
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
        /// <para>The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_RR: returns all addresses.</description></item>
        /// <item><description>RATIO: returns addresses by weight.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all_rr</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The extended information. The required parameters vary based on the health check protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP or HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: the port that you want to check</para>
        /// </description></item>
        /// <item><description><para>host: the host settings</para>
        /// </description></item>
        /// <item><description><para>path: the URL</para>
        /// </description></item>
        /// <item><description><para>code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value. Valid values: 400 and 500.</para>
        /// </description></item>
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>sni: specifies whether to enable Server Name Indication (SNI). This parameter is available only when ProtocolType is set to HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables SNI.</description></item>
        /// <item><description>other: disables SNI.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ping:</para>
        /// <list type="bullet">
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>packetNum: the number of ping packets</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: the loss rate of ping packets</para>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: the port that you want to check</para>
        /// </description></item>
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check feature. If you set this parameter to OPEN, the system verifies the health check configurations. If you set this parameter to CLOSE, the system discards the health check configurations. Default value: CLOSE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: enables the health check feature.</description></item>
        /// <item><description>CLOSE: disables the health check feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The health check protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>PING</description></item>
        /// <item><description>TCP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4: IPv4 address</description></item>
        /// <item><description>IPV6: IPv6 address</description></item>
        /// <item><description>DOMAIN: domain name</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
