// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListResponseBody : TeaModel {
        /// <summary>
        /// <para>request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderListResponseBodyData Data { get; set; }
        public class OrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>order list</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<OrderListResponseBodyDataList> List { get; set; }
            public class OrderListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>book time(timestamp)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210784000</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public long? BookTime { get; set; }

                /// <summary>
                /// <para>order number created by book</para>
                /// 
                /// <b>Example:</b>
                /// <para>4966***617111</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>order status</para>
                /// <para>1: order reservation in process</para>
                /// <para>2: order reservation successful</para>
                /// <para>3: order paid</para>
                /// <para>4: order successful</para>
                /// <para>5: order closed</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                /// <summary>
                /// <para>external order number(customized by buyer when book)</para>
                /// 
                /// <b>Example:</b>
                /// <para>x091-2023-0220-j-0001</para>
                /// </summary>
                [NameInMap("out_order_num")]
                [Validation(Required=false)]
                public string OutOrderNum { get; set; }

                /// <summary>
                /// <para>the information about all passenger of current order</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<OrderListResponseBodyDataListPassengerList> PassengerList { get; set; }
                public class OrderListResponseBodyDataListPassengerList : TeaModel {
                    /// <summary>
                    /// <para>date of birth (yyyyMMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>credential</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderListResponseBodyDataListPassengerListCredential Credential { get; set; }
                    public class OrderListResponseBodyDataListPassengerListCredential : TeaModel {
                        /// <summary>
                        /// <para>issuing place (two-letter code)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>credential number</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>credential type , only support &quot;1&quot;(1 means passport) currently.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>credential expiration date</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>gender 0: MALE; 1: FEMALE</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>last name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>mobile country code</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>mobile phone number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>nationality (two-letter code)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>passenger type 0: adult; 1: child; 8: infant</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>payment status</para>
                /// <para>1: payment in process</para>
                /// <para>2: deduction successful</para>
                /// <para>3: paid to the seller</para>
                /// <para>4: transaction closed</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public string PayStatus { get; set; }

                /// <summary>
                /// <para>pay time(timestamp)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210788000</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                /// <summary>
                /// <para>discount amount</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public double? PromotionPrice { get; set; }

                /// <summary>
                /// <para>actual payment amount</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("real_pay_price")]
                [Validation(Required=false)]
                public double? RealPayPrice { get; set; }

                /// <summary>
                /// <para>buyer nickname</para>
                /// 
                /// <b>Example:</b>
                /// <para>nick</para>
                /// </summary>
                [NameInMap("session_nick")]
                [Validation(Required=false)]
                public string SessionNick { get; set; }

                /// <summary>
                /// <para>order success time(timestamp)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210786000</para>
                /// </summary>
                [NameInMap("succeed_time")]
                [Validation(Required=false)]
                public long? SucceedTime { get; set; }

                /// <summary>
                /// <para>total price of current order</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public double? TotalPrice { get; set; }

                /// <summary>
                /// <para>transaction number</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkduendkd-2023-dj0</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

            }

            /// <summary>
            /// <para>information of pagination</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public OrderListResponseBodyDataPagination Pagination { get; set; }
            public class OrderListResponseBodyDataPagination : TeaModel {
                /// <summary>
                /// <para>current page index</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>page size</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>the number of total orders</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>the number of total pages</para>
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
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error data</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http reqeust has been processed successfully，status code is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
