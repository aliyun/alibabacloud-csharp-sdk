// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmMonitorTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of retries. The system will only judge the application service as abnormal after consecutive monitoring failures to prevent inaccurate monitoring results due to momentary network fluctuations or other reasons. Available retry options are:</para>
        /// <list type="bullet">
        /// <item><description>1 </description></item>
        /// <item><description>2 </description></item>
        /// <item><description>3</description></item>
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
        /// <para>host: the Host field of an HTTP or HTTPS request header during an HTTP or HTTPS health check. The parameter value indicates the HTTP website that you want to visit. By default, the value is the primary domain name. You can change the value based on your business requirements.</para>
        /// <para>path: the URL for HTTP or HTTPS health checks. Default value: /.</para>
        /// <para>code: the alert threshold. During an HTTP or HTTPS health check, the system checks whether a web server functions as expected based on the status code that is returned from the web server. If the returned status code is greater than the specified threshold, the corresponding application service address is deemed abnormal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>400: specifies an invalid request. If an HTTP or HTTPS request contains invalid request parameters, a web server returns a status code that is greater than 400. You must set path to an exact URL if you set code to 400.</description></item>
        /// <item><description>500: specifies a server error. If some exceptions occur on a web server, the web server returns a status code that is greater than 500. This value is used by default.</description></item>
        /// </list>
        /// <para>sni: specifies whether to enable Server Name Indication (SNI). This parameter is used only when the health check protocol is HTTPS. SNI is an extension to the Transport Layer Security (TLS) protocol, which allows a client to specify the host to be connected when the client sends a TLS handshake request. TLS handshakes occur before any data of HTTP requests is sent. Therefore, SNI enables servers to identify the services that clients are attempting to access before certificates are sent. This allows the servers to present correct certificates to the clients. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables SNI.</description></item>
        /// <item><description>false: disables SNI.</description></item>
        /// </list>
        /// <para>followRedirect: specifies whether to follow 3XX redirects. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: follows 3XX redirects. You are redirected to the destination address if a 3XX status code such as 301, 302, 303, 307, or 308 is returned.</description></item>
        /// <item><description>false: does not follow 3XX redirects.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ping:</para>
        /// <para>packetNum: the total number of Internet Control Message Protocol (ICMP) packets that are sent to the address for each ping-based health check. Valid values: 20, 50, and 100.</para>
        /// <para>packetLossRate: the ICMP packet loss rate for each ping-based health check. The packet loss rate in a health check can be calculated by using the following formula: Packet loss rate in a health check = (Number of lost packets/Total number of sent ICMP packets) × 100%. If the packet loss rate reaches the threshold, an alert is triggered. Valid values: 10, 30, 40, 80, 90, and 100.</para>
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
        /// <para>Percentage of selected node probe failures (%), that is, the percentage of abnormal detection points among the total detection points. When the failure ratio exceeds the set threshold, the service address is judged as abnormal. The available failure ratio thresholds are:</para>
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
        /// <para>The time interval (in seconds) for each health check probe. By default, it probes every 60 seconds. The minimum supported interval for health checks is 15 seconds, available for flagship edition instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The health check nodes. You can call the <a href="~~ListCloudGtmMonitorNodes~~">ListCloudGtmMonitorNodes</a> operation to obtain the health check nodes.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmMonitorTemplateRequestIspCityNodes> IspCityNodes { get; set; }
        public class UpdateCloudGtmMonitorTemplateRequestIspCityNodes : TeaModel {
            /// <summary>
            /// <para>The city code of the health check node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) code of the health check node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The name of the health check probe template, which is generally recommended to be distinguishable and memorable for configuration personnel, ideally indicating the health check protocol for easier identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the health check template that you want to modify. This ID uniquely identifies the health check template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mtp-89518052425100**80</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Probe timeout (in milliseconds), data packets not returned within the timeout period are considered as health check timeouts:</para>
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

    }

}
