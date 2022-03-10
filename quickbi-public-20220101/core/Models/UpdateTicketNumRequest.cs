// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateTicketNumRequest : TeaModel {
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

    }

}
