// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateUserRequest : TeaModel {
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("PrivateOutboundNumberId")]
        [Validation(Required=false)]
        public string PrivateOutboundNumberId { get; set; }

        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public List<string> RoleId { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public List<string> SkillGroupId { get; set; }

        [NameInMap("SkillLevel")]
        [Validation(Required=false)]
        public List<int?> SkillLevel { get; set; }

    }

}
