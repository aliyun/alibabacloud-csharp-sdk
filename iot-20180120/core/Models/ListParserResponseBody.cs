// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListParserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListParserResponseBodyData Data { get; set; }
        public class ListParserResponseBodyData : TeaModel {
            [NameInMap("ParserList")]
            [Validation(Required=false)]
            public List<ListParserResponseBodyDataParserList> ParserList { get; set; }
            public class ListParserResponseBodyDataParserList : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public long? ParserId { get; set; }
                public string Status { get; set; }
                public string UtcCreated { get; set; }
                public string UtcModified { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
