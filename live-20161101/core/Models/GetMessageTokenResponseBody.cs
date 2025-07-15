// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMessageTokenResponseBodyResult Result { get; set; }
        public class GetMessageTokenResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The token used to establish a persistent connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oauth_cloud_key:***-b0YY5Gy6Q</para>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>Indicates how long until the token expires. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400000</para>
            /// </summary>
            [NameInMap("AccessTokenExpiredTime")]
            [Validation(Required=false)]
            public long? AccessTokenExpiredTime { get; set; }

            /// <summary>
            /// <para>The updated token. If a token expires, you can call RefreshToken to obtain a new token.</para>
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
