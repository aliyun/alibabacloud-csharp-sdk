// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetOrganizationalUnitIdByExternalIdRequest : TeaModel {
        [NameInMap("organizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        [NameInMap("organizationalUnitSourceId")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceId { get; set; }

        [NameInMap("organizationalUnitSourceType")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceType { get; set; }

    }

}
