// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>Code of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSecretsResponseBodyData Data { get; set; }
        public class ListSecretsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Array of secret details</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodyDataItems> Items { get; set; }
            public class ListSecretsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Unix timestamp when the secret was created</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>Gateway type associated with the secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("gatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <para>KMS configuration object</para>
                /// </summary>
                [NameInMap("kmsConfig")]
                [Validation(Required=false)]
                public KMSConfig KmsConfig { get; set; }

                /// <summary>
                /// <para>Name of the secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-secret</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Number of resources referencing this secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("referenceCount")]
                [Validation(Required=false)]
                public int? ReferenceCount { get; set; }

                /// <summary>
                /// <para>Source of the ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("secretId")]
                [Validation(Required=false)]
                public string SecretId { get; set; }

                /// <summary>
                /// <para>Source of the secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>KMS</para>
                /// </summary>
                [NameInMap("secretSource")]
                [Validation(Required=false)]
                public string SecretSource { get; set; }

                /// <summary>
                /// <para>Current status of the secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Unix timestamp when the secret was last updated</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Number of items per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records matching the query</para>
            /// 
            /// <b>Example:</b>
            /// <para>104</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F270C0B-7D6A-5DA7-93E2-******</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
