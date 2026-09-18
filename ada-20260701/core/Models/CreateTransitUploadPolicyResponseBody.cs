// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateTransitUploadPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The object storage key, which is also the <c>key</c> field in the PostObject form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-bundle/tenant-demo/user-demo/20260904120000_0123456789abcdef0123456789abcdef.zip</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The upload policy object. For the complete list of subfields, see the following table.</para>
        /// </summary>
        [NameInMap("PolicyInfo")]
        [Validation(Required=false)]
        public CreateTransitUploadPolicyResponseBodyPolicyInfo PolicyInfo { get; set; }
        public class CreateTransitUploadPolicyResponseBodyPolicyInfo : TeaModel {
            /// <summary>
            /// <para>The <c>OSSAccessKeyId</c> field in the PostObject form. Protect this value together with the entire <c>PolicyInfo</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <REDACTED>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The object storage key. The value is the same as the top-level <c>FilePath</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-bundle/tenant-demo/user-demo/20260904120000_0123456789abcdef0123456789abcdef.zip</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The target URL to which the client sends the PostObject request.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://upload.example.invalid">https://upload.example.invalid</a></para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The Base64-encoded PostObject upload policy. Protect this value together with the entire <c>PolicyInfo</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <REDACTED>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The <c>x-oss-security-token</c> field in the PostObject form when STS credentials are used. This field may be empty when STS is not used. This field contains sensitive authorization information.</para>
            /// 
            /// <b>Example:</b>
            /// <REDACTED>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The signature field in the PostObject form. This field contains sensitive authorization information.</para>
            /// 
            /// <b>Example:</b>
            /// <REDACTED>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        /// <summary>
        /// <para>The request ID, used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the upload policy is generated. A successful response always returns <c>true</c>. An error response is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the newly created Transit record, used for subsequent queries and storage operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transit_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("TransitId")]
        [Validation(Required=false)]
        public string TransitId { get; set; }

    }

}
