// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.</para>
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
        /// <para>The monitored nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The code of the city where the monitored node is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The code of the Internet service provider (ISP) to which the monitored node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
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
        /// <para>The extended information. The required parameters vary based on the value of ProtocolType.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP or HTTPS</para>
        /// <list type="bullet">
        /// <item><description><para>port: the port that you want to check</para>
        /// </description></item>
        /// <item><description><para>host: the host settings</para>
        /// </description></item>
        /// <item><description><para>path: the URL path</para>
        /// </description></item>
        /// <item><description><para>code: the response code. The health check result is deemed abnormal if the returned value is greater than the specified value.</para>
        /// </description></item>
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>sni: specifies whether to enable server name indication (SNI). This parameter is available only when ProtocolType is set to HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables SNI.</description></item>
        /// <item><description>false: disables SNI.</description></item>
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
        /// <item><description><para>PING</para>
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
        /// <item><description><para>TCP</para>
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
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>PING</description></item>
        /// <item><description>TCP</description></item>
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
        /// <para>The timeout period. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
