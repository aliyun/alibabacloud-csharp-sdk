// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class VerifyUserAuthenticationRequest : TeaModel {
        /// <summary>
        /// 应用外部Id
        /// </summary>
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// 认证上下文，由AuthenticatorType决定格式
        /// </summary>
        [NameInMap("AuthenticationContext")]
        [Validation(Required=false)]
        public string AuthenticationContext { get; set; }

        /// <summary>
        /// 认证器类型
        /// </summary>
        [NameInMap("AuthenticatorType")]
        [Validation(Required=false)]
        public string AuthenticatorType { get; set; }

        /// <summary>
        /// 客户端SDK生成认证上下文
        /// </summary>
        [NameInMap("ClientExtendParamsJson")]
        [Validation(Required=false)]
        public string ClientExtendParamsJson { get; set; }

        /// <summary>
        /// 客户端SDK生成认证上下文签名信息
        /// </summary>
        [NameInMap("ClientExtendParamsJsonSign")]
        [Validation(Required=false)]
        public string ClientExtendParamsJsonSign { get; set; }

        /// <summary>
        /// 用户自定义记录审计日志信息
        /// </summary>
        [NameInMap("LogParams")]
        [Validation(Required=false)]
        public string LogParams { get; set; }

        /// <summary>
        /// 用户自定义记录审计日志标签
        /// </summary>
        [NameInMap("LogTag")]
        [Validation(Required=false)]
        public string LogTag { get; set; }

        /// <summary>
        /// 认证绑定的操作hash base64标识
        /// </summary>
        [NameInMap("RequireBindHashBase64")]
        [Validation(Required=false)]
        public string RequireBindHashBase64 { get; set; }

        /// <summary>
        /// 会话绑定的challenge base64标识
        /// </summary>
        [NameInMap("RequireChallengeBase64")]
        [Validation(Required=false)]
        public string RequireChallengeBase64 { get; set; }

        /// <summary>
        /// 服务端配置项，决定认证要求属性
        /// </summary>
        [NameInMap("ServerExtendParamsJson")]
        [Validation(Required=false)]
        public string ServerExtendParamsJson { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户端来源IP地址，用于审计
        /// </summary>
        [NameInMap("UserSourceIp")]
        [Validation(Required=false)]
        public string UserSourceIp { get; set; }

    }

}
