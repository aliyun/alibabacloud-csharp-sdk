// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AccountFlowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AccountFlowListResponseBodyData Data { get; set; }
        public class AccountFlowListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<AccountFlowListResponseBodyDataList> List { get; set; }
            public class AccountFlowListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The available balance after the operation, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("after_available_amount")]
                [Validation(Required=false)]
                public double? AfterAvailableAmount { get; set; }

                /// <summary>
                /// <para>The available balance before the operation, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1950.5</para>
                /// </summary>
                [NameInMap("before_available_amount")]
                [Validation(Required=false)]
                public double? BeforeAvailableAmount { get; set; }

                /// <summary>
                /// <para>The change order number. This value is not empty if the flow is related to a ticket change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49880***971</para>
                /// </summary>
                [NameInMap("change_order_num")]
                [Validation(Required=false)]
                public long? ChangeOrderNum { get; set; }

                /// <summary>
                /// <para>The flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1627239841225842666</para>
                /// </summary>
                [NameInMap("flow_id")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1676799185000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1676966530000</para>
                /// </summary>
                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The operation amount, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>950.5</para>
                /// </summary>
                [NameInMap("op_amount")]
                [Validation(Required=false)]
                public double? OpAmount { get; set; }

                /// <summary>
                /// <para>The operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: payment</description></item>
                /// <item><description>2: refund</description></item>
                /// <item><description>3: top-up.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("op_type")]
                [Validation(Required=false)]
                public int? OpType { get; set; }

                /// <summary>
                /// <para>The original order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4988430***971</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>The order type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: original transaction</description></item>
                /// <item><description>1: change order payment</description></item>
                /// <item><description>2: refund.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order_type")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                /// <summary>
                /// <para>The external order number of the original order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4988430***971</para>
                /// </summary>
                [NameInMap("out_order_num")]
                [Validation(Required=false)]
                public string OutOrderNum { get; set; }

                /// <summary>
                /// <para>The refund order number. This value is not empty if the flow is related to a refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48430***971</para>
                /// </summary>
                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public AccountFlowListResponseBodyDataPagination Pagination { get; set; }
            public class AccountFlowListResponseBodyDataPagination : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of records per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>The total number of pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("total_page")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful HTTP requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
