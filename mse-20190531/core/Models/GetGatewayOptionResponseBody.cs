// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayOptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The gateway operation details.</para>
        /// <list type="bullet">
        /// <item><description><para><b>TraceDetails</b>: The XTrace sampling description. It includes TraceEnabled, which indicates whether XTrace is enabled, and Sample, which indicates the XTrace sampling rate.</para>
        /// </description></item>
        /// <item><description><para><b>LogConfigDetails</b>: The log delivery service description. It includes LogEnabled, which indicates whether log delivery to Simple Log Service (SLS) is enabled, ProjectName, which indicates the destination project for log delivery, and LogStoreName, which indicates the Logstore name.</para>
        /// </description></item>
        /// <item><description><para><b>EnableHardwareAcceleration</b>: Indicates whether hardware acceleration is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>DisableHttp2Alpn</b>: Indicates whether HTTP/2 is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>EnableWaf</b>: Indicates whether Web Application Firewall (WAF) is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;LogConfigDetails\&quot;: {\&quot;LogEnabled\&quot;: False}, \&quot;TraceDetails\&quot;: {\&quot;TraceEnabled\&quot;: False}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GatewayOption Data { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, a success message is returned.</description></item>
        /// <item><description>If the request fails, the cause of the failure is returned, such as TaskId not found.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C92F4A4D-A2FD-593E-839E-F3D4DFD2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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
