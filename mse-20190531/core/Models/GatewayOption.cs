// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GatewayOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the HTTP/2 protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableHttp2Alpn")]
        [Validation(Required=false)]
        public bool? DisableHttp2Alpn { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hardware acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Web Application Firewall (WAF).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// <para>The description of Simple Log Service.</para>
        /// </summary>
        [NameInMap("LogConfigDetails")]
        [Validation(Required=false)]
        public GatewayOptionLogConfigDetails LogConfigDetails { get; set; }
        public class GatewayOptionLogConfigDetails : TeaModel {
            /// <summary>
            /// <para>Specifies whether to activate Simple Log Service.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogEnabled")]
            [Validation(Required=false)]
            public bool? LogEnabled { get; set; }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The name of the destination Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("TraceDetails")]
        [Validation(Required=false)]
        public GatewayOptionTraceDetails TraceDetails { get; set; }
        public class GatewayOptionTraceDetails : TeaModel {
            /// <summary>
            /// <para>The sampling rate of Tracing Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Sample")]
            [Validation(Required=false)]
            public long? Sample { get; set; }

            /// <summary>
            /// <para>The ID of the SkyWalking service. This parameter is required if TraceType is set to SKYWALKING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10458</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The port of the SkyWalking service. This parameter is required if TraceType is set to SKYWALKING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// <para>Specifies whether to activate Tracing Analysis.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TraceEnabled")]
            [Validation(Required=false)]
            public bool? TraceEnabled { get; set; }

            /// <summary>
            /// <para>The type of Tracing Analysis. Valid values: XTRACE and SKYWALKING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XTRACE</para>
            /// </summary>
            [NameInMap("TraceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

        }

    }

}
