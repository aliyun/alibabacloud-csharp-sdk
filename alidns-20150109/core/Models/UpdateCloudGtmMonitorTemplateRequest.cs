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
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US (default): English</para>
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
        /// <para>A client-generated token that is used to ensure the idempotence of the request. Make sure that the token is unique for each request. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of consecutive health check failures that must occur before an application service is considered abnormal. This helps prevent false alarms caused by transient issues such as network jitter. Valid values:</para>
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
        /// <para>The extended information in a JSON string. The parameters vary based on the health check protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP and HTTPS:</para>
        /// <para>host: When you perform an HTTP or HTTPS health check, this parameter specifies the Host field in the HTTP request header. It identifies the target website. The default value is the primary domain name. If the target website has specific requirements for the Host field, modify this parameter as needed.</para>
        /// <para>path: The path for the HTTP or HTTPS health check. The default value is /.</para>
        /// <para>code: When you perform an HTTP or HTTPS health check, the system uses the return code from the web server to determine its status. If the return code exceeds the specified threshold, the application service is considered abnormal.</para>
        /// <list type="bullet">
        /// <item><description><para>400: Bad Request. If an HTTP or HTTPS request contains invalid parameters, the web server returns a code greater than 400. If you set the threshold to 400, make sure that you specify the exact URL path.</para>
        /// </description></item>
        /// <item><description><para>500: Server Error. If the web server encounters an error, it returns a code greater than 500. The default threshold is 500.</para>
        /// </description></item>
        /// </list>
        /// <para>sni: Specifies whether to enable Server Name Indication (SNI). This parameter is used only for HTTPS health checks. SNI is an extension to the Transport Layer Security (TLS) protocol. It allows a client to specify the hostname it is trying to connect to at the start of the TLS handshake. Because the TLS handshake occurs before any HTTP data is sent, SNI allows the server to know which service the client is trying to access before sending the certificate. This enables the server to present the correct certificate to the client.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable SNI.</para>
        /// </description></item>
        /// <item><description><para>false: Disable SNI.</para>
        /// </description></item>
        /// </list>
        /// <para>followRedirect: Specifies whether to follow 3xx redirections.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Follow the redirection if the detection point receives a 3xx status code (301, 302, 303, 307, or 308).</para>
        /// </description></item>
        /// <item><description><para>false: Do not follow the redirection.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Ping:</para>
        /// <para>packetNum: The number of ICMP packets to send for each ping health check. Valid values: 20, 50, and 100.</para>
        /// <para>packetLossRate: The packet loss rate that triggers an alarm. For each ping health check, the system calculates the packet loss rate. Packet loss rate = (Number of lost packets / Total number of sent ICMP packets) × 100%. An alarm is triggered if the packet loss rate reaches this threshold. Valid values: 10, 30, 40, 80, 90, and 100.</para>
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
        /// <para>The percentage of failed detection points. An endpoint is considered abnormal if the percentage of detection points that fail the health check exceeds this threshold. Valid values:</para>
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
        /// <para>The list of detection points. Call <a href="https://help.aliyun.com/document_detail/2797327.html">ListCloudGtmMonitorNodes</a> to obtain the information.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmMonitorTemplateRequestIspCityNodes> IspCityNodes { get; set; }
        public class UpdateCloudGtmMonitorTemplateRequestIspCityNodes : TeaModel {
            /// <summary>
            /// <para>The city code of the detection point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The carrier code of the detection point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The name of the health check template. For easy identification, name the template based on its health check protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ping-IPv4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique ID of the health check template that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mtp-89518052425100****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check in milliseconds. If a packet is not returned within the specified timeout period, the health check fails. Valid values:</para>
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

    }

}
