// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderInfoQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1430378</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>btripkvxtn1321g49wtul</para>
                /// </summary>
                [NameInMap("btrip_corp_id")]
                [Validation(Required=false)]
                public string BtripCorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721145600000</para>
                /// </summary>
                [NameInMap("check_in_time")]
                [Validation(Required=false)]
                public long? CheckInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721145600000</para>
                /// </summary>
                [NameInMap("check_out_time")]
                [Validation(Required=false)]
                public long? CheckOutTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_agreement_price")]
                [Validation(Required=false)]
                public bool? IsAgreementPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("nights")]
                [Validation(Required=false)]
                public int? Nights { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721145600000</para>
                /// </summary>
                [NameInMap("order_create_time")]
                [Validation(Required=false)]
                public long? OrderCreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1012053198307958626</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721145600000</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("room_num")]
                [Validation(Required=false)]
                public int? RoomNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settle_type")]
                [Validation(Required=false)]
                public int? SettleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_mode")]
                [Validation(Required=false)]
                public int? TripMode { get; set; }

            }

            [NameInMap("booker_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleBookerInfo BookerInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleBookerInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>UN_APPLY</para>
                /// </summary>
                [NameInMap("booker_role")]
                [Validation(Required=false)]
                public string BookerRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:13311112222@qq.com">13311112222@qq.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13311112222</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>open12gddn2kn1i47v10wRJNkMFx00</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public HotelOrderInfoQueryResponseBodyModuleBookerInfoDepartment Department { get; set; }
                public class HotelOrderInfoQueryResponseBodyModuleBookerInfoDepartment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0rCUI20hjOsk0sTwlu</para>
                    /// </summary>
                    [NameInMap("cascade_dept_mask")]
                    [Validation(Required=false)]
                    public string CascadeDeptMask { get; set; }

                    [NameInMap("cascade_dept_name")]
                    [Validation(Required=false)]
                    public string CascadeDeptName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>35</para>
                    /// </summary>
                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>330000001815</para>
                    /// </summary>
                    [NameInMap("out_depart_id")]
                    [Validation(Required=false)]
                    public string OutDepartId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("en_name")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("need_apply")]
                [Validation(Required=false)]
                public bool? NeedApply { get; set; }

                [NameInMap("real_name")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1430378</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("hotel_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleHotelInfo HotelInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("country_name")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330183</para>
                /// </summary>
                [NameInMap("district_code")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("district_name")]
                [Validation(Required=false)]
                public string DistrictName { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("hotel_brand_code")]
                [Validation(Required=false)]
                public string HotelBrandCode { get; set; }

                [NameInMap("hotel_brand_name")]
                [Validation(Required=false)]
                public string HotelBrandName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>huazhu</para>
                /// </summary>
                [NameInMap("hotel_group")]
                [Validation(Required=false)]
                public string HotelGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>55335212</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Test Hotel Name</para>
                /// </summary>
                [NameInMap("hotel_name_en")]
                [Validation(Required=false)]
                public string HotelNameEn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

            }

            [NameInMap("hotel_order_fee_info")]
            [Validation(Required=false)]
            public HotelOrderInfoQueryResponseBodyModuleHotelOrderFeeInfo HotelOrderFeeInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelOrderFeeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>35000</para>
                /// </summary>
                [NameInMap("order_amount")]
                [Validation(Required=false)]
                public long? OrderAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("other_fee")]
                [Validation(Required=false)]
                public long? OtherFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>35000</para>
                /// </summary>
                [NameInMap("pay_amount")]
                [Validation(Required=false)]
                public long? PayAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("promotion_amount")]
                [Validation(Required=false)]
                public long? PromotionAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>35000</para>
                /// </summary>
                [NameInMap("total_room_amount")]
                [Validation(Required=false)]
                public long? TotalRoomAmount { get; set; }

            }

            [NameInMap("hotel_order_refund_info")]
            [Validation(Required=false)]
            public List<HotelOrderInfoQueryResponseBodyModuleHotelOrderRefundInfo> HotelOrderRefundInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleHotelOrderRefundInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("cancel_fine")]
                [Validation(Required=false)]
                public long? CancelFine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000002578096</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public long? RefundApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721702353700</para>
                /// </summary>
                [NameInMap("refund_end_time")]
                [Validation(Required=false)]
                public long? RefundEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34000</para>
                /// </summary>
                [NameInMap("refund_price")]
                [Validation(Required=false)]
                public long? RefundPrice { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721702353700</para>
                /// </summary>
                [NameInMap("refund_start_time")]
                [Validation(Required=false)]
                public long? RefundStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("refund_type")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

            }

            [NameInMap("room_traver_info")]
            [Validation(Required=false)]
            public List<HotelOrderInfoQueryResponseBodyModuleRoomTraverInfo> RoomTraverInfo { get; set; }
            public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1001</para>
                        /// </summary>
                        [NameInMap("apply_business_id")]
                        [Validation(Required=false)]
                        public string ApplyBusinessId { get; set; }

                        [NameInMap("apply_business_name")]
                        [Validation(Required=false)]
                        public string ApplyBusinessName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1424031910085891196</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("exceed_type")]
                            [Validation(Required=false)]
                            public int? ExceedType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3321</para>
                            /// </summary>
                            [NameInMap("flow_no")]
                            [Validation(Required=false)]
                            public long? FlowNo { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>60853</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public long? Id { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ef5e74dc1f1640b08858fb043f64e477-8</para>
                        /// </summary>
                        [NameInMap("itinerary_no")]
                        [Validation(Required=false)]
                        public string ItineraryNo { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>342229200801010023</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    [NameInMap("department")]
                    [Validation(Required=false)]
                    public HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosDepartment Department { get; set; }
                    public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosDepartment : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0rCUI20hjOsk0sTwlu</para>
                        /// </summary>
                        [NameInMap("cascade_dept_mask")]
                        [Validation(Required=false)]
                        public string CascadeDeptMask { get; set; }

                        [NameInMap("cascade_dept_name")]
                        [Validation(Required=false)]
                        public string CascadeDeptName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>35</para>
                        /// </summary>
                        [NameInMap("depart_id")]
                        [Validation(Required=false)]
                        public string DepartId { get; set; }

                        [NameInMap("depart_name")]
                        [Validation(Required=false)]
                        public string DepartName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>330000001815</para>
                        /// </summary>
                        [NameInMap("out_depart_id")]
                        [Validation(Required=false)]
                        public string OutDepartId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001</para>
                    /// </summary>
                    [NameInMap("job_no")]
                    [Validation(Required=false)]
                    public string JobNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>13311112222</para>
                    /// </summary>
                    [NameInMap("telephone")]
                    [Validation(Required=false)]
                    public string Telephone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1430378</para>
                    /// </summary>
                    [NameInMap("traveler_id")]
                    [Validation(Required=false)]
                    public string TravelerId { get; set; }

                    [NameInMap("traveler_name")]
                    [Validation(Required=false)]
                    public string TravelerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("traveler_type")]
                    [Validation(Required=false)]
                    public int? TravelerType { get; set; }

                    [NameInMap("trip_cost_center")]
                    [Validation(Required=false)]
                    public HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosTripCostCenter TripCostCenter { get; set; }
                    public class HotelOrderInfoQueryResponseBodyModuleRoomTraverInfoTraverInfosTripCostCenter : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>323431</para>
                        /// </summary>
                        [NameInMap("cost_center_code")]
                        [Validation(Required=false)]
                        public string CostCenterCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2312</para>
                        /// </summary>
                        [NameInMap("cost_center_id")]
                        [Validation(Required=false)]
                        public string CostCenterId { get; set; }

                        [NameInMap("cost_center_name")]
                        [Validation(Required=false)]
                        public string CostCenterName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{&quot;extraKey&quot;:&quot;extraVal&quot;}</para>
                        /// </summary>
                        [NameInMap("external_ext_field")]
                        [Validation(Required=false)]
                        public string ExternalExtField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("fee_type")]
                        [Validation(Required=false)]
                        public int? FeeType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123332</para>
                        /// </summary>
                        [NameInMap("invoice_id")]
                        [Validation(Required=false)]
                        public long? InvoiceId { get; set; }

                        [NameInMap("invoice_title")]
                        [Validation(Required=false)]
                        public string InvoiceTitle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1002</para>
                        /// </summary>
                        [NameInMap("project_code")]
                        [Validation(Required=false)]
                        public string ProjectCode { get; set; }

                        [NameInMap("project_title")]
                        [Validation(Required=false)]
                        public string ProjectTitle { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("user_type")]
                    [Validation(Required=false)]
                    public int? UserType { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
