// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListBodyPersonResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBodyPersonResponseBodyData Data { get; set; }
        public class ListBodyPersonResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("PersonList")]
            [Validation(Required=false)]
            public List<ListBodyPersonResponseBodyDataPersonList> PersonList { get; set; }
            public class ListBodyPersonResponseBodyDataPersonList : TeaModel {
                public long? InstanceId { get; set; }
                public long? DbId { get; set; }
                public string Name { get; set; }
                public long? TraceCount { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
