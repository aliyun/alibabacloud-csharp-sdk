// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class ListImageDbsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListImageDbsResponseBodyData Data { get; set; }
        public class ListImageDbsResponseBodyData : TeaModel {
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListImageDbsResponseBodyDataDbList> DbList { get; set; }
            public class ListImageDbsResponseBodyDataDbList : TeaModel {
                public string Name { get; set; }
            }
        };

    }

}
