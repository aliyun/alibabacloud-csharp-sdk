// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListLivyComputeTokenResponseBodyData Data { get; set; }
        public class ListLivyComputeTokenResponseBodyData : TeaModel {
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListLivyComputeTokenResponseBodyDataTokens> Tokens { get; set; }
            public class ListLivyComputeTokenResponseBodyDataTokens : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1749456094000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("createdby")]
                [Validation(Required=false)]
                public string Createdby { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1749456994000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1749456098000</para>
                /// </summary>
                [NameInMap("lastUsedTime")]
                [Validation(Required=false)]
                public long? LastUsedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5d37843fb6f1e8</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// <para>Token ID。</para>
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
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
