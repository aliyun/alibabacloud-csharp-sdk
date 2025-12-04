// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class AsyncDraftValidateResult : TeaModel {
        [NameInMap("draftValidationDetail")]
        [Validation(Required=false)]
        public DraftValidationDetail DraftValidationDetail { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ticketStatus")]
        [Validation(Required=false)]
        public string TicketStatus { get; set; }

    }

}
