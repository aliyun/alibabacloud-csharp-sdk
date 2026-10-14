// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListKyuubiTokenResponseBodyData Data { get; set; }
        public class ListKyuubiTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of tokens.</para>
            /// </summary>
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListKyuubiTokenResponseBodyDataTokens> Tokens { get; set; }
            public class ListKyuubiTokenResponseBodyDataTokens : TeaModel {
                /// <summary>
                /// <para>The list of RAM user names of authorized users.</para>
                /// </summary>
                [NameInMap("accountNames")]
                [Validation(Required=false)]
                public List<string> AccountNames { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755496031000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("createdBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <para>The expiration time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1787033891000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The last usage time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760366232121</para>
                /// </summary>
                [NameInMap("lastUsedTime")]
                [Validation(Required=false)]
                public long? LastUsedTime { get; set; }

                /// <summary>
                /// <para>The list of ARNs of authorized users.</para>
                /// </summary>
                [NameInMap("memberArns")]
                [Validation(Required=false)]
                public List<string> MemberArns { get; set; }

                /// <summary>
                /// <para>The token name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev_serverless_spark</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sparkRole")]
                [Validation(Required=false)]
                public List<string> SparkRole { get; set; }

                /// <summary>
                /// <para>The masked token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dxj**********wfg</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// <para>The token ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tk-zpi0*****hdv4y</para>
                /// </summary>
                [NameInMap("tokenId")]
                [Validation(Required=false)]
                public string TokenId { get; set; }

            }

        }

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
