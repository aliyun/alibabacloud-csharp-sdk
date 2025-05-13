// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentNoteStruct : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("noteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public IncidentNoteStructOperator Operator { get; set; }
        public class IncidentNoteStructOperator : TeaModel {
            [NameInMap("contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
