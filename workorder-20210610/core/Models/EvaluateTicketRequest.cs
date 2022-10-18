// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class EvaluateTicketRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public string Score { get; set; }

        [NameInMap("Solved")]
        [Validation(Required=false)]
        public bool? Solved { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

    }

}
