// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class CreateUserAuthenticateOptionsRequest : TeaModel {
        /// <summary>
        /// 应用外部Id
        /// </summary>
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// 认证器类型
        /// </summary>
        [NameInMap("AuthenticatorType")]
        [Validation(Required=false)]
        public string AuthenticatorType { get; set; }

        /// <summary>
        /// 操作hash，用来和认证绑定
        /// </summary>
        [NameInMap("BindHashBase64")]
        [Validation(Required=false)]
        public string BindHashBase64 { get; set; }

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

    }

}
