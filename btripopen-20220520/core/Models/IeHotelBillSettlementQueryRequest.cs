// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeHotelBillSettlementQueryRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("period_end")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        [NameInMap("period_start")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

    }

}
