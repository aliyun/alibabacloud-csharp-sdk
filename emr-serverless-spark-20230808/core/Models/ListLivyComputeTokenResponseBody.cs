// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 1000000 indicates that the request was successful. Other values indicate that the request failed. See the message parameter for failure details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListLivyComputeTokenResponseBodyData Data { get; set; }
        public class ListLivyComputeTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of tokens.</para>
            /// </summary>
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListLivyComputeTokenResponseBodyDataTokens> Tokens { get; set; }
            public class ListLivyComputeTokenResponseBodyDataTokens : TeaModel {
                /// <summary>
                /// <para>The time when the token was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1749456094000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The user who created the token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("createdby")]
                [Validation(Required=false)]
                public string Createdby { get; set; }

                /// <summary>
                /// <para>The time when the token expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1749456994000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The time when the token was last used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1749456098000</para>
                /// </summary>
                [NameInMap("lastUsedTime")]
                [Validation(Required=false)]
                public long? LastUsedTime { get; set; }

                /// <summary>
                /// <para>The token name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The token content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5d37843fb6f1e8</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// <para>The token ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lctk-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("tokenId")]
                [Validation(Required=false)]
                public string TokenId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
