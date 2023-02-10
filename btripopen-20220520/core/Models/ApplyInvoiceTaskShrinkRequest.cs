// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyInvoiceTaskShrinkRequest : TeaModel {
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        [NameInMap("invoice_task_list")]
        [Validation(Required=false)]
        public string InvoiceTaskListShrink { get; set; }

    }

}
