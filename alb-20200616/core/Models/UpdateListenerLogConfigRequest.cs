// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include custom header fields in access logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: includes custom header fields.</description></item>
        /// <item><description><b>false</b> (default): does not include custom header fields.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can set this parameter to <b>true</b> only when the access logging switch <b>AccessLogEnabled</b> is turned on for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        /// <summary>
        /// <para>The Xtrace configuration information.</para>
        /// </summary>
        [NameInMap("AccessLogTracingConfig")]
        [Validation(Required=false)]
        public UpdateListenerLogConfigRequestAccessLogTracingConfig AccessLogTracingConfig { get; set; }
        public class UpdateListenerLogConfigRequestAccessLogTracingConfig : TeaModel {
            /// <summary>
            /// <para>The status of the Xtrace feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b> (default): disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You can set this parameter to <b>true</b> only when the access logging switch <b>AccessLogEnabled</b> is turned on for the instance.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TracingEnabled")]
            [Validation(Required=false)]
            public bool? TracingEnabled { get; set; }

            /// <summary>
            /// <para>The Xtrace sampling rate.</para>
            /// <para>Valid values: <b>1 to 10000</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TracingSample")]
            [Validation(Required=false)]
            public int? TracingSample { get; set; }

            /// <summary>
            /// <para>The type of Xtrace. Valid values: <b>Zipkin</b> and <b>OpenTelemetry</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Zipkin</para>
            /// </summary>
            [NameInMap("TracingType")]
            [Validation(Required=false)]
            public string TracingType { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run. The log configuration of the listener is not updated. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an <b>HTTP_2xx</b> status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-o4u54y73wq7b******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
