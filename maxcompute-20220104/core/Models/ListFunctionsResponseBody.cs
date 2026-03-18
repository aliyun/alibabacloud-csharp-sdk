// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListFunctionsResponseBodyData Data { get; set; }
        public class ListFunctionsResponseBodyData : TeaModel {
            [NameInMap("functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyDataFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyDataFunctions : TeaModel {
                [NameInMap("class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
