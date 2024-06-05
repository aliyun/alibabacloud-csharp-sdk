// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// The URL of the profile picture.
        /// 
        /// If you specify the parameter in the HTTP URL format, the URL must start with http:// or https:// and can be up to 4 KB in size.
        /// 
        /// If you specify the parameter in the DATA URL format, the URL must start with data:// and be encoded in Base64. The URL can be up to 300 KB in size.
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// The description of the user. The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The information about the group.
        /// </summary>
        [NameInMap("group_info_list")]
        [Validation(Required=false)]
        public List<UpdateUserRequestGroupInfoList> GroupInfoList { get; set; }
        public class UpdateUserRequestGroupInfoList : TeaModel {
            /// <summary>
            /// The group ID.
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// The nickname of the user. The nickname can be up to 128 characters in length.
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// The mobile number of the user.
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The role of the user. Valid values:
        /// 
        /// *   superadmin
        /// *   admin
        /// *   user
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The state of the user. Valid values:
        /// 
        /// *   disabled: The user is prohibited from logon.
        /// *   enabled: The user is in a normal state.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The custom data. The data can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserData { get; set; }

        /// <summary>
        /// The user ID. The ID can be up to 64 characters in length and cannot contain a number sign (#).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
