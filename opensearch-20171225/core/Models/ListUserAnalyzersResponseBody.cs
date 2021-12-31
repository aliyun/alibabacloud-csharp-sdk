// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListUserAnalyzersResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListUserAnalyzersResponseBodyResult> Result { get; set; }
        public class ListUserAnalyzersResponseBodyResult : TeaModel {
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            [NameInMap("business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            [NameInMap("dicts")]
            [Validation(Required=false)]
            public List<ListUserAnalyzersResponseBodyResultDicts> Dicts { get; set; }
            public class ListUserAnalyzersResponseBodyResultDicts : TeaModel {
                [NameInMap("available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("created")]
                [Validation(Required=false)]
                public int? Created { get; set; }

                [NameInMap("entriesCount")]
                [Validation(Required=false)]
                public int? EntriesCount { get; set; }

                [NameInMap("entriesLimit")]
                [Validation(Required=false)]
                public int? EntriesLimit { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("updated")]
                [Validation(Required=false)]
                public int? Updated { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
