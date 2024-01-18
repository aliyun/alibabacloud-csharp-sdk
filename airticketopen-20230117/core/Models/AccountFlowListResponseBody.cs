// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AccountFlowListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AccountFlowListResponseBodyData Data { get; set; }
        public class AccountFlowListResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<AccountFlowListResponseBodyDataList> List { get; set; }
            public class AccountFlowListResponseBodyDataList : TeaModel {
                [NameInMap("after_available_amount")]
                [Validation(Required=false)]
                public double? AfterAvailableAmount { get; set; }

                [NameInMap("before_available_amount")]
                [Validation(Required=false)]
                public double? BeforeAvailableAmount { get; set; }

                [NameInMap("change_order_num")]
                [Validation(Required=false)]
                public long? ChangeOrderNum { get; set; }

                [NameInMap("flow_id")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("op_amount")]
                [Validation(Required=false)]
                public double? OpAmount { get; set; }

                [NameInMap("op_type")]
                [Validation(Required=false)]
                public int? OpType { get; set; }

                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                [NameInMap("out_order_num")]
                [Validation(Required=false)]
                public string OutOrderNum { get; set; }

                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

            }

            [NameInMap("pagination")]
            [Validation(Required=false)]
            public AccountFlowListResponseBodyDataPagination Pagination { get; set; }
            public class AccountFlowListResponseBodyDataPagination : TeaModel {
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
