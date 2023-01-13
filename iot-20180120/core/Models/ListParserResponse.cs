// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListParserResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListParserResponseData Data { get; set; }
        public class ListParserResponseData : TeaModel {
            [NameInMap("ParserList")]
            [Validation(Required=true)]
            public List<ListParserResponseDataParserList> ParserList { get; set; }
            public class ListParserResponseDataParserList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("ParserId")]
                [Validation(Required=true)]
                public long? ParserId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("UtcCreated")]
                [Validation(Required=true)]
                public string UtcCreated { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

            }

        }

    }

}
