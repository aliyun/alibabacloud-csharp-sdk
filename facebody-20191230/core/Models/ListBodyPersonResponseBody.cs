// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListBodyPersonResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBodyPersonResponseBodyData Data { get; set; }
        public class ListBodyPersonResponseBodyData : TeaModel {
            [NameInMap("PersonList")]
            [Validation(Required=false)]
            public List<ListBodyPersonResponseBodyDataPersonList> PersonList { get; set; }
            public class ListBodyPersonResponseBodyDataPersonList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TraceCount")]
                [Validation(Required=false)]
                public long? TraceCount { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
