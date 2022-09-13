// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateUserRequest : TeaModel {
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("group_info_list")]
        [Validation(Required=false)]
        public List<UpdateUserRequestGroupInfoList> GroupInfoList { get; set; }
        public class UpdateUserRequestGroupInfoList : TeaModel {
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserData { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
