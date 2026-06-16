// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetForgetPasswordConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The forgot password configuration.</para>
        /// </summary>
        [NameInMap("OpenForgetPasswordConfiguration")]
        [Validation(Required=false)]
        public GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration OpenForgetPasswordConfiguration { get; set; }
        public class GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of authentication channels for the forgot password feature. This parameter is required when ForgetPasswordStatus is set to enabled. Valid values: email, sms, totp (one-time password), and web_authn (WebAuthn).</para>
            /// </summary>
            [NameInMap("AuthenticationChannels")]
            [Validation(Required=false)]
            public List<string> AuthenticationChannels { get; set; }

            /// <summary>
            /// <para>Indicates whether the forgot password feature is enabled. This parameter is deprecated. Use the ForgetPasswordStatus parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether email is enabled as an authentication method for the forgot password feature. This parameter is deprecated. Use the AuthenticationChannels parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableEmail")]
            [Validation(Required=false)]
            public bool? EnableEmail { get; set; }

            /// <summary>
            /// <para>Indicates whether SMS is enabled as an authentication method for the forgot password feature. This parameter is deprecated. Use the AuthenticationChannels parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSms")]
            [Validation(Required=false)]
            public bool? EnableSms { get; set; }

            /// <summary>
            /// <para>The status of the forgot password configuration. Valid values: enabled and disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
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
