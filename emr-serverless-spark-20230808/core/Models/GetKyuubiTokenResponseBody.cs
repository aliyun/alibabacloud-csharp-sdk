// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetKyuubiTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetKyuubiTokenResponseBodyData Data { get; set; }
        public class GetKyuubiTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The auto-expiration configuration struct.</para>
            /// </summary>
            [NameInMap("autoExpireConfiguration")]
            [Validation(Required=false)]
            public GetKyuubiTokenResponseBodyDataAutoExpireConfiguration AutoExpireConfiguration { get; set; }
            public class GetKyuubiTokenResponseBodyDataAutoExpireConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether auto-expiration is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The expiration period in days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("expireDays")]
                [Validation(Required=false)]
                public int? ExpireDays { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749456094000</para>
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
            /// <para>1753932319390</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The last used time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749456098000</para>
            /// </summary>
            [NameInMap("lastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>The list of authorized user ARNs.</para>
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
            /// <para>Token ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>tk-zpi0*****hdv4y</para>
            /// </summary>
            [NameInMap("tokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

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
