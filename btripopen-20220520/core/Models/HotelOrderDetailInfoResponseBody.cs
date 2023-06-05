// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderDetailInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderDetailInfoResponseBodyModule Module { get; set; }
        public class HotelOrderDetailInfoResponseBodyModule : TeaModel {
            [NameInMap("actual_check_in_time")]
            [Validation(Required=false)]
            public string ActualCheckInTime { get; set; }

            [NameInMap("actual_check_out_time")]
            [Validation(Required=false)]
            public string ActualCheckOutTime { get; set; }

            [NameInMap("btrip_hotel_cancel_policy_d_t_o")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTO BtripHotelCancelPolicyDTO { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTO : TeaModel {
                [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                [Validation(Required=false)]
                public List<HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                public class HotelOrderDetailInfoResponseBodyModuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList : TeaModel {
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("cancel_policy_type")]
                [Validation(Required=false)]
                public int? CancelPolicyType { get; set; }

            }

            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public string BtripOrderId { get; set; }

            [NameInMap("cancel_fine")]
            [Validation(Required=false)]
            public long? CancelFine { get; set; }

            [NameInMap("cancel_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleCancelInfo CancelInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleCancelInfo : TeaModel {
                [NameInMap("cancel_end_time")]
                [Validation(Required=false)]
                public string CancelEndTime { get; set; }

                [NameInMap("cancel_start_time")]
                [Validation(Required=false)]
                public string CancelStartTime { get; set; }

            }

            [NameInMap("check_in")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            [NameInMap("check_out")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            [NameInMap("confirm_order_time")]
            [Validation(Required=false)]
            public string ConfirmOrderTime { get; set; }

            [NameInMap("contract_name")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            [NameInMap("contract_tel")]
            [Validation(Required=false)]
            public string ContractTel { get; set; }

            [NameInMap("create_order_time")]
            [Validation(Required=false)]
            public string CreateOrderTime { get; set; }

            [NameInMap("early_arrival_time")]
            [Validation(Required=false)]
            public string EarlyArrivalTime { get; set; }

            [NameInMap("early_departure")]
            [Validation(Required=false)]
            public bool? EarlyDeparture { get; set; }

            [NameInMap("guest_count")]
            [Validation(Required=false)]
            public int? GuestCount { get; set; }

            [NameInMap("hotel_detail_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleHotelDetailInfo HotelDetailInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleHotelDetailInfo : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_tel")]
                [Validation(Required=false)]
                public string HotelTel { get; set; }

                [NameInMap("shid")]
                [Validation(Required=false)]
                public long? Shid { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public HotelOrderDetailInfoResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("billing_money")]
                [Validation(Required=false)]
                public long? BillingMoney { get; set; }

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

                [NameInMap("postage")]
                [Validation(Required=false)]
                public long? Postage { get; set; }

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
            public string ItemId { get; set; }

            [NameInMap("last_arrival_time")]
            [Validation(Required=false)]
            public string LastArrivalTime { get; set; }

            [NameInMap("occupant_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderDetailInfoResponseBodyModuleOccupantInfoList> OccupantInfoList { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleOccupantInfoList : TeaModel {
                [NameInMap("card_no")]
                [Validation(Required=false)]
                public string CardNo { get; set; }

                [NameInMap("card_type")]
                [Validation(Required=false)]
                public int? CardType { get; set; }

                [NameInMap("cost_center_info_list")]
                [Validation(Required=false)]
                public List<HotelOrderDetailInfoResponseBodyModuleOccupantInfoListCostCenterInfoList> CostCenterInfoList { get; set; }
                public class HotelOrderDetailInfoResponseBodyModuleOccupantInfoListCostCenterInfoList : TeaModel {
                    [NameInMap("cost_center_id")]
                    [Validation(Required=false)]
                    public string CostCenterId { get; set; }

                    [NameInMap("cost_center_name")]
                    [Validation(Required=false)]
                    public string CostCenterName { get; set; }

                    [NameInMap("cost_center_no")]
                    [Validation(Required=false)]
                    public string CostCenterNo { get; set; }

                    [NameInMap("cost_center_prices")]
                    [Validation(Required=false)]
                    public long? CostCenterPrices { get; set; }

                    [NameInMap("cost_center_ratios")]
                    [Validation(Required=false)]
                    public long? CostCenterRatios { get; set; }

                    [NameInMap("cost_center_subject_code")]
                    [Validation(Required=false)]
                    public string CostCenterSubjectCode { get; set; }

                    [NameInMap("cost_center_subject_name")]
                    [Validation(Required=false)]
                    public string CostCenterSubjectName { get; set; }

                    [NameInMap("settle_subject_id")]
                    [Validation(Required=false)]
                    public string SettleSubjectId { get; set; }

                    [NameInMap("settle_subject_name")]
                    [Validation(Required=false)]
                    public string SettleSubjectName { get; set; }

                    [NameInMap("settle_subject_no")]
                    [Validation(Required=false)]
                    public string SettleSubjectNo { get; set; }

                }

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

                [NameInMap("is_booker")]
                [Validation(Required=false)]
                public bool? IsBooker { get; set; }

                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("room_no")]
                [Validation(Required=false)]
                public string RoomNo { get; set; }

                [NameInMap("selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

                [NameInMap("staff_no")]
                [Validation(Required=false)]
                public string StaffNo { get; set; }

                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("order_status_desc")]
            [Validation(Required=false)]
            public string OrderStatusDesc { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("product_type")]
            [Validation(Required=false)]
            public int? ProductType { get; set; }

            [NameInMap("purchase_order_id")]
            [Validation(Required=false)]
            public string PurchaseOrderId { get; set; }

            [NameInMap("refund_price")]
            [Validation(Required=false)]
            public long? RefundPrice { get; set; }

            [NameInMap("refund_reason")]
            [Validation(Required=false)]
            public string RefundReason { get; set; }

            [NameInMap("refund_service_fee")]
            [Validation(Required=false)]
            public long? RefundServiceFee { get; set; }

            [NameInMap("room_night_price_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderDetailInfoResponseBodyModuleRoomNightPriceInfoList> RoomNightPriceInfoList { get; set; }
            public class HotelOrderDetailInfoResponseBodyModuleRoomNightPriceInfoList : TeaModel {
                [NameInMap("board")]
                [Validation(Required=false)]
                public string Board { get; set; }

                [NameInMap("board_num")]
                [Validation(Required=false)]
                public int? BoardNum { get; set; }

                [NameInMap("check_in")]
                [Validation(Required=false)]
                public string CheckIn { get; set; }

                [NameInMap("rate_plan_id")]
                [Validation(Required=false)]
                public string RatePlanId { get; set; }

                [NameInMap("rate_plan_name")]
                [Validation(Required=false)]
                public string RatePlanName { get; set; }

                [NameInMap("room_id")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("room_name")]
                [Validation(Required=false)]
                public string RoomName { get; set; }

                [NameInMap("room_price")]
                [Validation(Required=false)]
                public long? RoomPrice { get; set; }

            }

            [NameInMap("room_number")]
            [Validation(Required=false)]
            public int? RoomNumber { get; set; }

            [NameInMap("room_type_name")]
            [Validation(Required=false)]
            public string RoomTypeName { get; set; }

            [NameInMap("seller_id")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

            [NameInMap("seller_name")]
            [Validation(Required=false)]
            public string SellerName { get; set; }

            [NameInMap("service_fee")]
            [Validation(Required=false)]
            public long? ServiceFee { get; set; }

            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public string SettleType { get; set; }

            [NameInMap("supplier_order_id")]
            [Validation(Required=false)]
            public string SupplierOrderId { get; set; }

            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
