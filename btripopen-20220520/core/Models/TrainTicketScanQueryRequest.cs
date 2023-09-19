// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryRequest : TeaModel {
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        [NameInMap("bill_id")]
        [Validation(Required=false)]
        public long? BillId { get; set; }

        [NameInMap("invoice_sub_task_id")]
        [Validation(Required=false)]
        public long? InvoiceSubTaskId { get; set; }

        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("serial_number")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("ticket_no")]
        [Validation(Required=false)]
        public string TicketNo { get; set; }

    }

}
