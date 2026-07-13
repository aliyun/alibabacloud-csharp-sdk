// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmMonitorTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Make sure that the client token is unique for each request. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of consecutive failures that must occur before the system considers the application service unhealthy. This setting helps prevent false alarms caused by transient issues such as network jitter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1</para>
        /// </description></item>
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>3</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The extended information in a JSON string. The parameters vary based on the protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>http(s):</para>
        /// <para><b>host</b>: The Host field in the header of the HTTP or HTTPS request. This field identifies the website that you want to access. The default value is the primary domain name. If the destination website uses a specific host, change this value as needed.</para>
        /// <para><b>path</b>: The URL path for the HTTP or HTTPS health check. The default value is &quot;/&quot;.</para>
        /// <para><b>code</b>: For an HTTP or HTTPS health check, the system determines whether the web server is working correctly based on the return code. If the return code is greater than this threshold, the system considers the application service unhealthy.</para>
        /// <list type="bullet">
        /// <item><description><para>400: Bad Request. If an HTTP or HTTPS request contains incorrect parameters, the web server returns a code greater than 400. If you set the threshold to 400, make sure that you specify the exact URL path.</para>
        /// </description></item>
        /// <item><description><para>500: Server Error. If an exception occurs on the web server, it returns a code greater than 500. The default threshold is 500.</para>
        /// </description></item>
        /// </list>
        /// <para><b>sni</b>: Specifies whether to enable Server Name Indication (SNI). This parameter applies only to the HTTPS protocol. SNI is a Transport Layer Security (TLS) extension that allows a client to specify the hostname to connect to at the start of the TLS handshake. This allows the server to present the correct certificate for the requested service.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable SNI.</para>
        /// </description></item>
        /// <item><description><para>false: Disable SNI.</para>
        /// </description></item>
        /// </list>
        /// <para><b>followRedirect</b>: Specifies whether to follow 3xx redirects.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Follows the redirect if the detection point receives a 3xx status code, such as 301, 302, 303, 307, or 308.</para>
        /// </description></item>
        /// <item><description><para>false: Does not follow the redirect.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ping:</para>
        /// <para><b>packetNum</b>: The number of ICMP packets to send for each ping health check. Valid values: 20, 50, and 100.</para>
        /// <para><b>packetLossRate</b>: The packet loss rate that triggers an alarm. For each ping health check, the system calculates the packet loss rate based on the sent ICMP packets. Packet loss rate = (Number of lost packets / Total number of sent ICMP packets) × 100%. An alarm is triggered if the packet loss rate reaches this threshold. Valid values: 10, 30, 40, 80, 90, and 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The failure rate threshold. An endpoint is considered unhealthy if the percentage of unhealthy detection points exceeds this value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>20</para>
        /// </description></item>
        /// <item><description><para>50</para>
        /// </description></item>
        /// <item><description><para>80</para>
        /// </description></item>
        /// <item><description><para>100</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("FailureRate")]
        [Validation(Required=false)]
        public int? FailureRate { get; set; }

        /// <summary>
        /// <para>The health check interval in seconds. The default value is 60. The minimum interval is 15 seconds, which is available only for Ultimate Edition instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The IP address type for health checks.</para>
        /// <list type="bullet">
        /// <item><description><para>IPv4: The destination address is an IPv4 address.</para>
        /// </description></item>
        /// <item><description><para>IPv6: The destination address is an IPv6 address.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>A list of detection points. For more information, see <a href="https://help.aliyun.com/document_detail/2797349.html">ListCloudGtmMonitorNodes</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public List<CreateCloudGtmMonitorTemplateRequestIspCityNodes> IspCityNodes { get; set; }
        public class CreateCloudGtmMonitorTemplateRequestIspCityNodes : TeaModel {
            /// <summary>
            /// <para>The city code for the detection point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The ISP code for the detection point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The name of the health check template. Name the template to easily identify the health check protocol.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol for health checks on the destination IP address.</para>
        /// <list type="bullet">
        /// <item><description><para>ping</para>
        /// </description></item>
        /// <item><description><para>tcp</para>
        /// </description></item>
        /// <item><description><para>http</para>
        /// </description></item>
        /// <item><description><para>https</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ping</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The health check timeout in milliseconds. If a packet is not returned within the timeout period, the health check is considered to have timed out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2000</para>
        /// </description></item>
        /// <item><description><para>3000</para>
        /// </description></item>
        /// <item><description><para>5000</para>
        /// </description></item>
        /// <item><description><para>10000</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
