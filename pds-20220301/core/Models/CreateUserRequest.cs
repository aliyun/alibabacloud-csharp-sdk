// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the profile picture.</para>
        /// <para>If you specify the parameter in the HTTP URL format, the URL must start with http:// or https:// and can be up to 4 KB in size.</para>
        /// <para>If you specify the parameter in the data URL format, the URL must start with data:// and be encoded in Base64. The URL can be up to 300 KB in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://a.b.c/pds.jpg">http://a.b.c/pds.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The description of the user. The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The VIP user</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123@pds.com">123@pds.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The information about the group.</para>
        /// </summary>
        [NameInMap("group_info_list")]
        [Validation(Required=false)]
        public List<CreateUserRequestGroupInfoList> GroupInfoList { get; set; }
        public class CreateUserRequestGroupInfoList : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g123</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <para>The nickname of the user. The nickname can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuer</para>
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13900001111</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The role of the user. Default value: user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>superadmin</description></item>
        /// <item><description>admin</description></item>
        /// <item><description>user</description></item>
        /// </list>
        /// <para>If the domain can be divided into subdomains, the subdomain_super_admin and subdomain_admin roles are also supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>subdomain_super_admin</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>subdomain_admin</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>superadmin</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>admin</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>user</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The state of the user. Default value: enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: The user is in a normal state.</description></item>
        /// <item><description>disabled: The user is prohibited from logon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The custom data. The data can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserData { get; set; }

        /// <summary>
        /// <para>The user ID. The ID can be up to 64 characters in length and cannot contain number signs (#).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuserid1</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username. The username can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsusername</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
