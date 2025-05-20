// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Role : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("isPredefined")]
        [Validation(Required=false)]
        public string IsPredefined { get; set; }

        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("rolePrincipal")]
        [Validation(Required=false)]
        public string RolePrincipal { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

        [NameInMap("users")]
        [Validation(Required=false)]
        public List<User> Users { get; set; }

    }

}
