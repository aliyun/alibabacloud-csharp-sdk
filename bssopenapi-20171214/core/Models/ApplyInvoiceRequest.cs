// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ApplyInvoiceRequest : TeaModel {
        [NameInMap("InvoiceAmount")]
        [Validation(Required=false)]
        public long? InvoiceAmount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        [NameInMap("InvoicingType")]
        [Validation(Required=false)]
        public int? InvoicingType { get; set; }

        [NameInMap("ProcessWay")]
        [Validation(Required=false)]
        public int? ProcessWay { get; set; }

        [NameInMap("ApplyUserNick")]
        [Validation(Required=false)]
        public string ApplyUserNick { get; set; }

        [NameInMap("InvoiceByAmount")]
        [Validation(Required=false)]
        public bool? InvoiceByAmount { get; set; }

        [NameInMap("UserRemark")]
        [Validation(Required=false)]
        public string UserRemark { get; set; }

        [NameInMap("SelectedIds")]
        [Validation(Required=false)]
        public List<int?> SelectedIds { get; set; }

    }

}
