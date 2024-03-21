// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskMessage")]
        [Validation(Required=false)]
        public string TaskMessage { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
