// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayOptionRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>421</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The detailed configurations of the gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>TraceDetails</b>: the sampling description of Managed Service for OpenTelemetry. Content: TraceEnabled indicates whether Managed Service for OpenTelemetry is activated. Sample indicates the sampling rate of Managed Service for OpenTelemetry.</description></item>
        /// <item><description><b>LogConfigDetails</b>: the description of Simple Log Service. Content: LogEnabled indicates whether Simple Log Service is activated. ProjectName indicates the Simple Log Service project to which logs are delivered. LogStoreName indicates the name of the Logstore.</description></item>
        /// <item><description><b>EnableHardwareAcceleration</b>: indicates whether hardware acceleration is enabled.</description></item>
        /// <item><description><b>DisableHttp2Alpn</b>: indicates whether the HTTP/2 protocol is disabled.</description></item>
        /// <item><description><b>EnableWaf</b>: indicates whether Web Application Firewall (WAF) is enabled.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("GatewayOption")]
        [Validation(Required=false)]
        public GatewayOption GatewayOption { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-83b0ddb569434f82b9fe8e4c60c4****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}
