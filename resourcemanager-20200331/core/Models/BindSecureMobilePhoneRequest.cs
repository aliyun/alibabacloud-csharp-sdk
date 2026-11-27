// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class BindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138660628348****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The secure secure phone number.</para>
        /// <para>The secure phone number must be the same as the one specified when you call the <a href="https://help.aliyun.com/document_detail/372556.html">SendVerificationCodeForBindSecureMobilePhone</a> operation to obtain the verification code.</para>
        /// <para>Format: <c>&lt;Country code&gt;-&lt;Secure phone number&gt;</c>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Only secure phone numbers in the Chinese mainland in the <c>86-&lt;Secure phone number&gt;</c> format are supported.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>Secure phone numbers in the Chinese mainland in the <c>86-&lt;Secure phone number&gt;</c> format are not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx-13900001234</para>
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/372556.html">SendVerificationCodeForBindSecureMobilePhone</a> operation to obtain the verification code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
