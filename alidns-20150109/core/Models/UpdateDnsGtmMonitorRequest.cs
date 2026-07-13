// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The number of consecutive health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

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
        /// <para>The list of city nodes for health checks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class UpdateDnsGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code of the health check node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The carrier code of the health check node.</para>
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
        /// <para>The ID of the health check configuration. You can call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspool">DescribeDnsGtmInstanceAddressPool</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monito******</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The extended information. The required parameters vary based on the health check protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP(S):</para>
        /// <list type="bullet">
        /// <item><description><para>port: The port for the health check.</para>
        /// </description></item>
        /// <item><description><para>host: The Host header.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// <item><description><para>code: The health check is considered abnormal if the returned status code is greater than the specified value. For example, if you set this parameter to 400, a returned status code of 404 is considered abnormal.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>sni: Specifies whether to enable Server Name Indication (SNI). This parameter is available only for the HTTPS protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable SNI.</para>
        /// </description></item>
        /// <item><description><para>false: Disable SNI.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the node for health checks when the address pool type is DOMAIN.</para>
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
        /// <item><description><para>nodeType: The type of the node for health checks when the address pool type is DOMAIN.</para>
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
        /// <item><description><para>port: The port for the health check.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the node for health checks when the address pool type is DOMAIN.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
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
        /// <para>http</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
