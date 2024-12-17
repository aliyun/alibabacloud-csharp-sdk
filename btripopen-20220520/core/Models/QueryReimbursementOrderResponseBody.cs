// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryReimbursementOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public QueryReimbursementOrderResponseBodyModule Module { get; set; }
        public class QueryReimbursementOrderResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.00</para>
            /// </summary>
            [NameInMap("company_amount")]
            [Validation(Required=false)]
            public string CompanyAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("company_pay_amount")]
            [Validation(Required=false)]
            public string CompanyPayAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dinga809ed71b9201f35</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("cost_center_code")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            [NameInMap("expenses")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModuleExpenses> Expenses { get; set; }
            public class QueryReimbursementOrderResponseBodyModuleExpenses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("expense_city")]
                [Validation(Required=false)]
                public string ExpenseCity { get; set; }

                [NameInMap("expense_compositions")]
                [Validation(Required=false)]
                public List<QueryReimbursementOrderResponseBodyModuleExpensesExpenseCompositions> ExpenseCompositions { get; set; }
                public class QueryReimbursementOrderResponseBodyModuleExpensesExpenseCompositions : TeaModel {
                    [NameInMap("bill_settlement_id")]
                    [Validation(Required=false)]
                    public long? BillSettlementId { get; set; }

                    [NameInMap("capital_direction")]
                    [Validation(Required=false)]
                    public string CapitalDirection { get; set; }

                    [NameInMap("fee_type")]
                    [Validation(Required=false)]
                    public string FeeType { get; set; }

                    [NameInMap("order_id")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("remind_tag_list")]
                    [Validation(Required=false)]
                    public List<string> RemindTagList { get; set; }

                    [NameInMap("settlement_amount")]
                    [Validation(Required=false)]
                    public string SettlementAmount { get; set; }

                    [NameInMap("settlement_time")]
                    [Validation(Required=false)]
                    public string SettlementTime { get; set; }

                    [NameInMap("voucher_type")]
                    [Validation(Required=false)]
                    public int? VoucherType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("expense_time")]
                [Validation(Required=false)]
                public string ExpenseTime { get; set; }

                [NameInMap("expense_type")]
                [Validation(Required=false)]
                public string ExpenseType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("expense_type_code")]
                [Validation(Required=false)]
                public string ExpenseTypeCode { get; set; }

                [NameInMap("invoice_infos")]
                [Validation(Required=false)]
                public List<QueryReimbursementOrderResponseBodyModuleExpensesInvoiceInfos> InvoiceInfos { get; set; }
                public class QueryReimbursementOrderResponseBodyModuleExpensesInvoiceInfos : TeaModel {
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    [NameInMap("invoice_code")]
                    [Validation(Required=false)]
                    public string InvoiceCode { get; set; }

                    [NameInMap("invoice_data")]
                    [Validation(Required=false)]
                    public string InvoiceData { get; set; }

                    [NameInMap("invoice_date")]
                    [Validation(Required=false)]
                    public string InvoiceDate { get; set; }

                    [NameInMap("invoice_number")]
                    [Validation(Required=false)]
                    public string InvoiceNumber { get; set; }

                    [NameInMap("invoice_type")]
                    [Validation(Required=false)]
                    public string InvoiceType { get; set; }

                }

                [NameInMap("reimb_expense_id")]
                [Validation(Required=false)]
                public long? ReimbExpenseId { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

            }

            [NameInMap("expenses_cover_dept_id")]
            [Validation(Required=false)]
            public string ExpensesCoverDeptId { get; set; }

            [NameInMap("expenses_cover_dept_name")]
            [Validation(Required=false)]
            public string ExpensesCoverDeptName { get; set; }

            [NameInMap("expenses_cover_invoice_title")]
            [Validation(Required=false)]
            public string ExpensesCoverInvoiceTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("is_deleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            [NameInMap("itineraries")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModuleItineraries> Itineraries { get; set; }
            public class QueryReimbursementOrderResponseBodyModuleItineraries : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CTU</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("traffic_way")]
                [Validation(Required=false)]
                public string TrafficWay { get; set; }

                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public string TripWay { get; set; }

            }

            [NameInMap("payment_finish_time")]
            [Validation(Required=false)]
            public string PaymentFinishTime { get; set; }

            [NameInMap("payment_infos")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModulePaymentInfos> PaymentInfos { get; set; }
            public class QueryReimbursementOrderResponseBodyModulePaymentInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20.00</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("payee_user_id")]
                [Validation(Required=false)]
                public string PayeeUserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.00</para>
            /// </summary>
            [NameInMap("personal_amount")]
            [Validation(Required=false)]
            public string PersonalAmount { get; set; }

            [NameInMap("process_end_time")]
            [Validation(Required=false)]
            public string ProcessEndTime { get; set; }

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_name")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RT203956</para>
            /// </summary>
            [NameInMap("reimbursement_no")]
            [Validation(Required=false)]
            public string ReimbursementNo { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("travel_third_apply_id")]
            [Validation(Required=false)]
            public string TravelThirdApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
