// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketNotesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketNotesResponseBodyData> Data { get; set; }
        public class ListTicketNotesResponseBodyData : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<ListTicketNotesResponseBodyDataAttachments> Attachments { get; set; }
            public class ListTicketNotesResponseBodyDataAttachments : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Dialog")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataDialog Dialog { get; set; }
            public class ListTicketNotesResponseBodyDataDialog : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            [NameInMap("DialogId")]
            [Validation(Required=false)]
            public long? DialogId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tip")]
            [Validation(Required=false)]
            public string Tip { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataUser User { get; set; }
            public class ListTicketNotesResponseBodyDataUser : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
