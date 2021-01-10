// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSortExpressionsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSortExpressionsResponseBodyResult> Result { get; set; }
        public class ListSortExpressionsResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
