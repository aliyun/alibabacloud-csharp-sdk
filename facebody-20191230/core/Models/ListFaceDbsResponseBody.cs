// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListFaceDbsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFaceDbsResponseBodyData Data { get; set; }
        public class ListFaceDbsResponseBodyData : TeaModel {
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListFaceDbsResponseBodyDataDbList> DbList { get; set; }
            public class ListFaceDbsResponseBodyDataDbList : TeaModel {
                public string Name { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
