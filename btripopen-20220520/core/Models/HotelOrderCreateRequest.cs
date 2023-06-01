// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCreateRequest : TeaModel {
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

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
            [NameInMap("buyer_add")]
            [Validation(Required=false)]
            public string BuyerAdd { get; set; }

            [NameInMap("buyer_bank_acc")]
            [Validation(Required=false)]
            public string BuyerBankAcc { get; set; }

            [NameInMap("buyer_bank_add")]
            [Validation(Required=false)]
            public string BuyerBankAdd { get; set; }

            [NameInMap("buyer_phone")]
            [Validation(Required=false)]
            public string BuyerPhone { get; set; }

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

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("invoice_material")]
            [Validation(Required=false)]
            public int? InvoiceMaterial { get; set; }

            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("invoice_type")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

            [NameInMap("receiver_name")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            [NameInMap("receiver_phone")]
            [Validation(Required=false)]
            public string ReceiverPhone { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public List<HotelOrderCreateRequestOccupantInfoList> OccupantInfoList { get; set; }
        public class HotelOrderCreateRequestOccupantInfoList : TeaModel {
            [NameInMap("card_no")]
            [Validation(Required=false)]
            public string CardNo { get; set; }

            [NameInMap("card_type")]
            [Validation(Required=false)]
            public int? CardType { get; set; }

            [NameInMap("customer_type")]
            [Validation(Required=false)]
            public int? CustomerType { get; set; }

            [NameInMap("department_id")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("department_name")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("employee_type")]
            [Validation(Required=false)]
            public int? EmployeeType { get; set; }

            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("staff_no")]
            [Validation(Required=false)]
            public string StaffNo { get; set; }

            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

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
                [NameInMap("check_status")]
                [Validation(Required=false)]
                public bool? CheckStatus { get; set; }

                [NameInMap("need_check")]
                [Validation(Required=false)]
                public bool? NeedCheck { get; set; }

                [NameInMap("promotion_code")]
                [Validation(Required=false)]
                public string PromotionCode { get; set; }

                [NameInMap("promotion_id")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                [NameInMap("promotion_name")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public long? PromotionPrice { get; set; }

                [NameInMap("promotion_type")]
                [Validation(Required=false)]
                public string PromotionType { get; set; }

            }

            [NameInMap("promotion_total_price")]
            [Validation(Required=false)]
            public long? PromotionTotalPrice { get; set; }

        }

        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        [NameInMap("validate_res_key")]
        [Validation(Required=false)]
        public string ValidateResKey { get; set; }

    }

}
