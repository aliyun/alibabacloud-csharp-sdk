// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutArchdomaininterationsRequest : TeaModel {
        [NameInMap("ArchDomainExternalId")]
        [Validation(Required=false)]
        public string ArchDomainExternalId { get; set; }

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("Finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
