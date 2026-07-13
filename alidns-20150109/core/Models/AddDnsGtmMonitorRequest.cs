// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the address pool. You can call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspools">DescribeDnsGtmInstanceAddressPools</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po**</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The number of consecutive health checks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The list of monitoring nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code of the monitoring node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The carrier code of the monitoring node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The language of the response. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The extended information. The parameters vary based on the protocol type.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP or HTTPS</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>host: The Host header.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// <item><description><para>code: The health check is considered abnormal if the returned HTTP status code is greater than this value.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>sni: Specifies whether to enable Server Name Indication (SNI). This parameter is used only when the health check protocol is HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node. This parameter is used when the address pool type is DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PING</para>
        /// <list type="bullet">
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node. This parameter is used when the address pool type is DOMAIN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node. This parameter is used when the address pool type is DOMAIN. Valid values:</para>
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
        /// <remarks>
        /// <para>This parameter must be a JSON string.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureRate&quot;:50,&quot;port&quot;:80}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
