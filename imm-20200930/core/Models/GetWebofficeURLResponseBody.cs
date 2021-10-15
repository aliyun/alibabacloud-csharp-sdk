// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetWebofficeURLResponseBody : TeaModel {
        /// <summary>
        /// access token
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// access token 过期时间
        /// </summary>
        [NameInMap("AccessTokenExpiredTime")]
        [Validation(Required=false)]
        public string AccessTokenExpiredTime { get; set; }

        /// <summary>
        /// refresh token
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// refresh token 过期时间
        /// </summary>
        [NameInMap("RefreshTokenExpiredTime")]
        [Validation(Required=false)]
        public string RefreshTokenExpiredTime { get; set; }

        /// <summary>
        /// 请求 id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 预览编辑地址
        /// </summary>
        [NameInMap("WebofficeURL")]
        [Validation(Required=false)]
        public string WebofficeURL { get; set; }

    }

}
