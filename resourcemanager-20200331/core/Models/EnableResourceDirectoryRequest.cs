// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class EnableResourceDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The method used to enable the resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CurrentAccount: enables the resource directory by using the current logon account.</description></item>
        /// <item><description>NewManagementAccount: enables the resource directory by creating a new management account. If you select this method, you must configure <c>MAName</c>, <c>MASecureMobilePhone</c>, and <c>VerificationCode</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CurrentAccount</para>
        /// </summary>
        [NameInMap("EnableMode")]
        [Validation(Required=false)]
        public string EnableMode { get; set; }

        /// <summary>
        /// <para>The name of the new management account.</para>
        /// <para>Format: <c>&lt;Prefix&gt;@rdadmin.aliyunid.com</c>. The prefix can contain letters, digits, and the special characters <c>_.-</c>. The prefix must start and end with a letter or digit, and cannot contain consecutive special characters. The prefix must be 2 to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:user01@rdadmin.aliyunid.com">user01@rdadmin.aliyunid.com</a></para>
        /// </summary>
        [NameInMap("MAName")]
        [Validation(Required=false)]
        public string MAName { get; set; }

        /// <summary>
        /// <para>The secure phone number of the new management account.</para>
        /// <para>If you leave this parameter empty, the secure phone number of the current logon account is used. The phone number must be the same as the one used to authenticate and obtain the verification code in <a href="https://help.aliyun.com/document_detail/364248.html">SendVerificationCodeForEnableRD</a>.</para>
        /// <para>Format: <c>&lt;Country code&gt;-&lt;Phone number&gt;</c>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>Phone numbers from the Chinese mainland in the format <c>86-&lt;Phone number&gt;</c> are not supported.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Only phone numbers from the Chinese mainland in the format <c>86-&lt;Phone number&gt;</c> are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xx-13900001234</para>
        /// </summary>
        [NameInMap("MASecureMobilePhone")]
        [Validation(Required=false)]
        public string MASecureMobilePhone { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/364248.html">SendVerificationCodeForEnableRD</a> to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
