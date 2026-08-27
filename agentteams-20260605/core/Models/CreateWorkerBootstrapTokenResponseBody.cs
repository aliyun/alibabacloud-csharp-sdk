// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerBootstrapTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWorkerBootstrapTokenResponseBodyData Data { get; set; }
        public class CreateWorkerBootstrapTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bootstrap token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bt-xxx</para>
            /// </summary>
            [NameInMap("BootstrapToken")]
            [Validation(Required=false)]
            public string BootstrapToken { get; set; }

            /// <summary>
            /// <para>The CMS configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Cms")]
            [Validation(Required=false)]
            public CreateWorkerBootstrapTokenResponseBodyDataCms Cms { get; set; }
            public class CreateWorkerBootstrapTokenResponseBodyDataCms : TeaModel {
                /// <summary>
                /// <para>The access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://cms-demo">https://cms-demo</a></para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The license key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lk-xxx</para>
                /// </summary>
                [NameInMap("LicenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                /// <summary>
                /// <para>The workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ws-demo</para>
                /// </summary>
                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inst-demo</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The Worker name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INTRANET</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The token fingerprint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:xxx</para>
            /// </summary>
            [NameInMap("TokenFingerprint")]
            [Validation(Required=false)]
            public string TokenFingerprint { get; set; }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-XX-XX-XX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
