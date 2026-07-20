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

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>costCenterCode123</para>
            /// </summary>
            [NameInMap("cost_center_code")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试成本中心</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY(人民币)</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("expense_city")]
                [Validation(Required=false)]
                public string ExpenseCity { get; set; }

                [NameInMap("expense_compositions")]
                [Validation(Required=false)]
                public List<QueryReimbursementOrderResponseBodyModuleExpensesExpenseCompositions> ExpenseCompositions { get; set; }
                public class QueryReimbursementOrderResponseBodyModuleExpensesExpenseCompositions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>账单id</para>
                    /// </summary>
                    [NameInMap("bill_settlement_id")]
                    [Validation(Required=false)]
                    public long? BillSettlementId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1:支出
                    /// 2:收入</para>
                    /// </summary>
                    [NameInMap("capital_direction")]
                    [Validation(Required=false)]
                    public string CapitalDirection { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6001</para>
                    /// </summary>
                    [NameInMap("fee_type")]
                    [Validation(Required=false)]
                    public string FeeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1002039194090156153</para>
                    /// </summary>
                    [NameInMap("order_id")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-06-11-2023-06-12</para>
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("remind_tag_list")]
                    [Validation(Required=false)]
                    public List<string> RemindTagList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>350</para>
                    /// </summary>
                    [NameInMap("settlement_amount")]
                    [Validation(Required=false)]
                    public string SettlementAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2021-10-08T22:27Z</para>
                    /// </summary>
                    [NameInMap("settlement_time")]
                    [Validation(Required=false)]
                    public string SettlementTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>火车</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>费用明细id</para>
                /// </summary>
                [NameInMap("reimb_expense_id")]
                [Validation(Required=false)]
                public long? ReimbExpenseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>结算方式；支付类型
                /// 枚举值：
                /// personal：个人支付
                /// enterprise：企业支付</para>
                /// </summary>
                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("expenses_cover_dept_id")]
            [Validation(Required=false)]
            public string ExpensesCoverDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门1</para>
            /// </summary>
            [NameInMap("expenses_cover_dept_name")]
            [Validation(Required=false)]
            public string ExpensesCoverDeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XXX公司</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>y/n，是/否</para>
            /// </summary>
            [NameInMap("is_deleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            [NameInMap("itineraries")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModuleItineraries> Itineraries { get; set; }
            public class QueryReimbursementOrderResponseBodyModuleItineraries : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>飞机</para>
                /// </summary>
                [NameInMap("traffic_way")]
                [Validation(Required=false)]
                public string TrafficWay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>单程/往返</para>
                /// </summary>
                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public string TripWay { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
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

                [NameInMap("cnaps_code")]
                [Validation(Required=false)]
                public string CnapsCode { get; set; }

                [NameInMap("payee_account_number")]
                [Validation(Required=false)]
                public string PayeeAccountNumber { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("process_end_time")]
            [Validation(Required=false)]
            public string ProcessEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>projectCode123</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XXX项目</para>
            /// </summary>
            [NameInMap("project_name")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>自愿申请</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>状态枚举值：
            /// wait_commit：待提交发票
            /// partial_payment：部分打款
            /// wait_payment：待打款
            /// reject：已驳回
            /// financing_recheck：财务复审
            /// commit：已提交
            /// wait_commit：待提交
            /// awaiting_approval：审批中
            /// complete_payment：已打款
            /// withdraw：已撤回</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>关联的出差审批单单号</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
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
