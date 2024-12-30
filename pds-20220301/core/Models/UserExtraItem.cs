// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UserExtraItem : TeaModel {
        [NameInMap("account")]
        [Validation(Required=false)]
        public List<AccountLinkInfo> Account { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://a.b.c/ccp.jpg">http://a.b.c/ccp.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1567407718386</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("default_drive")]
        [Validation(Required=false)]
        public BaseDriveResponse DefaultDrive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        [NameInMap("default_location")]
        [Validation(Required=false)]
        public string DefaultLocation { get; set; }

        [NameInMap("deny_change_password_by_self")]
        [Validation(Required=false)]
        public bool? DenyChangePasswordBySelf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccp team user</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hz999</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:123@ccp.com">123@ccp.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("expired_at")]
        [Validation(Required=false)]
        public long? ExpiredAt { get; set; }

        [NameInMap("is_sync")]
        [Validation(Required=false)]
        public bool? IsSync { get; set; }

        [NameInMap("last_login_time")]
        [Validation(Required=false)]
        public long? LastLoginTime { get; set; }

        [NameInMap("need_change_password_next_login")]
        [Validation(Required=false)]
        public bool? NeedChangePasswordNextLogin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("parent_group")]
        [Validation(Required=false)]
        public List<BaseDriveResponse> ParentGroup { get; set; }

        [NameInMap("path_status")]
        [Validation(Required=false)]
        public string PathStatus { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public Dictionary<string, IDPermission> Permission { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13700000000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("phone_region")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1567407718386</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccpuserid</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
