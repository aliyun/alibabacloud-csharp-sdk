// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeBahamutAllarchdomainsfromlinkmRequest : TeaModel {
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("NeedParentLinkcGroups")]
        [Validation(Required=false)]
        public string NeedParentLinkcGroups { get; set; }

        [NameInMap("TenantExternalId")]
        [Validation(Required=false)]
        public string TenantExternalId { get; set; }

    }

}
