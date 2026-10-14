// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetLivyComputeTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the request. A value of 1000000 indicates that the request succeeded. Other values indicate that the request failed. For details about the error, see the message field.</para>
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
        public GetLivyComputeTokenResponseBodyData Data { get; set; }
        public class GetLivyComputeTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The token expiration configuration struct.</para>
            /// </summary>
            [NameInMap("autoExpireConfiguration")]
            [Validation(Required=false)]
            public GetLivyComputeTokenResponseBodyDataAutoExpireConfiguration AutoExpireConfiguration { get; set; }
            public class GetLivyComputeTokenResponseBodyDataAutoExpireConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether the token expires automatically. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The expiration period in days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
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
            /// <para>alice</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The expiration time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749457994000</para>
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
            /// <para>d25561157a635bb</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>Token ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>lctk-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("tokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>484D9DDA-300D-525E-AF7A-0CCCA5C64A7A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
