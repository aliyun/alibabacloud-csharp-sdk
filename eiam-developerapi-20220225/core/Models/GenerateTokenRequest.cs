// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenRequest : TeaModel {
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// code码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 验证code
        /// </summary>
        [NameInMap("code_verifier")]
        [Validation(Required=false)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// 设备码
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 排除的tag
        /// </summary>
        [NameInMap("exclusive_tag")]
        [Validation(Required=false)]
        public string ExclusiveTag { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// 重定向URI
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 更新token
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// scope范围
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
