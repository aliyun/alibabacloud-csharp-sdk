// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class BindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// <para>The member ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138660628348****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The secure phone number.</para>
        /// <para>The phone number must be the same as the one that you specified when you called <a href="https://help.aliyun.com/document_detail/372556.html">SendVerificationCodeForBindSecureMobilePhone</a> to authenticate and obtain the verification code.</para>
        /// <para>Format: <Country code>-<Phone number>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Only the Chinese mainland phone numbers in the <c>86-&lt;Phone number&gt;</c> format are supported.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The Chinese mainland phone numbers in the <c>86-&lt;Phone number&gt;</c> format are not supported.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/372556.html">SendVerificationCodeForBindSecureMobilePhone</a> to obtain the verification code.</para>
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
