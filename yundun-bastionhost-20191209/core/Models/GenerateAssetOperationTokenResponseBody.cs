// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset operation token.</para>
        /// </summary>
        [NameInMap("AssetOperationToken")]
        [Validation(Required=false)]
        public GenerateAssetOperationTokenResponseBodyAssetOperationToken AssetOperationToken { get; set; }
        public class GenerateAssetOperationTokenResponseBodyAssetOperationToken : TeaModel {
            /// <summary>
            /// <para>The number of remaining uses for the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CountLeft")]
            [Validation(Required=false)]
            public long? CountLeft { get; set; }

            /// <summary>
            /// <para>The expiration time of the token. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709110797</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the token has a use limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasCountLimit")]
            [Validation(Required=false)]
            public bool? HasCountLimit { get; set; }

            /// <summary>
            /// <para>The maximum number of times the token can be renewed. A value of 0 indicates that the token cannot be renewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxRenewCount")]
            [Validation(Required=false)]
            public long? MaxRenewCount { get; set; }

            /// <summary>
            /// <para>The number of times the token has been renewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RenewCount")]
            [Validation(Required=false)]
            public long? RenewCount { get; set; }

            /// <summary>
            /// <para>The single sign-on (SSO) URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sso://eyJOT0RFX0NPTU1PTiI6eyJNb2R******</para>
            /// </summary>
            [NameInMap("SsoUrl")]
            [Validation(Required=false)]
            public string SsoUrl { get; set; }

            /// <summary>
            /// <para>The O\&amp;M token that is requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NmYyMmEzNmMwYzljNGY******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
