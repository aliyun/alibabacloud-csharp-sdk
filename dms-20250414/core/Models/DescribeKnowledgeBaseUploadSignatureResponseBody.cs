// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeKnowledgeBaseUploadSignatureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeKnowledgeBaseUploadSignatureResponseBodyData Data { get; set; }
        public class DescribeKnowledgeBaseUploadSignatureResponseBodyData : TeaModel {
            [NameInMap("OssCredential")]
            [Validation(Required=false)]
            public string OssCredential { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20260101T135341Z</para>
            /// </summary>
            [NameInMap("OssDate")]
            [Validation(Required=false)]
            public string OssDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAIS4gJ1q6Ft5B2yfSjIr5vPHMj4p+lHx/utUUjg13ptZ+5u3oDzkzz2IHhMdXlrCOgYt/8xnG1V6f8flrJ/ToQAX0HfatZq5ZkS9AqnaoXM/te496IFg5D9y7dIs8GgjqHoeOzcYI73WJXEMiLp9EJaxb/9ak/RPTiMOoGIjphKd8keWhLCAxNNGNZRIHkJyqZYTwyzU8ygKRn3mGHdIVN1sw5n8wNF5L+439eX52i17jS46JdM/9ysesH5NpQxbMwkDYnk5oEsKPqdihw3wgNR6aJ7gJZD/Tr6pdyHCzFTmU7ea7uEqYw3clYiOPBnRvEd8eKPnPl5q/HVm4Hs0wxKNuxOSCXZS4yp3MLeH+ekJgOGwWFHz9qnOLmtQXqV22tMCRpzXIj6Zlmz+/reI6iNW+Ory74mxSFbrz3ZP4yv+o+Yv3QbMVumcySkKVbBbVvnv0R8GNsIC2lMUbp+rfShhfFuG2QagAECCyigwAlSAryrFmteD+EVuvxvi0NE7zDJLbUkhek6dcY+/u5V5jcmvL67CQ7bTNk+9lV8WDCvtoCD9ucqTaHweJEd8fS2DaFedAMDf8BfZa2C1CTLhVXdSgE2WORYbMqidelRm7dH3fTbZVvryWKDaveDRLt5J/Qfs**********</para>
            /// </summary>
            [NameInMap("OssSecurityToken")]
            [Validation(Required=false)]
            public string OssSecurityToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9bebe0900716bdefaab899781c7bdfd614ec6ed711e0de5ddf6f5a**********</para>
            /// </summary>
            [NameInMap("OssSignature")]
            [Validation(Required=false)]
            public string OssSignature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS4-HMAC-SHA256</para>
            /// </summary>
            [NameInMap("OssSignatureVersion")]
            [Validation(Required=false)]
            public string OssSignatureVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJjb25kaXRpb25zIjpbeyJ4LW9zcy1jcmVkZW50aWFsIjoiU1RTLk5aRmR2RDJRWlFSeWlwZmpkS295NEYxb2ovMjAyNjA1MTQvY24taGFuZ3pob3Uvb3NzL2FsaXl1bl92NF9yZXF1ZXN0In0seyJ4LW9zcy1kYXRlIjoiMjAyNjA1MTRUMDMzMjI3WiJ9LHsieC1vc3Mtc2VjdXJpdHktdG9rZW4iOiJDQUlTMmdKMXE2RnQ1QjJ5ZlNqSXI1bnpMOHp3MzQ1NzVwQ1NhMWJYam1RZVkvWVlxZlRFaUR6MklIaE1**</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("UploadDir")]
            [Validation(Required=false)]
            public string UploadDir { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://onemeta-kb-staging.oss-cn-hangzhou.aliyuncs.com">https://onemeta-kb-staging.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KnowledgeBaseNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Resource not found xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
