// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AssignUsersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UserRamId")]
        [Validation(Required=false)]
        public List<string> UserRamId { get; set; }

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
