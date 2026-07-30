// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderListQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelOrderListQueryResponseBodyModule> Module { get; set; }
        public class HotelOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business travel approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22678</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>出差</para>
            /// </summary>
            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            /// <summary>
            /// <para>The category code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: domestic hotel.</description></item>
            /// <item><description>12: international or China Hong Kong, Macao, and Taiwan hotel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The check-in time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("check_in")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            /// <summary>
            /// <para>The check-out time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("check_out")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            /// <summary>
            /// <para>The city where the hotel is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The city ad code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("city_ad_code")]
            [Validation(Required=false)]
            public string CityAdCode { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商旅企业id</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里巴巴</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The cost center information.</para>
            /// </summary>
            [NameInMap("cost_center")]
            [Validation(Required=false)]
            public HotelOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class HotelOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                /// <summary>
                /// <para>The business travel enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅企业id</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The business travel cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14668</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-PNUY</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            /// <summary>
            /// <para>The country code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("country_code")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The country name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("country_name")]
            [Validation(Required=false)]
            public string CountryName { get; set; }

            /// <summary>
            /// <para>The department ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户所在部门id</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>淘宝</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The approval form extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扩展字段</para>
            /// </summary>
            [NameInMap("extend_field")]
            [Validation(Required=false)]
            public string ExtendField { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The guests. Multiple guests are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三,李四</para>
            /// </summary>
            [NameInMap("guest")]
            [Validation(Required=false)]
            public string Guest { get; set; }

            /// <summary>
            /// <para>The hotel name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>未来酒店</para>
            /// </summary>
            [NameInMap("hotel_name")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            /// <summary>
            /// <para>The hotel invoicing support type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>11: supports only VAT general invoices.</description></item>
            /// <item><description>12: supports both VAT special invoices and VAT general invoices.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("hotel_support_vat_invoice_type")]
            [Validation(Required=false)]
            public int? HotelSupportVatInvoiceType { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13764</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice")]
            [Validation(Required=false)]
            public HotelOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class HotelOrderListQueryResponseBodyModuleInvoice : TeaModel {
                /// <summary>
                /// <para>The business travel invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>133568</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: VAT general invoice.</description></item>
                /// <item><description>2: VAT special invoice.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The total number of nights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("night")]
            [Validation(Required=false)]
            public int? Night { get; set; }

            /// <summary>
            /// <para>The order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: pending payment.</description></item>
            /// <item><description>3: booking succeeded.</description></item>
            /// <item><description>4: refund pending confirmation.</description></item>
            /// <item><description>5: canceled (active refund).</description></item>
            /// <item><description>6: closed.</description></item>
            /// <item><description>8: pending confirmation.</description></item>
            /// <item><description>9: canceled (no room available).</description></item>
            /// <item><description>10: refund application rejected.</description></item>
            /// <item><description>11: transaction succeeded.</description></item>
            /// <item><description>-1: invisible.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The order status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>预订成功</para>
            /// </summary>
            [NameInMap("order_status_desc")]
            [Validation(Required=false)]
            public string OrderStatusDesc { get; set; }

            /// <summary>
            /// <para>The order type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: full payment.</description></item>
            /// <item><description>5: pay at hotel.</description></item>
            /// <item><description>6: credit stay.</description></item>
            /// <item><description>7: online reservation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_type")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            /// <summary>
            /// <para>The order type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>信用住</para>
            /// </summary>
            [NameInMap("order_type_desc")]
            [Validation(Required=false)]
            public string OrderTypeDesc { get; set; }

            /// <summary>
            /// <para>The price detail list.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class HotelOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The transaction category code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: hotel booking.</description></item>
                /// <item><description>2: hotel service fee.</description></item>
                /// <item><description>3: hotel insurance payment.</description></item>
                /// <item><description>99: hotel adjustment.</description></item>
                /// <item><description>101: hotel refund.</description></item>
                /// <item><description>102: hotel compensation.</description></item>
                /// <item><description>103: hotel insurance refund.</description></item>
                /// <item><description>110: reward points deduction.</description></item>
                /// <item><description>111: reward points refund.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The transaction category type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: flight.</description></item>
                /// <item><description>2: hotel.</description></item>
                /// <item><description>3: train.</description></item>
                /// <item><description>4: car service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <para>The transaction creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The guest information. Multiple guests are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三,李四</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The payment method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: personal payment.</description></item>
                /// <item><description>2: enterprise payment.</description></item>
                /// <item><description>4: enterprise monthly settlement.</description></item>
                /// <item><description>8: enterprise prepayment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs1546728</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <para>The fund flow direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: expenditure.</description></item>
                /// <item><description>2: income.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-PROJECTCODE</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13631</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试项目名称</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The number of rooms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("room_num")]
            [Validation(Required=false)]
            public int? RoomNum { get; set; }

            /// <summary>
            /// <para>The room type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标间</para>
            /// </summary>
            [NameInMap("room_type")]
            [Validation(Required=false)]
            public string RoomType { get; set; }

            /// <summary>
            /// <para>The service supplier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里商旅</para>
            /// </summary>
            [NameInMap("supplier")]
            [Validation(Required=false)]
            public string Supplier { get; set; }

            /// <summary>
            /// <para>The third-party application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-THIRDAPPLY</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <para>The external approval ID displayed to users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00021230711000001Test-2</para>
            /// </summary>
            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <para>The third-party itinerary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-ITINEARY</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <para>The third-party project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-THIRDPROJECT</para>
            /// </summary>
            [NameInMap("thirdpart_project_id")]
            [Validation(Required=false)]
            public string ThirdpartProjectId { get; set; }

            /// <summary>
            /// <para>The traveler information list.</para>
            /// </summary>
            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<HotelOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class HotelOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                /// <summary>
                /// <para>The guest ID (third-party user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>入住人ID（第三方用户Id）</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The guest name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第三方用户id</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public HotelOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class HotelOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
