// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListBodyDbsResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBodyDbsResponseBodyData Data { get; set; }
        public class ListBodyDbsResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long Total { get; set; }
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListBodyDbsResponseBodyDataDbList> DbList { get; set; }
            public class ListBodyDbsResponseBodyDataDbList : TeaModel {
                public long Id { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
