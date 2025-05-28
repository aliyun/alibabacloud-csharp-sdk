// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the organization administrator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AdminUser")]
        [Validation(Required=false)]
        public bool? AdminUser { get; set; }

        /// <summary>
        /// <para>Indicate whether the RAM user is a permission administrator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <para>User status: </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Active</description></item>
        /// <item><description><b>true</b>: Inactive</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>The nickname of the account.</para>
        /// <list type="bullet">
        /// <item><description>Format check: The value can be up to 50 characters in length.</description></item>
        /// <item><description>Special format verification: Chinese and English digits_ \ / | () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Xiao Zhang</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The IDs of the preset or custom organization roles bound to the user, separated by English commas \&quot;,\&quot;, with a maximum of 3. The value range is as follows: - Organization Administrator (preset role): 111111111 - Permission Administrator (preset role): 111111112 - Regular User (preset role): 111111113</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111,456</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The ID of the user to be updated. The user ID is the UserID of the Quick BI, not the UID of Alibaba Cloud.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The type of user who is a member of the organization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 : developer</description></item>
        /// <item><description>2 : visitors</description></item>
        /// <item><description>3 : Analyst</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
