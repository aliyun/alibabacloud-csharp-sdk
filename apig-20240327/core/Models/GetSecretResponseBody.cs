// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetSecretResponseBody : TeaModel {
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
        /// <para>The key information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSecretResponseBodyData Data { get; set; }
        public class GetSecretResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>API: API gateway.</description></item>
            /// <item><description>AI: AI gateway.</description></item>
            /// </list>
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
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysecret</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of resources that reference the current key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <item><description>ENALBE: Enabled.</description></item>
            /// <item><description>DISABLE: Disabled.</description></item>
            /// <item><description>DELETED: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENALBE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725868548440</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

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
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE857A85-251D-5018-8103-A38957D71E20</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
