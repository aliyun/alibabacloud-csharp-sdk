// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateUserGroupRequest : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<CreateUserGroupRequestAttributes> Attributes { get; set; }
        public class CreateUserGroupRequestAttributes : TeaModel {
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
