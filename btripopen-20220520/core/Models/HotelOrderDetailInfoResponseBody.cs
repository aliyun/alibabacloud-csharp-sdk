// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>succeed in handling request</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The module information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderDetailInfoResponseBodyModule Module { get; set; }
        public class HotelOrderDetailInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The actual check-in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-29</para>
            /// </summary>
            [NameInMap("actual_check_in_time")]
            [Validation(Required=false)]
            public string ActualCheckInTime { get; set; }

            /// <summary>
            /// <para>The actual check-out time (deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-29</para>
            /// </summary>
            [NameInMap("actual_check_out_time")]
            [Validation(Required=false)]
            public string ActualCheckOutTime { get; set; }

            /// <summary>
            /// <para>The cancellation policy.</para>
            /// </summary>
            [NameInMap("btrip_hotel_cancel_policy_d_t_o")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTO BtripHotelCancelPolicyDTO { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTO : TeaModel {
                /// <summary>
                /// <para>The detailed cancellation and modification units. An empty array is returned when no data is available.</para>
                /// </summary>
                [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                [Validation(Required=false)]
                public List<HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                public class HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList : TeaModel {
                    /// <summary>
                    /// <para>The number of hours before midnight on the check-in date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    /// <summary>
                    /// <para>The number of room nights or the monetary amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The cancellation policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1（取消类型见报价详情）</para>
                /// </summary>
                [NameInMap("cancel_policy_type")]
                [Validation(Required=false)]
                public int? CancelPolicyType { get; set; }

            }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public string BtripOrderId { get; set; }

            /// <summary>
            /// <para>The cancellation penalty. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("cancel_fine")]
            [Validation(Required=false)]
            public long? CancelFine { get; set; }

            /// <summary>
            /// <para>The cancellation information.</para>
            /// </summary>
            [NameInMap("cancel_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleCancelInfo CancelInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleCancelInfo : TeaModel {
                /// <summary>
                /// <para>The cancellation end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-29</para>
                /// </summary>
                [NameInMap("cancel_end_time")]
                [Validation(Required=false)]
                public string CancelEndTime { get; set; }

                /// <summary>
                /// <para>The cancellation start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-29</para>
                /// </summary>
                [NameInMap("cancel_start_time")]
                [Validation(Required=false)]
                public string CancelStartTime { get; set; }

            }

            /// <summary>
            /// <para>The check-in date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("check_in")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            /// <summary>
            /// <para>The check-out date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("check_out")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            /// <summary>
            /// <para>The order confirmation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("confirm_order_time")]
            [Validation(Required=false)]
            public string ConfirmOrderTime { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contract_name")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            /// <summary>
            /// <para>The contact mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("contract_tel")]
            [Validation(Required=false)]
            public string ContractTel { get; set; }

            /// <summary>
            /// <para>The order creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-21</para>
            /// </summary>
            [NameInMap("create_order_time")]
            [Validation(Required=false)]
            public string CreateOrderTime { get; set; }

            /// <summary>
            /// <para>The earliest arrival time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("early_arrival_time")]
            [Validation(Required=false)]
            public string EarlyArrivalTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the guest checked out early (deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("early_departure")]
            [Validation(Required=false)]
            public bool? EarlyDeparture { get; set; }

            /// <summary>
            /// <para>The number of guests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("guest_count")]
            [Validation(Required=false)]
            public int? GuestCount { get; set; }

            /// <summary>
            /// <para>The hotel information.</para>
            /// </summary>
            [NameInMap("hotel_detail_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleHotelDetailInfo HotelDetailInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleHotelDetailInfo : TeaModel {
                /// <summary>
                /// <para>The hotel address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市余杭区文一西路聚橙路阿里未来酒店菲住布渴</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>菲住布渴酒店（阿里未来酒店）</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The hotel phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-87217</para>
                /// </summary>
                [NameInMap("hotel_tel")]
                [Validation(Required=false)]
                public string HotelTel { get; set; }

                /// <summary>
                /// <para>The hotel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2198781</para>
                /// </summary>
                [NameInMap("shid")]
                [Validation(Required=false)]
                public long? Shid { get; set; }

            }

            [NameInMap("hotel_on_site_price_detail")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleHotelOnSitePriceDetail HotelOnSitePriceDetail { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleHotelOnSitePriceDetail : TeaModel {
                [NameInMap("total_on_site_price")]
                [Validation(Required=false)]
                public HotelOrderDetailInfoResponseBodyModuleHotelOnSitePriceDetailTotalOnSitePrice TotalOnSitePrice { get; set; }
                public class HotelOrderDetailInfoResponseBodyModuleHotelOnSitePriceDetailTotalOnSitePrice : TeaModel {
                    /// <summary>
                    /// <para>The customer currency for the pay-at-hotel amount. Defaults to CNY if not specified.</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The hotel local currency for the pay-at-hotel amount.</para>
                    /// </summary>
                    [NameInMap("foreign_currency")]
                    [Validation(Required=false)]
                    public string ForeignCurrency { get; set; }

                    /// <summary>
                    /// <para>The pay-at-hotel amount in the hotel local currency, in cents.</para>
                    /// </summary>
                    [NameInMap("foreign_price")]
                    [Validation(Required=false)]
                    public long? ForeignPrice { get; set; }

                    /// <summary>
                    /// <para>The pay-at-hotel amount in the customer currency, in cents.</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                }

            }

            /// <summary>
            /// <para>The order room information. This field is never empty.</para>
            /// </summary>
            [NameInMap("hotel_sale_order_room_infos")]
            [Validation(Required=false)]
            public List<HotelOrderDetailInfoResponseBodyModuleHotelSaleOrderRoomInfos> HotelSaleOrderRoomInfos { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleHotelSaleOrderRoomInfos : TeaModel {
                /// <summary>
                /// <para>The check-in date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715702400000</para>
                /// </summary>
                [NameInMap("checkin_date")]
                [Validation(Required=false)]
                public string CheckinDate { get; set; }

                /// <summary>
                /// <para>The planned check-out date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715702400000</para>
                /// </summary>
                [NameInMap("checkout_date")]
                [Validation(Required=false)]
                public string CheckoutDate { get; set; }

                /// <summary>
                /// <para>The penalty per room.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("penal_sum")]
                [Validation(Required=false)]
                public long? PenalSum { get; set; }

                /// <summary>
                /// <para>The actual check-out date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715702400000</para>
                /// </summary>
                [NameInMap("real_checkout_date")]
                [Validation(Required=false)]
                public string RealCheckoutDate { get; set; }

                /// <summary>
                /// <para>The refund status. This field is accurate only for early departure and negotiated refund scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public int? RefundStatus { get; set; }

                /// <summary>
                /// <para>The room sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_no")]
                [Validation(Required=false)]
                public int? RoomNo { get; set; }

                /// <summary>
                /// <para>The price per room.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("room_price")]
                [Validation(Required=false)]
                public long? RoomPrice { get; set; }

                /// <summary>
                /// <para>The refund amount per room.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("room_refund_price")]
                [Validation(Required=false)]
                public long? RoomRefundPrice { get; set; }

                /// <summary>
                /// <para>The user IDs of all travelers in this room. Multiple IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1_occupant_default_userId</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <para>The names of all travelers in this room. Multiple names are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <para>The billing amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("billing_money")]
                [Validation(Required=false)]
                public long? BillingMoney { get; set; }

                /// <summary>
                /// <para>The company address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市余杭区**街道</para>
                /// </summary>
                [NameInMap("buyer_add")]
                [Validation(Required=false)]
                public string BuyerAdd { get; set; }

                /// <summary>
                /// <para>The bank account number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234********1234</para>
                /// </summary>
                [NameInMap("buyer_bank_acc")]
                [Validation(Required=false)]
                public string BuyerBankAcc { get; set; }

                /// <summary>
                /// <para>The bank name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江**银行</para>
                /// </summary>
                [NameInMap("buyer_bank_add")]
                [Validation(Required=false)]
                public string BuyerBankAdd { get; set; }

                /// <summary>
                /// <para>The company phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-82321777</para>
                /// </summary>
                [NameInMap("buyer_phone")]
                [Validation(Required=false)]
                public string BuyerPhone { get; set; }

                /// <summary>
                /// <para>The tax identification number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("buyer_tax_num")]
                [Validation(Required=false)]
                public string BuyerTaxNum { get; set; }

                /// <summary>
                /// <para>The delivery address (required for paper invoices).</para>
                /// 
                /// <b>Example:</b>
                /// <para>**小区</para>
                /// </summary>
                [NameInMap("delivery_address")]
                [Validation(Required=false)]
                public string DeliveryAddress { get; set; }

                /// <summary>
                /// <para>The delivery district. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拱墅</para>
                /// </summary>
                [NameInMap("delivery_area")]
                [Validation(Required=false)]
                public string DeliveryArea { get; set; }

                /// <summary>
                /// <para>The delivery city. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("delivery_city")]
                [Validation(Required=false)]
                public string DeliveryCity { get; set; }

                /// <summary>
                /// <para>The delivery province. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江</para>
                /// </summary>
                [NameInMap("delivery_province")]
                [Validation(Required=false)]
                public string DeliveryProvince { get; set; }

                /// <summary>
                /// <para>The delivery street. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***街道</para>
                /// </summary>
                [NameInMap("delivery_street")]
                [Validation(Required=false)]
                public string DeliveryStreet { get; set; }

                /// <summary>
                /// <para>The email address. Required for electronic invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j*********@example.com</para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The invoice material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_material")]
                [Validation(Required=false)]
                public int? InvoiceMaterial { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市****发展有限公司</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The invoice type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>The postage fee, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("postage")]
                [Validation(Required=false)]
                public long? Postage { get; set; }

                /// <summary>
                /// <para>The recipient name. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("receiver_name")]
                [Validation(Required=false)]
                public string ReceiverName { get; set; }

                /// <summary>
                /// <para>The recipient phone number. Required for paper invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-82****88</para>
                /// </summary>
                [NameInMap("receiver_phone")]
                [Validation(Required=false)]
                public string ReceiverPhone { get; set; }

                /// <summary>
                /// <para>The invoice remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tmf closeCloneTask</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1289918</para>
            /// </summary>
            [NameInMap("item_id")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The latest arrival time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("last_arrival_time")]
            [Validation(Required=false)]
            public string LastArrivalTime { get; set; }

            /// <summary>
            /// <para>The guest information. This field is never empty.</para>
            /// </summary>
            [NameInMap("occupant_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderDetailInfoResponseBodyModuleOccupantInfoList> OccupantInfoList { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleOccupantInfoList : TeaModel {
                /// <summary>
                /// <para>The ID document number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110101********1234</para>
                /// </summary>
                [NameInMap("card_no")]
                [Validation(Required=false)]
                public string CardNo { get; set; }

                /// <summary>
                /// <para>The ID document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("card_type")]
                [Validation(Required=false)]
                public int? CardType { get; set; }

                /// <summary>
                /// <para>The cost center. This field is deprecated.</para>
                /// </summary>
                [NameInMap("cost_center_info_list")]
                [Validation(Required=false)]
                public List<HotelOrderDetailInfoResponseBodyModuleOccupantInfoListCostCenterInfoList> CostCenterInfoList { get; set; }
                public class HotelOrderDetailInfoResponseBodyModuleOccupantInfoListCostCenterInfoList : TeaModel {
                    /// <summary>
                    /// <para>The cost center ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    /// <summary>
                    /// <para>The cost center name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    /// <summary>
                    /// <para>The cost center number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_no")]
                    [Validation(Required=false)]
                    public string CostCenterNo { get; set; }

                    /// <summary>
                    /// <para>The allocation amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_prices")]
                    [Validation(Required=false)]
                    public long? CostCenterPrices { get; set; }

                    /// <summary>
                    /// <para>The allocation ratio (%). A value of 100 indicates 100%.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_ratios")]
                    [Validation(Required=false)]
                    public long? CostCenterRatios { get; set; }

                    /// <summary>
                    /// <para>The expense category code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_subject_code")]
                    [Validation(Required=false)]
                    public string CostCenterSubjectCode { get; set; }

                    /// <summary>
                    /// <para>The expense category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("cost_center_subject_name")]
                    [Validation(Required=false)]
                    public string CostCenterSubjectName { get; set; }

                    /// <summary>
                    /// <para>The accounting entity ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("settle_subject_id")]
                    [Validation(Required=false)]
                    public string SettleSubjectId { get; set; }

                    /// <summary>
                    /// <para>The accounting entity name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("settle_subject_name")]
                    [Validation(Required=false)]
                    public string SettleSubjectName { get; set; }

                    /// <summary>
                    /// <para>The accounting entity number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("settle_subject_no")]
                    [Validation(Required=false)]
                    public string SettleSubjectNo { get; set; }

                }

                /// <summary>
                /// <para>The guest type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("customer_type")]
                [Validation(Required=false)]
                public int? CustomerType { get; set; }

                /// <summary>
                /// <para>The department ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123112</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The department name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("department_name")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// <para>The guest email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j*********@example.com</para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The employee type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("employee_type")]
                [Validation(Required=false)]
                public int? EmployeeType { get; set; }

                /// <summary>
                /// <para>The first name in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                /// <summary>
                /// <para>Indicates whether the guest is the booker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_booker")]
                [Validation(Required=false)]
                public bool? IsBooker { get; set; }

                /// <summary>
                /// <para>The last name in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhang</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// <para>The guest name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The guest mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****8888</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The room sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>从1开始,根据诉求依次向下排序(如果多间预定该字段表示哪些人住哪些房间)</para>
                /// </summary>
                [NameInMap("room_no")]
                [Validation(Required=false)]
                public int? RoomNo { get; set; }

                /// <summary>
                /// <para>Specifies whether to receive SMS notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12817218</para>
                /// </summary>
                [NameInMap("staff_no")]
                [Validation(Required=false)]
                public string StaffNo { get; set; }

                /// <summary>
                /// <para>The user type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The order status.</para>
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
            /// <para>The external confirmation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A3NAW9</para>
            /// </summary>
            [NameInMap("out_confirm_code")]
            [Validation(Required=false)]
            public string OutConfirmCode { get; set; }

            /// <summary>
            /// <para>The payment time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("product_type")]
            [Validation(Required=false)]
            public int? ProductType { get; set; }

            /// <summary>
            /// <para>The business travel purchase order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100328718728171</para>
            /// </summary>
            [NameInMap("purchase_order_id")]
            [Validation(Required=false)]
            public string PurchaseOrderId { get; set; }

            /// <summary>
            /// <para>The refundable amount. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_price")]
            [Validation(Required=false)]
            public long? RefundPrice { get; set; }

            /// <summary>
            /// <para>The refund reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            /// <summary>
            /// <para>The cancellation service fee, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_service_fee")]
            [Validation(Required=false)]
            public long? RefundServiceFee { get; set; }

            /// <summary>
            /// <para>The room night price information. This field is never empty.</para>
            /// </summary>
            [NameInMap("room_night_price_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderDetailInfoResponseBodyModuleRoomNightPriceInfoList> RoomNightPriceInfoList { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleRoomNightPriceInfoList : TeaModel {
                /// <summary>
                /// <para>The meal plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>含双早</para>
                /// </summary>
                [NameInMap("board")]
                [Validation(Required=false)]
                public string Board { get; set; }

                /// <summary>
                /// <para>The number of breakfasts included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("board_num")]
                [Validation(Required=false)]
                public int? BoardNum { get; set; }

                /// <summary>
                /// <para>The check-in date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677600000000</para>
                /// </summary>
                [NameInMap("check_in")]
                [Validation(Required=false)]
                public string CheckIn { get; set; }

                /// <summary>
                /// <para>The rate plan ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1399417428510</para>
                /// </summary>
                [NameInMap("rate_plan_id")]
                [Validation(Required=false)]
                public string RatePlanId { get; set; }

                /// <summary>
                /// <para>The rate plan name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里员工价-含双早</para>
                /// </summary>
                [NameInMap("rate_plan_name")]
                [Validation(Required=false)]
                public string RatePlanName { get; set; }

                /// <summary>
                /// <para>The room type ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>545993154510</para>
                /// </summary>
                [NameInMap("room_id")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                /// <summary>
                /// <para>The room type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高级房(HDS)-阿里员工价含双早</para>
                /// </summary>
                [NameInMap("room_name")]
                [Validation(Required=false)]
                public string RoomName { get; set; }

                /// <summary>
                /// <para>The room price. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("room_price")]
                [Validation(Required=false)]
                public long? RoomPrice { get; set; }

            }

            /// <summary>
            /// <para>The number of rooms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("room_number")]
            [Validation(Required=false)]
            public int? RoomNumber { get; set; }

            /// <summary>
            /// <para>The room type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>大床房</para>
            /// </summary>
            [NameInMap("room_type_name")]
            [Validation(Required=false)]
            public string RoomTypeName { get; set; }

            /// <summary>
            /// <para>The seller ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2088441675613762</para>
            /// </summary>
            [NameInMap("seller_id")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

            /// <summary>
            /// <para>The seller name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>taobao</para>
            /// </summary>
            [NameInMap("seller_name")]
            [Validation(Required=false)]
            public string SellerName { get; set; }

            /// <summary>
            /// <para>The service fee. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("service_fee")]
            [Validation(Required=false)]
            public long? ServiceFee { get; set; }

            /// <summary>
            /// <para>The payment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public string SettleType { get; set; }

            /// <summary>
            /// <para>The distributor hotel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("supplier_order_id")]
            [Validation(Required=false)]
            public string SupplierOrderId { get; set; }

            /// <summary>
            /// <para>The total order price. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
