// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ReceivedShare : TeaModel {
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("providerTenantId")]
        [Validation(Required=false)]
        public long? ProviderTenantId { get; set; }

        [NameInMap("shareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("shareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
