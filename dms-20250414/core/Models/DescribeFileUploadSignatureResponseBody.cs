// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeFileUploadSignatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileUploadSignatureResponseBodyData Data { get; set; }
        public class DescribeFileUploadSignatureResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The parameter set that specifies the derived key.</para>
            /// </summary>
            [NameInMap("OssCredential")]
            [Validation(Required=false)]
            public string OssCredential { get; set; }

            /// <summary>
            /// <para>The time of the request. The format follows the ISO 8601 date and time standard.</para>
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
            /// <para>CAIS4gJ1q6Ft5B2yfSjIr5vPHMj4p+lHx/utUUjg13ptZ+5u3oDzkzz2IHhMdXlrCOgYt/8xnG1V6f8flrJ/ToQAX0HfatZq5ZkS9AqnaoXM/te496IFg5D9y7dIs8GgjqHoeOzcYI73WJXEMiLp9EJaxb/9ak/RPTiMOoGIjphKd8keWhLCAxNNGNZRIHkJyqZYTwyzU8ygKRn3mGHdIVN1sw5n8wNF5L+439eX52i17jS46JdM/9ysesH5NpQxbMwkDYnk5oEsKPqdihw3wgNR6aJ7gJZD/Tr6pdyHCzFTmU7ea7uEqYw3clYiOPBnRvEd8eKPnPl5q/HVm4Hs0wxKNuxOSCXZS4yp3MLeH+ekJgOGwWFHz9qnOLmtQXqV22tMCRpzXIj6Zlmz+/reI6iNW+Ory74mxSFbrz3ZP4yv+o+Yv3QbMVumcySkKVbBbVvnv0R8GNsIC2lMUbp+rfShhfFuG2QagAECCyigwAlSAryrFmteD+EVuvxvi0NE7zDJLbUkhek6dcY+/u5V5jcmvL67CQ7bTNk+9lV8WDCvtoCD9ucqTaHweJEd8fS2DaFedAMDf8BfZa2C1CTLhVXdSgE2WORYbMqidelRm7dH3fTbZVvryWKDaveDRLt5J/Qfs**********</para>
            /// </summary>
            [NameInMap("OssSecurityToken")]
            [Validation(Required=false)]
            public string OssSecurityToken { get; set; }

            /// <summary>
            /// <para>The description information used for signature authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9bebe0900716bdefaab899781c7bdfd614ec6ed711e0de5ddf6f5a**********</para>
            /// </summary>
            [NameInMap("OssSignature")]
            [Validation(Required=false)]
            public string OssSignature { get; set; }

            /// <summary>
            /// <para>The version and algorithm of the signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS4-HMAC-SHA256</para>
            /// </summary>
            [NameInMap("OssSignatureVersion")]
            [Validation(Required=false)]
            public string OssSignatureVersion { get; set; }

            /// <summary>
            /// <para>The permission restrictions and constraints for file uploads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJjb25kaXRpb25zIjpbeyJ4LW9zcy1jcmVkZW50aWFsIjoiU1RTLk5YeldyTEo2ZnA5RlNuUTN6OGthQjFFWH**********</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The path for file uploads.</para>
            /// </summary>
            [NameInMap("UploadDir")]
            [Validation(Required=false)]
            public string UploadDir { get; set; }

            /// <summary>
            /// <para>The destination address for file uploads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://**********.oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEE5834-C55A-5995-A6A3-B443304965BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
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
