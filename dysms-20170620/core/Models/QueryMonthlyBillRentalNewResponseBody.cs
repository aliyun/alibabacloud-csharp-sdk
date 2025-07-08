// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryMonthlyBillRentalNewResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<QueryMonthlyBillRentalNewResponseBodyRecords> Records { get; set; }
        public class QueryMonthlyBillRentalNewResponseBodyRecords : TeaModel {
            [NameInMap("BillTime")]
            [Validation(Required=false)]
            public long? BillTime { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("OfferTime")]
            [Validation(Required=false)]
            public long? OfferTime { get; set; }

            [NameInMap("Rental")]
            [Validation(Required=false)]
            public string Rental { get; set; }

            [NameInMap("SubItemId")]
            [Validation(Required=false)]
            public string SubItemId { get; set; }

            [NameInMap("SubItemName")]
            [Validation(Required=false)]
            public string SubItemName { get; set; }

        }

        [NameInMap("RentalSum")]
        [Validation(Required=false)]
        public string RentalSum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
