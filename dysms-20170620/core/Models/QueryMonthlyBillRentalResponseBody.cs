// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryMonthlyBillRentalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMonthlyBillRentalResponseBodyData Data { get; set; }
        public class QueryMonthlyBillRentalResponseBodyData : TeaModel {
            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<QueryMonthlyBillRentalResponseBodyDataRecords> Records { get; set; }
            public class QueryMonthlyBillRentalResponseBodyDataRecords : TeaModel {
                [NameInMap("billTime")]
                [Validation(Required=false)]
                public long? BillTime { get; set; }

                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("offerTime")]
                [Validation(Required=false)]
                public long? OfferTime { get; set; }

                [NameInMap("rental")]
                [Validation(Required=false)]
                public string Rental { get; set; }

                [NameInMap("subItemId")]
                [Validation(Required=false)]
                public string SubItemId { get; set; }

                [NameInMap("subItemName")]
                [Validation(Required=false)]
                public string SubItemName { get; set; }

            }

            [NameInMap("rentalSum")]
            [Validation(Required=false)]
            public string RentalSum { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
