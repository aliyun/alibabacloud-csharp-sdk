// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentThemeUploadSignatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataAgentThemeUploadSignatureResponseBodyData Data { get; set; }
        public class GetDataAgentThemeUploadSignatureResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The policy expiration time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T14:53:41Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The target object key, which is exactly locked by the policy.</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The parameter set that specifies the derived key.</para>
            /// </summary>
            [NameInMap("OssCredential")]
            [Validation(Required=false)]
            public string OssCredential { get; set; }

            /// <summary>
            /// <para>The signature time in the format of yyyyMMdd\&quot;T\&quot;HHmmss\&quot;Z\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20260101T135341Z</para>
            /// </summary>
            [NameInMap("OssDate")]
            [Validation(Required=false)]
            public string OssDate { get; set; }

            /// <summary>
            /// <para>The STS token used to upload files to OSS. The token is valid for 1 hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAIS4gJ1q6Ft5B2yfSjIr5vPHMj4p+lHx/utUUjg13ptZ+5u3oDzkzz2IHhMdXlrCOgYt/8xnG1V6f8flrJ/ToQAX0HfatZq5ZkS9AqnaoXM/te496IFg5D9y7dIs8GgjqHoeOzcYI73WJXEMiLp9EJaxb/9ak/RPTiMOoGIjphKd8keWhLCAxNNGNZRIHkJyqZYTwyzU8ygKRn3mGHdIVN1sw5n8wNF5L+439eX52i17jS46JdM/9ysesH5NpQxbMwkDYnk5oEsKPqdihw3wgNR6aJ7gJZD/Tr6pdyHCzFTmU7ea7uEqYw3clYiOPBnRvEd8eKPnPl5q/HVm2Hs0wxKNuxOSCXZS4yp3MLeH+ekJgOGwWFHz9qnOLmtQXqV22tMCRpzXIj6Zlmz+/reI6iNW+Ory74mxSFbrz3ZP4yv+o+Yv3QbMVumcySkKVbBbVvnv0R8GNsIC2lMUbp+rfShhfFuG2QagAECCyigwAlSAryrFmteD+EVuvxvi0NE7zDJLbUkhek6dcY+/u5V5jcmvL67cQ7bTNk+9lV8WDCvtoCD9ucqTaHweJEd8fS2DaFedAMDf8BfZa2C1CTLhVXdSgE2WORYbMqidelRm7dH3fTbZVvryWKDaveDRLt5J/Qfs**********</para>
            /// </summary>
            [NameInMap("OssSecurityToken")]
            [Validation(Required=false)]
            public string OssSecurityToken { get; set; }

            /// <summary>
            /// <para>The V4 signature value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9bebe0900716bdefaab899781c7bdfd614ec6ed711e0de5ddf6f5a**********</para>
            /// </summary>
            [NameInMap("OssSignature")]
            [Validation(Required=false)]
            public string OssSignature { get; set; }

            /// <summary>
            /// <para>The signature version. The value is fixed as OSS4-HMAC-SHA256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS4-HMAC-SHA256</para>
            /// </summary>
            [NameInMap("OssSignatureVersion")]
            [Validation(Required=false)]
            public string OssSignatureVersion { get; set; }

            /// <summary>
            /// <para>The Base64-encoded value of the policy JSON.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJjb25kaXRpb25zIjpbeyJ4LW9zcy1jcmVkZW50aWFsIjoiU1RTLk5YeldyTEo2ZnA5RlNuUTN6OGthQjFFWH**********</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The theme business identifier generated or reused for this request. Pass this identifier to the CreateDataAgentTheme operation after the upload is complete to register the metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0f8b2c1d****a3e5f7b1c2d</para>
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public string ThemeId { get; set; }

            /// <summary>
            /// <para>The upload directory prefix.</para>
            /// </summary>
            [NameInMap("UploadDir")]
            [Validation(Required=false)]
            public string UploadDir { get; set; }

            /// <summary>
            /// <para>The PostObject destination address over the public network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://**********.oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
