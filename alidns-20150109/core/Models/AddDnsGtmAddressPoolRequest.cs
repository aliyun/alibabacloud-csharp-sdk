// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The list of addresses in the address pool.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>223.5.XX.XX</para>
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// <para>The source region of the address. This parameter is a JSON string.</para>
            /// <list type="bullet">
            /// <item><description><para>lineCode: The line code of the source region.</para>
            /// </description></item>
            /// <item><description><para>lineCodeRectifyType: The rectification type for the line code. Default value: AUTO.</para>
            /// <list type="bullet">
            /// <item><description><para>NO_NEED: No rectification is performed.</para>
            /// </description></item>
            /// <item><description><para>RECTIFIED: The line code is rectified.</para>
            /// </description></item>
            /// <item><description><para>AUTO: The line code is automatically rectified.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;lineCodeRectifyType&quot;:&quot;AUTO&quot;, &quot;lineCode&quot;:[]}</para>
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

            /// <summary>
            /// <para>The weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// <para>The mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SMART: smart return</para>
            /// </description></item>
            /// <item><description><para>ONLINE: always online</para>
            /// </description></item>
            /// <item><description><para>OFFLINE: always offline</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMART</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

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
        /// <para>The instance ID.
        /// &lt;props=&quot;intl&quot;&gt;Call <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstances">DescribeDnsGtmInstances</a> to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-cs02xyk****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The list of health check nodes. If MonitorStatus is set to OPEN, you must specify at least one valid health check node.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code. If MonitorStatus is set to OPEN, CityCode is required.</para>
            /// <para>For information about the valid values, see the response of the DescribeDnsGtmMonitorAvailableConfig operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>If MonitorStatus is set to OPEN, IspCode is required.
            /// For information about the valid values, see the response of the DescribeDnsGtmMonitorAvailableConfig operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The language of some returned parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The load balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: returns addresses by weight.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_RR</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The extended information. This parameter is a JSON string. The required parameters vary based on the health check protocol:</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP and HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>host: The host settings.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// <item><description><para>code: The return code. A response with a status code greater than this value is considered abnormal. Valid values: 400 and 500.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>sni: Specifies whether to enable Server Name Indication (SNI). This parameter is available only for the HTTPS protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable SNI.</para>
        /// </description></item>
        /// <item><description><para>Other values: Disable SNI.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the health check node when the address pool type is DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PING:</para>
        /// <list type="bullet">
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the health check node when the address pool type is DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the health check node when the address pool type is DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureRate&quot;:50,&quot;port&quot;:80}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The status of the health check feature. Default value: CLOSE. If you set this parameter to OPEN, the health check configuration is verified. Otherwise, the configuration is ignored.</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: disabled</para>
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
        /// <para>test</para>
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
        /// <item><description><para>PING</para>
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
        /// <para>The timeout period. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4: IPv4 address</para>
        /// </description></item>
        /// <item><description><para>IPV6: IPv6 address</para>
        /// </description></item>
        /// <item><description><para>DOMAIN: domain name</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
