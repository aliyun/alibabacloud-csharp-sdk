// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateDeviceCodeResponseBody : TeaModel {
        /// <summary>
        /// 设备验证码
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// device_code和user_code的有效时长，单位秒
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// 请求token节点的超时时间，单位秒
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// 终端用户验证码
        /// </summary>
        [NameInMap("user_code")]
        [Validation(Required=false)]
        public string UserCode { get; set; }

        /// <summary>
        /// 验证URI
        /// </summary>
        [NameInMap("verification_uri")]
        [Validation(Required=false)]
        public string VerificationUri { get; set; }

        /// <summary>
        /// 包含user_code的完整验证URI
        /// </summary>
        [NameInMap("verification_uri_complete")]
        [Validation(Required=false)]
        public string VerificationUriComplete { get; set; }

    }

}
