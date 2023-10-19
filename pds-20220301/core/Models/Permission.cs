// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Permission : TeaModel {
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<PermissionActionList> ActionList { get; set; }
        public class PermissionActionList : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

        }

        [NameInMap("collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("condition")]
        [Validation(Required=false)]
        public PermissionCondition Condition { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<string> UserTags { get; set; }

    }

}
