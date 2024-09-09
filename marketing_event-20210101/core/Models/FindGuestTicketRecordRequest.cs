// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class FindGuestTicketRecordRequest : TeaModel {
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("DateTimeString")]
        [Validation(Required=false)]
        public string DateTimeString { get; set; }

        [NameInMap("EndDateTime")]
        [Validation(Required=false)]
        public string EndDateTime { get; set; }

        [NameInMap("StartDateTime")]
        [Validation(Required=false)]
        public string StartDateTime { get; set; }

    }

}
