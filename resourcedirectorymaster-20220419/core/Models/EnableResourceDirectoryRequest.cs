// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class EnableResourceDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The mode in which you enable a resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CurrentAccount: The current account is used to enable a resource directory.</description></item>
        /// <item><description>NewManagementAccount: A newly created account is used to enable a resource directory. If you select this mode, you must configure the <c>MAName</c>, <c>MASecureMobilePhone</c>, and <c>VerificationCode</c> parameters.</description></item>
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
        /// <para>The name of the newly created account.</para>
        /// <para>Specify the name in the <c>&lt;Prefix&gt;@rdadmin.aliyunid.com</c> format. The prefix can contain letters, digits, and special characters but cannot contain consecutive special characters. The prefix must start and end with a letter or digit. Valid special characters include underscores (<c>_</c>), periods (.), and hyphens (-). The prefix must be 2 to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:user01@rdadmin.aliyunid.com">user01@rdadmin.aliyunid.com</a></para>
        /// </summary>
        [NameInMap("MAName")]
        [Validation(Required=false)]
        public string MAName { get; set; }

        /// <summary>
        /// <para>The mobile phone number that is bound to the newly created account.</para>
        /// <para>If you leave this parameter empty, the mobile phone number that is bound to the current account is used. The mobile phone number you specify must be the same as the mobile phone number that you specify when you call the <a href="~~SendVerificationCodeForEnableRD~~">SendVerificationCodeForEnableRD</a> operation to obtain a verification code.</para>
        /// <para>Specify the mobile phone number in the <c>&lt;Country code&gt;-&lt;Mobile phone number&gt;</c> format.</para>
        /// <remarks>
        /// <para>Mobile phone numbers in the <c>86-&lt;Mobile phone number&gt;</c> format in the Chinese mainland are not supported.</para>
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
        /// <para>You can call the <a href="~~SendVerificationCodeForEnableRD~~">SendVerificationCodeForEnableRD</a> operation to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
