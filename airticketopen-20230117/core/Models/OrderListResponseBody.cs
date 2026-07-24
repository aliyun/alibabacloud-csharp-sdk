// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListResponseBody : TeaModel {
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
        public OrderListResponseBodyData Data { get; set; }
        public class OrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<OrderListResponseBodyDataList> List { get; set; }
            public class OrderListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The booking time (order creation time). The value is a 13-digit UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210784000</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public long? BookTime { get; set; }

                /// <summary>
                /// <para>The order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4966***617111</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>The order status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>2: order creation succeeded.</description></item>
                /// <item><description>3: order paid.</description></item>
                /// <item><description>4: order succeeded.</description></item>
                /// <item><description>5: order closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                /// <summary>
                /// <para>The external order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x091-2023-0220-j-0001</para>
                /// </summary>
                [NameInMap("out_order_num")]
                [Validation(Required=false)]
                public string OutOrderNum { get; set; }

                /// <summary>
                /// <para>The passenger list.</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<OrderListResponseBodyDataListPassengerList> PassengerList { get; set; }
                public class OrderListResponseBodyDataListPassengerList : TeaModel {
                    /// <summary>
                    /// <para>The date of birth in the yyyyMMdd format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>The credential information.</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderListResponseBodyDataListPassengerListCredential Credential { get; set; }
                    public class OrderListResponseBodyDataListPassengerListCredential : TeaModel {
                        /// <summary>
                        /// <para>The place of issue, represented as a two-letter code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>The credential number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>The credential type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: ID card.</description></item>
                        /// <item><description>1: passport.</description></item>
                        /// <item><description>2: student ID.</description></item>
                        /// <item><description>3: military ID.</description></item>
                        /// <item><description>4: Home Return Permit.</description></item>
                        /// <item><description>5: Taiwan Compatriot Permit.</description></item>
                        /// <item><description>6: Hong Kong and Macao Travel Permit.</description></item>
                        /// <item><description>7: international seafarer certificate.</description></item>
                        /// <item><description>8: Foreigner Permanent Residence Card.</description></item>
                        /// <item><description>10: police officer ID.</description></item>
                        /// <item><description>11: soldier ID.</description></item>
                        /// <item><description>12: Taiwan Travel Permit.</description></item>
                        /// <item><description>13: Taiwan Entry Permit.</description></item>
                        /// <item><description>14: household register.</description></item>
                        /// <item><description>15: birth certificate.</description></item>
                        /// <item><description>16: driver license.</description></item>
                        /// <item><description>17: Hong Kong and Macao Resident Residence Permit.</description></item>
                        /// <item><description>18: Taiwan Resident Residence Permit.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>The credential expiration date.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>The first name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>The gender. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: MALE.</description></item>
                    /// <item><description>1: FEMALE.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>The last name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>The country code of the mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>The mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The two-letter nationality code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>The passenger type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: adult.</description></item>
                    /// <item><description>1: child.</description></item>
                    /// <item><description>8: infant.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>The payment status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: initialized.</description></item>
                /// <item><description>1: creation succeeded.</description></item>
                /// <item><description>2: payment succeeded.</description></item>
                /// <item><description>4: transaction closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public string PayStatus { get; set; }

                /// <summary>
                /// <para>The payment time. The value is a 13-digit UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210788000</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                /// <summary>
                /// <para>The discount amount. Unit: yuan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public double? PromotionPrice { get; set; }

                /// <summary>
                /// <para>The actual payment amount. Unit: yuan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("real_pay_price")]
                [Validation(Required=false)]
                public double? RealPayPrice { get; set; }

                /// <summary>
                /// <para>The buyer nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nick</para>
                /// </summary>
                [NameInMap("session_nick")]
                [Validation(Required=false)]
                public string SessionNick { get; set; }

                /// <summary>
                /// <para>The ticketing time. The value is a 13-digit UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677210786000</para>
                /// </summary>
                [NameInMap("succeed_time")]
                [Validation(Required=false)]
                public long? SucceedTime { get; set; }

                /// <summary>
                /// <para>The total price of the order. Unit: yuan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public double? TotalPrice { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkduendkd-2023-dj0</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public OrderListResponseBodyDataPagination Pagination { get; set; }
            public class OrderListResponseBodyDataPagination : TeaModel {
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
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
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
