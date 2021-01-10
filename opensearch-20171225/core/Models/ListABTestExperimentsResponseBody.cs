// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListABTestExperimentsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListABTestExperimentsResponseBodyResult> Result { get; set; }
        public class ListABTestExperimentsResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            [NameInMap("params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }

            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
