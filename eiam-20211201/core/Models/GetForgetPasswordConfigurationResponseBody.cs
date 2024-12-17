// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetForgetPasswordConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The forgot password configurations.</para>
        /// </summary>
        [NameInMap("OpenForgetPasswordConfiguration")]
        [Validation(Required=false)]
        public GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration OpenForgetPasswordConfiguration { get; set; }
        public class GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration : TeaModel {
            /// <summary>
            /// <para>表示忘记密码认证渠道。枚举取值:email(邮件)、sms(短信)</para>
            /// </summary>
            [NameInMap("AuthenticationChannels")]
            [Validation(Required=false)]
            public List<string> AuthenticationChannels { get; set; }

            /// <summary>
            /// <para>Indicates whether the forgot password feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether email authentication is enabled for the forgot password feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableEmail")]
            [Validation(Required=false)]
            public bool? EnableEmail { get; set; }

            /// <summary>
            /// <para>Indicates whether Short Message Service (SMS) authentication is enabled for the forgot password feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSms")]
            [Validation(Required=false)]
            public bool? EnableSms { get; set; }

            /// <summary>
            /// <para>表示忘记密码配置状态。枚举取值:enabled(开启)、disabled(禁用)</para>
            /// </summary>
            [NameInMap("ForgetPasswordStatus")]
            [Validation(Required=false)]
            public string ForgetPasswordStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
