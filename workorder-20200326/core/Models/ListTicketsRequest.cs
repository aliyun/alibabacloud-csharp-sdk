// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200326.Models
{
    public class ListTicketsRequest : TeaModel {
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("CreatedAfterTime")]
        [Validation(Required=false)]
        public long? CreatedAfterTime { get; set; }

        [NameInMap("CreatedBeforeTime")]
        [Validation(Required=false)]
        public long? CreatedBeforeTime { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TicketStatus")]
        [Validation(Required=false)]
        public string TicketStatus { get; set; }

        [NameInMap("PageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
