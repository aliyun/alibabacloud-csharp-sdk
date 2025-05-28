// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserRequest : TeaModel {
        /// <summary>
        /// <para>Aliyun account ID.</para>
        /// <remarks>
        /// <para>Warning: For versions of Quick BI released after December 31, 2024, AccountId will be a required parameter. Please modify your API before this date.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;Published only on the China site</para>
        /// 
        /// <b>Example:</b>
        /// <para>191476xxxxx23754</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Aliyun account name.</para>
        /// <list type="bullet">
        /// <item><description>Note: If it is a sub-account, the format should be \&quot;primary account: sub-account\&quot;. For example: <a href="mailto:master_test@aliyun.com">master_test@aliyun.com</a>:subaccount</description></item>
        /// <item><description>Format check: Maximum length of 50 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxxxx@163.com">xxxxxx@163.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccountName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Whether to assign the organization administrator role. Value range: </para>
        /// <list type="bullet">
        /// <item><description>true: Yes </description></item>
        /// <item><description>false: No</description></item>
        /// </list>
        /// <para><notice>This parameter is deprecated and not recommended for use. It is invalid when RoleIds is provided.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AdminUser")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AdminUser { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Whether to assign the organization permission administrator role. Value range: </para>
        /// <list type="bullet">
        /// <item><description>true: Yes </description></item>
        /// <item><description>false: No</description></item>
        /// </list>
        /// <para><notice>This parameter is deprecated and not recommended for use. It is invalid when RoleIds is provided.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <para>Aliyun account nickname.</para>
        /// <list type="bullet">
        /// <item><description>Format check: Maximum length of 50 characters.</description></item>
        /// <item><description>Special format validation: Chinese and English characters, numbers, _ \ / | () ] [</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddd</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>Preset or custom organization role IDs bound to the user, separated by commas, with a maximum of 3. Value range:</para>
        /// <list type="bullet">
        /// <item><description>Organization Administrator (preset role): 111111111</description></item>
        /// <item><description>Permission Administrator (preset role): 111111112</description></item>
        /// <item><description>Regular User (preset role): 111111113</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>111111111,456</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The user type of the organization member. Value range:</para>
        /// <list type="bullet">
        /// <item><description>1: Developer</description></item>
        /// <item><description>2: Visitor</description></item>
        /// <item><description>3: Analyst</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
