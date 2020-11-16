// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetConnectionTicketResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=true)]
        public string TaskStatus { get; set; }

        [NameInMap("Ticket")]
        [Validation(Required=true)]
        public string Ticket { get; set; }

    }

}
