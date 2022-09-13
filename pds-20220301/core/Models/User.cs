// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class User : TeaModel {
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

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

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserData { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
