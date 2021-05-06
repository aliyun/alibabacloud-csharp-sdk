// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListAppInfosRequest : TeaModel {
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ListAppInfosRequestRequestParams RequestParams { get; set; }
        public class ListAppInfosRequestRequestParams : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
        };

    }

}
