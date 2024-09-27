// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmMonitorTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number, starting from 1, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The health check templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public ListCloudGtmMonitorTemplatesResponseBodyTemplates Templates { get; set; }
        public class ListCloudGtmMonitorTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate : TeaModel {
                /// <summary>
                /// <para>Health check template creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-23T13:09Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Health check template creation time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The number of retries. The system will only judge the application service as abnormal after consecutive monitoring failures to prevent inaccurate monitoring results due to momentary network fluctuations or other reasons. Available retry options are:</para>
                /// <list type="bullet">
                /// <item><description>1 - 2 - 3</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <para>The extended information. The value of this parameter is a JSON string. The required parameters vary based on the health check protocol.</para>
                /// <list type="bullet">
                /// <item><description><para>HTTP or HTTPS:</para>
                /// <para><b>host</b>: the Host field of an HTTP or HTTPS request header during an HTTP or HTTPS health check. The parameter value indicates the HTTP website that you want to visit. By default, the value is the primary domain name. You can change the value based on your business requirements.</para>
                /// <para><b>path</b>: the URL for HTTP or HTTPS health checks. Default value: /.</para>
                /// <para><b>code</b>: the alert threshold. During an HTTP or HTTPS health check, the system checks whether a web server functions as expected based on the status code that is returned from the web server. If the returned status code is greater than the specified threshold, the corresponding application service address is deemed abnormal. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>400: indicates an invalid request. If an HTTP or HTTPS request contains invalid request parameters, a web server returns a status code that is greater than 400. You must specify an exact URL for path if you set code to 400.</description></item>
                /// <item><description>500: indicates a server error. If some exceptions occur on a web server, the web server returns a status code that is greater than 500. This value is used by default.</description></item>
                /// </list>
                /// <para><b>sni</b>: indicates whether Server Name Indication (SNI) is enabled. This parameter is used only when the health check protocol is HTTPS. SNI is an extension to the Transport Layer Security (TLS) protocol, which allows a client to specify the host to be connected when the client sends a TLS handshake request. TLS handshakes occur before any data of HTTP requests is sent. Therefore, SNI enables servers to identify the services that clients are attempting to access before certificates are sent. This allows the servers to present correct certificates to the clients. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: SNI is enabled.</description></item>
                /// <item><description>false: SNI is disabled.</description></item>
                /// </list>
                /// <para><b>followRedirect</b>: indicates whether 3XX redirects are followed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: 3XX redirects are followed. You are redirected to the destination address if a 3XX status code such as 301, 302, 303, 307, or 308 is returned.</description></item>
                /// <item><description>false: 3XX redirects are not followed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>ping:</para>
                /// <para><b>packetNum</b>: the total number of Internet Control Message Protocol (ICMP) packets that are sent to the address for each ping-based health check. Valid values: 20, 50, and 100.</para>
                /// <para><b>packetLossRate</b>: the ICMP packet loss rate for each ping-based health check. The packet loss rate in a health check can be calculated by using the following formula: Packet loss rate in a health check = (Number of lost packets/Total number of sent ICMP packets) × 100%. If the packet loss rate reaches the threshold, an alert is triggered. Valid values: 10, 30, 40, 80, 90, and 100.</para>
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
                /// <para>Percentage of selected node probe failures (%), that is, the percentage of unhealthy check points among total probe points. When the failure ratio exceeds the set threshold, the service address is judged as abnormal. The available failure ratio thresholds are:</para>
                /// <list type="bullet">
                /// <item><description>20</description></item>
                /// <item><description>50</description></item>
                /// <item><description>80</description></item>
                /// <item><description>100</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("FailureRate")]
                [Validation(Required=false)]
                public int? FailureRate { get; set; }

                /// <summary>
                /// <para>The time interval between each check (in seconds), with a default of probing once every minute. The minimum supported health check interval is 15 seconds, available for flagship edition instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The IP address type of health check nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPv4: applicable when health checks are performed on IPv4 addresses.</description></item>
                /// <item><description>IPv6: applicable when health checks are performed on IPv6 addresses.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>The health check nodes. You can call the <a href="~~ListCloudGtmMonitorNodes~~">ListCloudGtmMonitorNodes</a> operation to obtain the health check nodes.</para>
                /// </summary>
                [NameInMap("IspCityNodes")]
                [Validation(Required=false)]
                public ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes IspCityNodes { get; set; }
                public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes : TeaModel {
                    [NameInMap("IspCityNode")]
                    [Validation(Required=false)]
                    public List<ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode> IspCityNode { get; set; }
                    public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode : TeaModel {
                        /// <summary>
                        /// <para>City code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>738</para>
                        /// </summary>
                        [NameInMap("CityCode")]
                        [Validation(Required=false)]
                        public string CityCode { get; set; }

                        /// <summary>
                        /// <para>City name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Beijing</para>
                        /// </summary>
                        [NameInMap("CityName")]
                        [Validation(Required=false)]
                        public string CityName { get; set; }

                        /// <summary>
                        /// <para>Country code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>629</para>
                        /// </summary>
                        [NameInMap("CountryCode")]
                        [Validation(Required=false)]
                        public string CountryCode { get; set; }

                        /// <summary>
                        /// <para>Country name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>China</para>
                        /// </summary>
                        [NameInMap("CountryName")]
                        [Validation(Required=false)]
                        public string CountryName { get; set; }

                        /// <summary>
                        /// <para>Probe node group name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BGP Nodes</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>Probe node group types:</para>
                        /// <list type="bullet">
                        /// <item><description>BGP: BGP nodes</description></item>
                        /// <item><description>OVERSEAS: International nodes</description></item>
                        /// <item><description>ISP: Carrier nodes</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BGP</para>
                        /// </summary>
                        [NameInMap("GroupType")]
                        [Validation(Required=false)]
                        public string GroupType { get; set; }

                        /// <summary>
                        /// <para>Operator code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>465</para>
                        /// </summary>
                        [NameInMap("IspCode")]
                        [Validation(Required=false)]
                        public string IspCode { get; set; }

                        /// <summary>
                        /// <para>Operator name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Alibaba</para>
                        /// </summary>
                        [NameInMap("IspName")]
                        [Validation(Required=false)]
                        public string IspName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the health check probe template, generally for the convenience of configuration personnel to distinguish and remember.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4-Ping</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Protocol types for initiating probes to the target IP address:</para>
                /// <list type="bullet">
                /// <item><description>ping</description></item>
                /// <item><description>tcp</description></item>
                /// <item><description>http</description></item>
                /// <item><description>https</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ping</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Remarks for the health check template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the health check template. This ID uniquely identifies the health check template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mtp-89518052425100**80</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>Probe timeout (in milliseconds), data packets not returned within the timeout period are deemed as health check timeouts:</para>
                /// <list type="bullet">
                /// <item><description>2000</description></item>
                /// <item><description>3000</description></item>
                /// <item><description>5000</description></item>
                /// <item><description>10000</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Last modification time of the health check template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-29T13:20Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>Health check template configuration modification time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>Total number of health check template entries retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages after data pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
