// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayOptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The value 200 indicates that the request is successfully processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The detailed configurations of the gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>TraceDetails</b>: the sampling description of Managed Service for OpenTelemetry. Content: TraceEnabled indicates whether Managed Service for OpenTelemetry is activated. Sample indicates the sampling rate of Managed Service for OpenTelemetry.</description></item>
        /// <item><description><b>LogConfigDetails</b>: the description of Simple Log Service. Content: LogEnabled indicates whether Simple Log Service is activated. ProjectName indicates the Simple Log Service project to which logs are delivered. LogStoreName indicates the name of the Logstore.</description></item>
        /// <item><description><b>EnableHardwareAcceleration</b>: indicates whether hardware acceleration is enabled.</description></item>
        /// <item><description><b>DisableHttp2Alpn</b>: indicates whether the HTTP/2 protocol is disabled.</description></item>
        /// <item><description><b>EnableWaf</b>: indicates whether Web Application Firewall (WAF) is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;LogConfigDetails\&quot;: {\&quot;LogEnabled\&quot;: False}, \&quot;TraceDetails\&quot;: {\&quot;TraceEnabled\&quot;: False}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GatewayOption Data { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, a success message is returned.</description></item>
        /// <item><description>If the request fails, an error message is returned, such as the &quot;TaskId not found&quot; message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The request is successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C92F4A4D-A2FD-593E-839E-F3D4DFD2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
