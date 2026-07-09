// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class VerifyImageSignatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. The value &quot;OK&quot; is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value <c>200</c> is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The issuer information.</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public VerifyImageSignatureResponseBodyIssuer Issuer { get; set; }
        public class VerifyImageSignatureResponseBodyIssuer : TeaModel {
            /// <summary>
            /// <para>The common name (CN) of the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIDeepSign User Certificate</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The organization name (O) of the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the issuer is trusted. A value of true indicates that the issuer certificate is issued by a trusted CA.</para>
        /// </summary>
        [NameInMap("IssuerTrusted")]
        [Validation(Required=false)]
        public bool? IssuerTrusted { get; set; }

        /// <summary>
        /// <para>The content credentials manifest information. This parameter is returned only when the image contains a C2PA signature.</para>
        /// </summary>
        [NameInMap("Manifest")]
        [Validation(Required=false)]
        public VerifyImageSignatureResponseBodyManifest Manifest { get; set; }
        public class VerifyImageSignatureResponseBodyManifest : TeaModel {
            /// <summary>
            /// <para>The list of assertions, which contains metadata such as the origin and editing history of the image.</para>
            /// </summary>
            [NameInMap("Assertions")]
            [Validation(Required=false)]
            public List<VerifyImageSignatureResponseBodyManifestAssertions> Assertions { get; set; }
            public class VerifyImageSignatureResponseBodyManifestAssertions : TeaModel {
                /// <summary>
                /// <para>The assertion data, which is detailed metadata in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;actions&quot;:[{&quot;action&quot;:&quot;c2pa.created&quot;}]}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <para>The assertion label, such as c2pa.actions or stds.exif.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2pa.actions</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The signature details.</para>
            /// </summary>
            [NameInMap("SignatureInfo")]
            [Validation(Required=false)]
            public VerifyImageSignatureResponseBodyManifestSignatureInfo SignatureInfo { get; set; }
            public class VerifyImageSignatureResponseBodyManifestSignatureInfo : TeaModel {
                /// <summary>
                /// <para>The signature algorithm, such as <c>ps256</c> or <c>es256</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ps256</para>
                /// </summary>
                [NameInMap("Alg")]
                [Validation(Required=false)]
                public string Alg { get; set; }

                /// <summary>
                /// <para>The distinguished name (DN) of the signing certificate issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN=AIDeepSign CA,O=Alibaba Cloud</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The signing time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-18T10:30:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information. The value <c>success</c> is returned if the request is successful.</para>
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
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The signature verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid: The signature is valid.</description></item>
        /// <item><description>Invalid: The signature is invalid or has been tampered with.</description></item>
        /// <item><description>Trusted: The signature is valid and trusted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Valid</para>
        /// </summary>
        [NameInMap("VerificationState")]
        [Validation(Required=false)]
        public string VerificationState { get; set; }

    }

}
