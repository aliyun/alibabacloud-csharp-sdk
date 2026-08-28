// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateExternalAgentBootstrapTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Bootstrap Token and CMS configuration required for connecting the external agent.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateExternalAgentBootstrapTokenResponseBodyData Data { get; set; }
        public class CreateExternalAgentBootstrapTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The external agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The Bootstrap Token used for connecting the external agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bootstrap-token</para>
            /// </summary>
            [NameInMap("bootstrapToken")]
            [Validation(Required=false)]
            public string BootstrapToken { get; set; }

            /// <summary>
            /// <para>The CMS configuration used for connecting the external agent.</para>
            /// </summary>
            [NameInMap("cms")]
            [Validation(Required=false)]
            public CreateExternalAgentBootstrapTokenResponseBodyDataCms Cms { get; set; }
            public class CreateExternalAgentBootstrapTokenResponseBodyDataCms : TeaModel {
                /// <summary>
                /// <para>The CMS reporting endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://public.example.com/apm/trace/opentelemetry">https://public.example.com/apm/trace/opentelemetry</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The license key used for CMS connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>license-key</para>
                /// </summary>
                [NameInMap("licenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                /// <summary>
                /// <para>The CMS workspace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cms-workspace</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The network type for connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INTERNET: public network</description></item>
            /// <item><description>INTRANET: internal network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The fingerprint of the Bootstrap Token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fingerprint</para>
            /// </summary>
            [NameInMap("tokenFingerprint")]
            [Validation(Required=false)]
            public string TokenFingerprint { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message indicating the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
