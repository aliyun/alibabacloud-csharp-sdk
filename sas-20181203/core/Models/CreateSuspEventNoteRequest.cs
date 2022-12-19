// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSuspEventNoteRequest : TeaModel {
        /// <summary>
        /// The ID of the alert event to which you want to add remarks. You can call the [DescribeSuspEvents](~~251497~~) operation to query the IDs of alert events.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// The remarks that you want to add.
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

    }

}
