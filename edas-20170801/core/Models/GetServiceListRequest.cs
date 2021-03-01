// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListRequest : TeaModel {
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("searchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        [NameInMap("side")]
        [Validation(Required=false)]
        public string Side { get; set; }

    }

}
