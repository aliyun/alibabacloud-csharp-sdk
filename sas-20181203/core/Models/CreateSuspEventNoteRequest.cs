// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSuspEventNoteRequest : TeaModel {
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

    }

}
