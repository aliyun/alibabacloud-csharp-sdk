// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmMonitorTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The health check templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public SearchCloudGtmMonitorTemplatesResponseBodyTemplates Templates { get; set; }
        public class SearchCloudGtmMonitorTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-23T13:09Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <para>The extended information. The value of this parameter is a JSON string. The required parameters vary based on the health check protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http(s)</b>:</para>
                /// <para><b>host</b>: indicates the Host field of an HTTP or HTTPS request header during an HTTP or HTTPS health check. The parameter value indicates the HTTP website that you want to visit. By default, the value is the primary domain name. You can change the value based on your business requirements.</para>
                /// <para><b>path</b>: the URL for HTTP or HTTPS health checks. Default value: /.</para>
                /// <para><b>code</b>: indicates the alert threshold. During an HTTP or HTTPS health check, the system checks whether a web server functions as expected based on the status code that is returned from the web server. If the returned status code is greater than the specified threshold, the corresponding application service address is deemed abnormal. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>400: indicates an invalid request. If an HTTP or HTTPS request contains invalid request parameters, a web server returns a status code that is greater than 400. If Verification Content is set to &quot;The error code is greater than 400&quot;, you must specify an exact URL for the path parameter.</description></item>
                /// <item><description>500: indicates a server error. If some exceptions occur on a web server, the web server returns a status code that is greater than 500. The error code that is greater than 500 is used as the alert threshold by default.</description></item>
                /// </list>
                /// <para><b>sni</b>: indicates whether Server Name Indication (SNI) is enabled for HTTPS. SNI is an extension to the Transport Layer Security (TLS) protocol, which allows a client to specify the host to be connected when the client sends a TLS handshake request. TLS handshakes occur before any data of HTTP requests is sent. Therefore, SNI enables servers to identify the services that clients are attempting to access before certificates are sent. This allows the servers to present correct certificates to the clients. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: SNI is enabled.</description></item>
                /// <item><description>false: SNI is disabled.</description></item>
                /// </list>
                /// <para><b>followRedirect</b>: indicates whether 3XX redirection is followed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: You are redirected to the destination address if a status code 3XX, such as 301, 302, 303, 307, or 308, is returned.</description></item>
                /// <item><description>false: You are not redirected to the destination address.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>ping</b>:</para>
                /// <para><b>packetNum</b>: The total number of Internet Control Message Protocol (ICMP) packets that are sent to the address for each ping-based health check. Valid values: 20, 50, and 100.</para>
                /// <para><b>packetLossRate</b>: The packet loss rate for each ping-based health check. The packet loss rate in a check can be calculated by using the following formula: Packet loss rate = (Number of lost packets/Total number of sent ICMP packets) × 100%. If the packet loss rate reaches the threshold, an alert is triggered. Valid values: 10, 30, 40, 80, 90, and 100.</para>
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
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("FailureRate")]
                [Validation(Required=false)]
                public int? FailureRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The IP address type of health check nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPv4: applicable when the destination address of health checks is an IPv4 address</description></item>
                /// <item><description>IPv6: applicable when the destination address of health checks is an IPv6 address</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>The health check nodes.</para>
                /// </summary>
                [NameInMap("IspCityNodes")]
                [Validation(Required=false)]
                public SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes IspCityNodes { get; set; }
                public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes : TeaModel {
                    [NameInMap("IspCityNode")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode> IspCityNode { get; set; }
                    public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>503</para>
                        /// </summary>
                        [NameInMap("CityCode")]
                        [Validation(Required=false)]
                        public string CityCode { get; set; }

                        [NameInMap("CityName")]
                        [Validation(Required=false)]
                        public string CityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>001</para>
                        /// </summary>
                        [NameInMap("CountryCode")]
                        [Validation(Required=false)]
                        public string CountryCode { get; set; }

                        [NameInMap("CountryName")]
                        [Validation(Required=false)]
                        public string CountryName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BGP</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The group type of health check nodes. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>BGP: BGP node</description></item>
                        /// <item><description>OVERSEAS: node outside the Chinese mainland</description></item>
                        /// <item><description>ISP: Internet service provider (ISP) node</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BGP</para>
                        /// </summary>
                        [NameInMap("GroupType")]
                        [Validation(Required=false)]
                        public string GroupType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>465</para>
                        /// </summary>
                        [NameInMap("IspCode")]
                        [Validation(Required=false)]
                        public string IspCode { get; set; }

                        [NameInMap("IspName")]
                        [Validation(Required=false)]
                        public string IspName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IPv4-Ping</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ping</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mtp-89518052425100**80</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-29T13:20Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
