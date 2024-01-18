// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundDetailListResponseBodyData Data { get; set; }
        public class RefundDetailListResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<RefundDetailListResponseBodyDataList> List { get; set; }
            public class RefundDetailListResponseBodyDataList : TeaModel {
                [NameInMap("is_multi_refund")]
                [Validation(Required=false)]
                public bool? IsMultiRefund { get; set; }

                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                [NameInMap("refund_order_status")]
                [Validation(Required=false)]
                public int? RefundOrderStatus { get; set; }

                [NameInMap("related_refund_order_num")]
                [Validation(Required=false)]
                public string RelatedRefundOrderNum { get; set; }

                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                [NameInMap("utc_create_time")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

            [NameInMap("pagination")]
            [Validation(Required=false)]
            public RefundDetailListResponseBodyDataPagination Pagination { get; set; }
            public class RefundDetailListResponseBodyDataPagination : TeaModel {
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
