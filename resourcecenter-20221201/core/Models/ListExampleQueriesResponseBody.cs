// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListExampleQueriesResponseBody : TeaModel {
        [NameInMap("ExampleQueries")]
        [Validation(Required=false)]
        public List<ListExampleQueriesResponseBodyExampleQueries> ExampleQueries { get; set; }
        public class ListExampleQueriesResponseBodyExampleQueries : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
