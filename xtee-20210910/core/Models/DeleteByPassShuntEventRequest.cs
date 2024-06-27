// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DeleteByPassShuntEventRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("eventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
