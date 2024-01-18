// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailListOfBuyerResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeDetailListOfBuyerResponseBodyData Data { get; set; }
        public class ChangeDetailListOfBuyerResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ChangeDetailListOfBuyerResponseBodyDataList> List { get; set; }
            public class ChangeDetailListOfBuyerResponseBodyDataList : TeaModel {
                [NameInMap("change_order_num")]
                [Validation(Required=false)]
                public long? ChangeOrderNum { get; set; }

                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                [NameInMap("utc_create_time")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

            [NameInMap("pagination")]
            [Validation(Required=false)]
            public ChangeDetailListOfBuyerResponseBodyDataPagination Pagination { get; set; }
            public class ChangeDetailListOfBuyerResponseBodyDataPagination : TeaModel {
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("total_page")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
