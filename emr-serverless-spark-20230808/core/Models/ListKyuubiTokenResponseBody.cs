// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiTokenResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListKyuubiTokenResponseBodyData Data { get; set; }
        public class ListKyuubiTokenResponseBodyData : TeaModel {
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListKyuubiTokenResponseBodyDataTokens> Tokens { get; set; }
            public class ListKyuubiTokenResponseBodyDataTokens : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-02-11T02:23:02Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_user</para>
                /// </summary>
                [NameInMap("createdBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1740366769165</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1740366232121</para>
                /// </summary>
                [NameInMap("lastUsedTime")]
                [Validation(Required=false)]
                public long? LastUsedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dev_serveless_spark</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f14c1347-dcfd-4082-b101-77aa96b5de36</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// <para>Token ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>f14c1347-dcfd-4082-b101-77aa96b5de36</para>
                /// </summary>
                [NameInMap("tokenId")]
                [Validation(Required=false)]
                public string TokenId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
