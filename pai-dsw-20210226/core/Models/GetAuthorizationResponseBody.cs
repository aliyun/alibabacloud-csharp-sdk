// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// 授权失败错误代码
        /// </summary>
        [NameInMap("AuthorizationFailedCode")]
        [Validation(Required=false)]
        public string AuthorizationFailedCode { get; set; }

        /// <summary>
        /// 授权失败错误消息
        /// </summary>
        [NameInMap("AuthorizationFailedMessage")]
        [Validation(Required=false)]
        public string AuthorizationFailedMessage { get; set; }

        /// <summary>
        /// 是否已经给DSW服务账号授权
        /// </summary>
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
