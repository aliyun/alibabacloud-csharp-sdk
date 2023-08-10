// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetForgetPasswordConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The forgot password configurations.
        /// </summary>
        [NameInMap("OpenForgetPasswordConfiguration")]
        [Validation(Required=false)]
        public GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration OpenForgetPasswordConfiguration { get; set; }
        public class GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration : TeaModel {
            /// <summary>
            /// 表示忘记密码认证渠道。枚举取值:email(邮件)、sms(短信)
            /// </summary>
            [NameInMap("AuthenticationChannels")]
            [Validation(Required=false)]
            public List<string> AuthenticationChannels { get; set; }

            /// <summary>
            /// Indicates whether the forgot password feature is enabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// Indicates whether email authentication is enabled for the forgot password feature.
            /// </summary>
            [NameInMap("EnableEmail")]
            [Validation(Required=false)]
            public bool? EnableEmail { get; set; }

            /// <summary>
            /// Indicates whether Short Message Service (SMS) authentication is enabled for the forgot password feature.
            /// </summary>
            [NameInMap("EnableSms")]
            [Validation(Required=false)]
            public bool? EnableSms { get; set; }

            /// <summary>
            /// 表示忘记密码配置状态。枚举取值:enabled(开启)、disabled(禁用)
            /// </summary>
            [NameInMap("ForgetPasswordStatus")]
            [Validation(Required=false)]
            public string ForgetPasswordStatus { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
