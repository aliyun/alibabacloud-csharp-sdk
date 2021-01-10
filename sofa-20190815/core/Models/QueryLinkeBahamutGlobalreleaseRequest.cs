// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutGlobalreleaseRequest : TeaModel {
        [NameInMap("AoneReleaseId")]
        [Validation(Required=false)]
        public string AoneReleaseId { get; set; }

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

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

        [NameInMap("ParticipationType")]
        [Validation(Required=false)]
        public string ParticipationType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
