// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderInfoQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderInfoQueryResponseBodyModule Module { get; set; }
        public class HotelOrderInfoQueryResponseBodyModule : TeaModel {
            [NameInMap("base_order_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleBaseOrderInfo BaseOrderInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleBaseOrderInfo : TeaModel {
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                [NameInMap("btrip_corp_id")]
                [Validation(Required=false)]
                public string BtripCorpId { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public long? CheckInTime { get; set; }

                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public long? CheckOutTime { get; set; }

                [NameInMap("is_agreement_price")]
                [Validation(Required=false)]
                public bool? IsAgreementPrice { get; set; }

                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                [NameInMap("order_create_time")]
                [Validation(Required=false)]
                public long? OrderCreateTime { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                [NameInMap("room_num")]
                [Validation(Required=false)]
                public int? RoomNum { get; set; }

                [NameInMap("settle_type")]
                [Validation(Required=false)]
                public int? SettleType { get; set; }

                [NameInMap("trip_mode")]
                [Validation(Required=false)]
                public int? TripMode { get; set; }

            }

            [NameInMap("booker_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleBookerInfo BookerInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleBookerInfo : TeaModel {
                [NameInMap("booker_role")]
                [Validation(Required=false)]
                public string BookerRole { get; set; }

                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public HotelOrderInfoQueryResponseBodyModuleBookerInfoDepartment Department { get; set; }
                public class HotelOrderInfoQueryResponseBodyModuleBookerInfoDepartment : TeaModel {
                    [NameInMap("cascade_dept_mask")]
                    [Validation(Required=false)]
                    public string CascadeDeptMask { get; set; }

                    [NameInMap("cascade_dept_name")]
                    [Validation(Required=false)]
                    public string CascadeDeptName { get; set; }

                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                    [NameInMap("out_depart_id")]
                    [Validation(Required=false)]
                    public string OutDepartId { get; set; }

                }

                [NameInMap("en_name")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("need_apply")]
                [Validation(Required=false)]
                public bool? NeedApply { get; set; }

                [NameInMap("real_name")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("hotel_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleHotelInfo HotelInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelInfo : TeaModel {
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("country_name")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                [NameInMap("district_code")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("district_name")]
                [Validation(Required=false)]
                public string DistrictName { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("hotel_brand_code")]
                [Validation(Required=false)]
                public string HotelBrandCode { get; set; }

                [NameInMap("hotel_brand_name")]
                [Validation(Required=false)]
                public string HotelBrandName { get; set; }

                [NameInMap("hotel_group")]
                [Validation(Required=false)]
                public string HotelGroup { get; set; }

                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_name_en")]
                [Validation(Required=false)]
                public string HotelNameEn { get; set; }

                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

            }

            [NameInMap("hotel_order_fee_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleHotelOrderFeeInfo HotelOrderFeeInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelOrderFeeInfo : TeaModel {
                [NameInMap("order_amount")]
                [Validation(Required=false)]
                public long? OrderAmount { get; set; }

                [NameInMap("other_fee")]
                [Validation(Required=false)]
                public long? OtherFee { get; set; }

                [NameInMap("pay_amount")]
                [Validation(Required=false)]
                public long? PayAmount { get; set; }

                [NameInMap("promotion_amount")]
                [Validation(Required=false)]
                public long? PromotionAmount { get; set; }

                [NameInMap("total_room_amount")]
                [Validation(Required=false)]
                public long? TotalRoomAmount { get; set; }

            }

            [NameInMap("hotel_order_refund_info")]
            [Validation(Required=false)]
            public List<HotelOrderInfoQueryResponseBodyModuleHotelOrderRefundInfo> HotelOrderRefundInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelOrderRefundInfo : TeaModel {
                [NameInMap("cancel_fine")]
                [Validation(Required=false)]
                public long? CancelFine { get; set; }

                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public long? RefundApplyId { get; set; }

                [NameInMap("refund_end_time")]
                [Validation(Required=false)]
                public long? RefundEndTime { get; set; }

                [NameInMap("refund_price")]
                [Validation(Required=false)]
                public long? RefundPrice { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                [NameInMap("refund_start_time")]
                [Validation(Required=false)]
                public long? RefundStartTime { get; set; }

                [NameInMap("refund_type")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

            }

            [NameInMap("room_traver_info")]
            [Validation(Required=false)]
            public List<HotelOrderInfoQueryResponseBodyModuleRoomTraverInfo> RoomTraverInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfo : TeaModel {
                [NameInMap("live_room_no")]
                [Validation(Required=false)]
                public string LiveRoomNo { get; set; }

                [NameInMap("room_type_name")]
                [Validation(Required=false)]
                public string RoomTypeName { get; set; }

                [NameInMap("traver_infos")]
                [Validation(Required=false)]
                public List<HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfos> TraverInfos { get; set; }
                public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfos : TeaModel {
                    [NameInMap("apply_info")]
                    [Validation(Required=false)]
                    public HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosApplyInfo ApplyInfo { get; set; }
                    public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosApplyInfo : TeaModel {
                        [NameInMap("apply_business_id")]
                        [Validation(Required=false)]
                        public string ApplyBusinessId { get; set; }

                        [NameInMap("apply_business_name")]
                        [Validation(Required=false)]
                        public string ApplyBusinessName { get; set; }

                        [NameInMap("apply_id")]
                        [Validation(Required=false)]
                        public string ApplyId { get; set; }

                        [NameInMap("exceed_apply")]
                        [Validation(Required=false)]
                        public List<HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosApplyInfoExceedApply> ExceedApply { get; set; }
                        public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosApplyInfoExceedApply : TeaModel {
                            [NameInMap("exceed_reason")]
                            [Validation(Required=false)]
                            public string ExceedReason { get; set; }

                            [NameInMap("exceed_type")]
                            [Validation(Required=false)]
                            public int? ExceedType { get; set; }

                            [NameInMap("flow_no")]
                            [Validation(Required=false)]
                            public long? FlowNo { get; set; }

                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public long? Id { get; set; }

                        }

                        [NameInMap("itinerary_no")]
                        [Validation(Required=false)]
                        public string ItineraryNo { get; set; }

                    }

                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    [NameInMap("department")]
                    [Validation(Required=false)]
                    public HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosDepartment Department { get; set; }
                    public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosDepartment : TeaModel {
                        [NameInMap("cascade_dept_mask")]
                        [Validation(Required=false)]
                        public string CascadeDeptMask { get; set; }

                        [NameInMap("cascade_dept_name")]
                        [Validation(Required=false)]
                        public string CascadeDeptName { get; set; }

                        [NameInMap("depart_id")]
                        [Validation(Required=false)]
                        public string DepartId { get; set; }

                        [NameInMap("depart_name")]
                        [Validation(Required=false)]
                        public string DepartName { get; set; }

                        [NameInMap("out_depart_id")]
                        [Validation(Required=false)]
                        public string OutDepartId { get; set; }

                    }

                    [NameInMap("job_no")]
                    [Validation(Required=false)]
                    public string JobNo { get; set; }

                    [NameInMap("telephone")]
                    [Validation(Required=false)]
                    public string Telephone { get; set; }

                    [NameInMap("traveler_id")]
                    [Validation(Required=false)]
                    public string TravelerId { get; set; }

                    [NameInMap("traveler_name")]
                    [Validation(Required=false)]
                    public string TravelerName { get; set; }

                    [NameInMap("traveler_type")]
                    [Validation(Required=false)]
                    public int? TravelerType { get; set; }

                    [NameInMap("trip_cost_center")]
                    [Validation(Required=false)]
                    public HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosTripCostCenter TripCostCenter { get; set; }
                    public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosTripCostCenter : TeaModel {
                        [NameInMap("cost_center_code")]
                        [Validation(Required=false)]
                        public string CostCenterCode { get; set; }

                        [NameInMap("cost_center_id")]
                        [Validation(Required=false)]
                        public string CostCenterId { get; set; }

                        [NameInMap("cost_center_name")]
                        [Validation(Required=false)]
                        public string CostCenterName { get; set; }

                        [NameInMap("external_ext_field")]
                        [Validation(Required=false)]
                        public string ExternalExtField { get; set; }

                        [NameInMap("fee_type")]
                        [Validation(Required=false)]
                        public int? FeeType { get; set; }

                        [NameInMap("invoice_id")]
                        [Validation(Required=false)]
                        public long? InvoiceId { get; set; }

                        [NameInMap("invoice_title")]
                        [Validation(Required=false)]
                        public string InvoiceTitle { get; set; }

                        [NameInMap("project_code")]
                        [Validation(Required=false)]
                        public string ProjectCode { get; set; }

                        [NameInMap("project_title")]
                        [Validation(Required=false)]
                        public string ProjectTitle { get; set; }

                    }

                    [NameInMap("user_type")]
                    [Validation(Required=false)]
                    public int? UserType { get; set; }

                }

            }

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
