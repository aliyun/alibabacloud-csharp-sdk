// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListPageRequest : TeaModel {
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("searchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("side")]
        [Validation(Required=false)]
        public string Side { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
