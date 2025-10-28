// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetKyuubiTokenResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetKyuubiTokenResponseBodyData Data { get; set; }
        public class GetKyuubiTokenResponseBodyData : TeaModel {
            [NameInMap("autoExpireConfiguration")]
            [Validation(Required=false)]
            public GetKyuubiTokenResponseBodyDataAutoExpireConfiguration AutoExpireConfiguration { get; set; }
            public class GetKyuubiTokenResponseBodyDataAutoExpireConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("expireDays")]
                [Validation(Required=false)]
                public int? ExpireDays { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1749456094000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753932319390</para>
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

            [NameInMap("memberArns")]
            [Validation(Required=false)]
            public List<string> MemberArns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev_serverless_spark</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
