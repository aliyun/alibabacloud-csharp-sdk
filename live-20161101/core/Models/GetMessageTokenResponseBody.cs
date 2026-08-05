// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMessageTokenResponseBodyResult Result { get; set; }
        public class GetMessageTokenResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Token used for establishing persistent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oauth_cloud_key:***-b0YY5Gy6Q</para>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>Logon token expiration time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400000</para>
            /// </summary>
            [NameInMap("AccessTokenExpiredTime")]
            [Validation(Required=false)]
            public long? AccessTokenExpiredTime { get; set; }

            /// <summary>
            /// <para>Refresh token. If the AccessToken expires, you can use the RefreshToken to obtain a new token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oauth_cloud_key:****-Q62xggOTdgk3gw=</para>
            /// </summary>
            [NameInMap("RefreshToken")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }

        }

    }

}
