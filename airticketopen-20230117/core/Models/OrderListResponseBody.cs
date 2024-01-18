// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderListResponseBodyData Data { get; set; }
        public class OrderListResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<OrderListResponseBodyDataList> List { get; set; }
            public class OrderListResponseBodyDataList : TeaModel {
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public long? BookTime { get; set; }

                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                [NameInMap("out_order_num")]
                [Validation(Required=false)]
                public string OutOrderNum { get; set; }

                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<OrderListResponseBodyDataListPassengerList> PassengerList { get; set; }
                public class OrderListResponseBodyDataListPassengerList : TeaModel {
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderListResponseBodyDataListPassengerListCredential Credential { get; set; }
                    public class OrderListResponseBodyDataListPassengerListCredential : TeaModel {
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public string PayStatus { get; set; }

                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public double? PromotionPrice { get; set; }

                [NameInMap("real_pay_price")]
                [Validation(Required=false)]
                public double? RealPayPrice { get; set; }

                [NameInMap("session_nick")]
                [Validation(Required=false)]
                public string SessionNick { get; set; }

                [NameInMap("succeed_time")]
                [Validation(Required=false)]
                public long? SucceedTime { get; set; }

                [NameInMap("total_price")]
                [Validation(Required=false)]
                public double? TotalPrice { get; set; }

                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

            }

            [NameInMap("pagination")]
            [Validation(Required=false)]
            public OrderListResponseBodyDataPagination Pagination { get; set; }
            public class OrderListResponseBodyDataPagination : TeaModel {
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
