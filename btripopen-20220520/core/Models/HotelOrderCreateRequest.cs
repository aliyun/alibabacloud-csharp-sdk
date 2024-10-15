// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCreateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19281772123</para>
        /// </summary>
        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("invoice_info")]
        [Validation(Required=false)]
        public HotelOrderCreateRequestInvoiceInfo InvoiceInfo { get; set; }
        public class HotelOrderCreateRequestInvoiceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_add")]
            [Validation(Required=false)]
            public string BuyerAdd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_bank_acc")]
            [Validation(Required=false)]
            public string BuyerBankAcc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_bank_add")]
            [Validation(Required=false)]
            public string BuyerBankAdd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0571-82321777</para>
            /// </summary>
            [NameInMap("buyer_phone")]
            [Validation(Required=false)]
            public string BuyerPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("buyer_tax_num")]
            [Validation(Required=false)]
            public string BuyerTaxNum { get; set; }

            [NameInMap("delivery_address")]
            [Validation(Required=false)]
            public string DeliveryAddress { get; set; }

            [NameInMap("delivery_area")]
            [Validation(Required=false)]
            public string DeliveryArea { get; set; }

            [NameInMap("delivery_city")]
            [Validation(Required=false)]
            public string DeliveryCity { get; set; }

            [NameInMap("delivery_province")]
            [Validation(Required=false)]
            public string DeliveryProvince { get; set; }

            [NameInMap("delivery_street")]
            [Validation(Required=false)]
            public string DeliveryStreet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("invoice_material")]
            [Validation(Required=false)]
            public int? InvoiceMaterial { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("invoice_type")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

            [NameInMap("receiver_name")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0571-82321777</para>
            /// </summary>
            [NameInMap("receiver_phone")]
            [Validation(Required=false)]
            public string ReceiverPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>671570615157</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb5e1abf33924b6c912bd6d80deec0eb-1</para>
        /// </summary>
        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public List<HotelOrderCreateRequestOccupantInfoList> OccupantInfoList { get; set; }
        public class HotelOrderCreateRequestOccupantInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>124231213</para>
            /// </summary>
            [NameInMap("card_no")]
            [Validation(Required=false)]
            public string CardNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("card_type")]
            [Validation(Required=false)]
            public int? CardType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("customer_type")]
            [Validation(Required=false)]
            public int? CustomerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123112</para>
            /// </summary>
            [NameInMap("department_id")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("department_name")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("employee_type")]
            [Validation(Required=false)]
            public int? EmployeeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>san</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhang</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18277123451</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("room_no")]
            [Validation(Required=false)]
            public int? RoomNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>87817182</para>
            /// </summary>
            [NameInMap("staff_no")]
            [Validation(Required=false)]
            public string StaffNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("person_pay_price")]
        [Validation(Required=false)]
        public long? PersonPayPrice { get; set; }

        [NameInMap("promotion_info")]
        [Validation(Required=false)]
        public HotelOrderCreateRequestPromotionInfo PromotionInfo { get; set; }
        public class HotelOrderCreateRequestPromotionInfo : TeaModel {
            [NameInMap("promotion_detail_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderCreateRequestPromotionInfoPromotionDetailInfoList> PromotionDetailInfoList { get; set; }
            public class HotelOrderCreateRequestPromotionInfoPromotionDetailInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("check_status")]
                [Validation(Required=false)]
                public bool? CheckStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("need_check")]
                [Validation(Required=false)]
                public bool? NeedCheck { get; set; }

                [NameInMap("promotion_code")]
                [Validation(Required=false)]
                public string PromotionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23778127</para>
                /// </summary>
                [NameInMap("promotion_id")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                [NameInMap("promotion_name")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public long? PromotionPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("promotion_type")]
                [Validation(Required=false)]
                public string PromotionType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("promotion_total_price")]
            [Validation(Required=false)]
            public long? PromotionTotalPrice { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1399417428510</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187211</para>
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2088441675613762</para>
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198781</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nonUltron_1673575241156_d91ea8ad16735752359161037bf6cf_c54d3768312a4b249b719f126377bf82</para>
        /// </summary>
        [NameInMap("validate_res_key")]
        [Validation(Required=false)]
        public string ValidateResKey { get; set; }

    }

}
