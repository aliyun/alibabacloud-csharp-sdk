// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutAppcreateorimporttaskRequest : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("TenantExternalId")]
        [Validation(Required=false)]
        public string TenantExternalId { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
