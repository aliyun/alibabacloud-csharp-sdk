/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200326.Models
{
    public class CloseTicketRequest : TeaModel {
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

    }

}
