// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutArchdomainRequest : TeaModel {
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("TenantPath")]
        [Validation(Required=false)]
        public string TenantPath { get; set; }

    }

}
