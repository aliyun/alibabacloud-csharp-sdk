// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetForgetPasswordConfigurationRequest : TeaModel {
        /// <summary>
        /// 身份认证渠道。枚举取值:email(邮件)、sms(短信)
        /// </summary>
        [NameInMap("AuthenticationChannels")]
        [Validation(Required=false)]
        public List<string> AuthenticationChannels { get; set; }

        /// <summary>
        /// 忘记密码配置状态。枚举取值:enabled(开启)、disabled(禁用)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ForgetPasswordStatus")]
        [Validation(Required=false)]
        public string ForgetPasswordStatus { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
