// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of key information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSecretsResponseBodyData Data { get; set; }
        public class ListSecretsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of key details.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodyDataItems> Items { get; set; }
            public class ListSecretsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The creation timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725617840096</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The gateway type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("gatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <para>The KMS configuration information.</para>
                /// </summary>
                [NameInMap("kmsConfig")]
                [Validation(Required=false)]
                public KMSConfig KmsConfig { get; set; }

                /// <summary>
                /// <para>The key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_secret</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The resource count that references the current key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("referenceCount")]
                [Validation(Required=false)]
                public int? ReferenceCount { get; set; }

                /// <summary>
                /// <para>The key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sec-d5e6shmm1hkoxxxxxxxx</para>
                /// </summary>
                [NameInMap("secretId")]
                [Validation(Required=false)]
                public string SecretId { get; set; }

                /// <summary>
                /// <para>The key source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KMS</para>
                /// </summary>
                [NameInMap("secretSource")]
                [Validation(Required=false)]
                public string SecretSource { get; set; }

                /// <summary>
                /// <para>The key status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLE: Enabled.</description></item>
                /// <item><description>DISABLE: Disabled.</description></item>
                /// <item><description>DELETED: Deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1721116090326</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>3A3D1392-0F71-5A10-9AE8-89C434696966</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
