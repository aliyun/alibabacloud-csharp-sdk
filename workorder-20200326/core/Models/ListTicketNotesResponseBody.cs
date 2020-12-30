// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200326.Models
{
    public class ListTicketNotesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTicketNotesResponseBodyData Data { get; set; }
        public class ListTicketNotesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTicketNotesResponseBodyDataList> List { get; set; }
            public class ListTicketNotesResponseBodyDataList : TeaModel {
                public int? GmtCreated { get; set; }
                public string NoteId { get; set; }
                public bool? FromOfficial { get; set; }
                public string Content { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
