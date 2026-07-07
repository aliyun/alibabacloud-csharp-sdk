// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RefreshAuthTokensResponseBody : TeaModel {
        /// <summary>
        /// <para>The token data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RefreshAuthTokensResponseBodyData Data { get; set; }
        public class RefreshAuthTokensResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The model gateway access URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ai-gateway.example.com/v1">https://ai-gateway.example.com/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The list of tokens.</para>
            /// </summary>
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public List<RefreshAuthTokensResponseBodyDataTokens> Tokens { get; set; }
            public class RefreshAuthTokensResponseBodyDataTokens : TeaModel {
                /// <summary>
                /// <para>The authorization token value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp******lp</para>
                /// </summary>
                [NameInMap("AuthToken")]
                [Validation(Required=false)]
                public string AuthToken { get; set; }

                /// <summary>
                /// <para>The expiration timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719648600</para>
                /// </summary>
                [NameInMap("ExpireAt")]
                [Validation(Required=false)]
                public long? ExpireAt { get; set; }

                /// <summary>
                /// <para>The validity period in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("ExpireSeconds")]
                [Validation(Required=false)]
                public long? ExpireSeconds { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acp-2zef0gov2nh2l3xxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The issuance timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719648000</para>
                /// </summary>
                [NameInMap("IssuedAt")]
                [Validation(Required=false)]
                public long? IssuedAt { get; set; }

                /// <summary>
                /// <para>The license key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lk-abcdef1234567890</para>
                /// </summary>
                [NameInMap("LicenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A51B1DF-96FF-3BCC-B08C-783161D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
