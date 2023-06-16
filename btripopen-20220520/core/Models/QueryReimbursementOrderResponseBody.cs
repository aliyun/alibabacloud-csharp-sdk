// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryReimbursementOrderResponseBody : TeaModel {
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
            [NameInMap("company_amount")]
            [Validation(Required=false)]
            public string CompanyAmount { get; set; }

            [NameInMap("company_pay_amount")]
            [Validation(Required=false)]
            public string CompanyPayAmount { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("expenses")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModuleExpenses> Expenses { get; set; }
            public class QueryReimbursementOrderResponseBodyModuleExpenses : TeaModel {
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

                    [NameInMap("fee_type")]
                    [Validation(Required=false)]
                    public string FeeType { get; set; }

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

                [NameInMap("expense_time")]
                [Validation(Required=false)]
                public string ExpenseTime { get; set; }

                [NameInMap("expense_type")]
                [Validation(Required=false)]
                public string ExpenseType { get; set; }

                [NameInMap("expense_type_code")]
                [Validation(Required=false)]
                public string ExpenseTypeCode { get; set; }

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

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("itineraries")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModuleItineraries> Itineraries { get; set; }
            public class QueryReimbursementOrderResponseBodyModuleItineraries : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

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

            [NameInMap("payment_infos")]
            [Validation(Required=false)]
            public List<QueryReimbursementOrderResponseBodyModulePaymentInfos> PaymentInfos { get; set; }
            public class QueryReimbursementOrderResponseBodyModulePaymentInfos : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("payee_user_id")]
                [Validation(Required=false)]
                public string PayeeUserId { get; set; }

            }

            [NameInMap("personal_amount")]
            [Validation(Required=false)]
            public string PersonalAmount { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

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

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
