// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record custom headers in the access log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can set this parameter to <b>true</b> only if the access log feature is enabled by specifying <b>AccessLogEnabled</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        /// <summary>
        /// <para>The configuration information about the Xtrace feature.</para>
        /// </summary>
        [NameInMap("AccessLogTracingConfig")]
        [Validation(Required=false)]
        public UpdateListenerLogConfigRequestAccessLogTracingConfig AccessLogTracingConfig { get; set; }
        public class UpdateListenerLogConfigRequestAccessLogTracingConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the Xtrace feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <para>You can set this parameter to <b>true</b> only if the access log feature is enabled by specifying <b>AccessLogEnabled</b>.</para>
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
            /// <para>The sampling rate of the Xtrace feature.</para>
            /// <para>Valid values: <b>1 to 10000</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only if you set <b>TracingEnabled</b> to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TracingSample")]
            [Validation(Required=false)]
            public int? TracingSample { get; set; }

            /// <summary>
            /// <para>The type of Xtrace. Set the value to <b>Zipkin</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only if you set <b>TracingEnabled</b> to <b>true</b>.</para>
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
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: (default): performs a dry run and performs the actual request. If the request passes the dry run, a <b>2xx HTTP</b> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
