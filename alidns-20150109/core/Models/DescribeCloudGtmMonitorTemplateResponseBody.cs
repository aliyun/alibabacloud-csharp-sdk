// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmMonitorTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the health check template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-23T13:09Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp that indicates when the health check template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that a health check must fail before the application service is declared abnormal. This prevents false alarms caused by transient issues such as network jitter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1</para>
        /// </description></item>
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>3</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para>For HTTP and HTTPS:</para>
        /// <para><b>host</b>: The Host field in the HTTP or HTTPS request header. This field identifies the website that you want to access. The default value is the primary domain name. If the target website has specific host requirements, modify this parameter.</para>
        /// <para><b>path</b>: The URL path for HTTP or HTTPS health checks. The default value is /.</para>
        /// <para><b>code</b>: The system determines whether the web server is working as expected based on the return code. If the return code is greater than the specified threshold, the application service is considered abnormal.</para>
        /// <list type="bullet">
        /// <item><description><para>400: Bad Request. If an HTTP or HTTPS request contains incorrect parameters, the web server returns a code greater than 400. If you set the threshold to 400, specify the exact URL path.</para>
        /// </description></item>
        /// <item><description><para>500: Server Error. If an exception occurs on the web server, it returns a code greater than 500. The default threshold is 500.</para>
        /// </description></item>
        /// </list>
        /// <para><b>sni</b>: Specifies whether to enable Server Name Indication (SNI). This parameter is used only for the HTTPS protocol. SNI is a Transport Layer Security (TLS) extension that allows a client to specify the hostname it wants to connect to at the start of the TLS handshake. This allows the server to present the correct certificate for that hostname.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable SNI.</para>
        /// </description></item>
        /// <item><description><para>false: Disable SNI.</para>
        /// </description></item>
        /// </list>
        /// <para><b>followRedirect</b>: Specifies whether to follow 3xx redirections.</para>
        /// <list type="bullet">
        /// <item><description><para>true: If the status code returned by the detection point is 3xx (301, 302, 303, 307, or 308), the system follows the redirection.</para>
        /// </description></item>
        /// <item><description><para>false: The system does not follow the redirection.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For ping:</para>
        /// <para><b>packetNum</b>: The number of ICMP packets to send for each ping health check. Valid values: 20, 50, and 100.</para>
        /// <para><b>packetLossRate</b>: The packet loss rate threshold. For each ping health check, the system calculates the packet loss rate. If the packet loss rate reaches the threshold, an alert is triggered. Packet loss rate = (Number of lost packets / Total number of sent ICMP packets) × 100%. Valid values for the packet loss rate are 10, 30, 40, 80, 90, and 100.</para>
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
        /// <para>The percentage of failed detection points. If the percentage of failed detection points exceeds this value, the endpoint is declared abnormal. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("FailureRate")]
        [Validation(Required=false)]
        public int? FailureRate { get; set; }

        /// <summary>
        /// <para>The interval between health checks in seconds. The default value is 60. The minimum interval is 15 seconds. This feature is available only for Ultimate Edition instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The IP address type of the detection points:</para>
        /// <list type="bullet">
        /// <item><description><para>IPv4: The target address is an IPv4 address.</para>
        /// </description></item>
        /// <item><description><para>IPv6: The target address is an IPv6 address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeCloudGtmMonitorTemplateResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeCloudGtmMonitorTemplateResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmMonitorTemplateResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeCloudGtmMonitorTemplateResponseBodyIspCityNodesIspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the health check template. To easily identify the template, specify a name that indicates the health check protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol used to probe the target IP address:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>ping</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The remarks on the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AEC7A64-3CB1-4C49-8B35-0B901F1E26BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique ID of the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mtp-89518052425100****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The health check timeout period in milliseconds. If a packet is not returned within the specified timeout period, the health check fails. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The time when the health check template was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp that indicates when the health check template was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
