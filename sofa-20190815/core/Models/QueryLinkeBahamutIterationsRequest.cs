// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationsRequest : TeaModel {
        [NameInMap("BahamutTenant")]
        [Validation(Required=false)]
        public string BahamutTenant { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
