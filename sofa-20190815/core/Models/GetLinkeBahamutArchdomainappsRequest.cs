// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutArchdomainappsRequest : TeaModel {
        [NameInMap("ArchDomainExternalId")]
        [Validation(Required=false)]
        public string ArchDomainExternalId { get; set; }

        [NameInMap("ArchDomainID")]
        [Validation(Required=false)]
        public string ArchDomainID { get; set; }

        [NameInMap("ArchDomainName")]
        [Validation(Required=false)]
        public string ArchDomainName { get; set; }

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ParentArchDomainName")]
        [Validation(Required=false)]
        public string ParentArchDomainName { get; set; }

        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public string UserAccount { get; set; }

    }

}
