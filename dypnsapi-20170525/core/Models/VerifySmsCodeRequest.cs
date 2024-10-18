// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifySmsCodeRequest : TeaModel {
        /// <summary>
        /// <para>The phone number, which is used to receive SMS verification codes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321111****</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The SMS verification code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("SmsCode")]
        [Validation(Required=false)]
        public string SmsCode { get; set; }

        /// <summary>
        /// <para>The text message verification code. After you successfully call the corresponding API operation to send the SMS verification code, the end users receive the SMS verification code. SmsToken is returned by the SDK for SMS verification for you to verify the text message verification code. For an Android client, sendVerifyCode is called to send the verification code. For an iOS client, sendVerifyCodeWithTimeout is called to send the verification code. For more information, see <a href="https://help.aliyun.com/document_detail/400434.html">Overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sddsbvdbvjd****</para>
        /// </summary>
        [NameInMap("SmsToken")]
        [Validation(Required=false)]
        public string SmsToken { get; set; }

    }

}
