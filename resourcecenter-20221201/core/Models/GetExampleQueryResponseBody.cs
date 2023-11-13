// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetExampleQueryResponseBody : TeaModel {
        [NameInMap("ExampleQuery")]
        [Validation(Required=false)]
        public GetExampleQueryResponseBodyExampleQuery ExampleQuery { get; set; }
        public class GetExampleQueryResponseBodyExampleQuery : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
