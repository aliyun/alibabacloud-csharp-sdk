// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateOrganizationalUnitRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("organizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        [NameInMap("organizationalUnitName")]
        [Validation(Required=false)]
        public string OrganizationalUnitName { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

    }

}
