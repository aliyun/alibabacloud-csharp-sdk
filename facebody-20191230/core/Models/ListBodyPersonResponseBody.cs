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
                public long? DbId { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public long? TraceCount { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
