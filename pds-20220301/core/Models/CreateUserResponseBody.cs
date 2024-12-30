// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL of the profile picture.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://aa.com/1.jpg">http://aa.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The time when the user was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639762579768</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The user who created the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The ID of the default drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        /// <summary>
        /// <para>The description of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vipuser</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:a@a.com">a@a.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
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
        /// <para>The role of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>superadmin</description></item>
        /// <item><description>admin</description></item>
        /// <item><description>user</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The state of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: The user is prohibited from logon.</description></item>
        /// <item><description>enabled: The user is in a normal state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the user was modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639762579768</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The custom data.</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserData { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingding_abc001</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
