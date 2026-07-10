// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainBillSettlementQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainBillSettlementQueryResponseBodyModule Module { get; set; }
        public class TrainBillSettlementQueryResponseBodyModule : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("data_list")]
            [Validation(Required=false)]
            public List<TrainBillSettlementQueryResponseBodyModuleDataList> DataList { get; set; }
            public class TrainBillSettlementQueryResponseBodyModuleDataList : TeaModel {
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("approver_email")]
                [Validation(Required=false)]
                public string ApproverEmail { get; set; }

                [NameInMap("approver_id")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                [NameInMap("approver_name")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                [NameInMap("arr_station_location")]
                [Validation(Required=false)]
                public string ArrStationLocation { get; set; }

                [NameInMap("arr_station_location_code")]
                [Validation(Required=false)]
                public string ArrStationLocationCode { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("base_location")]
                [Validation(Required=false)]
                public string BaseLocation { get; set; }

                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                [NameInMap("business_trip_result")]
                [Validation(Required=false)]
                public string BusinessTripResult { get; set; }

                [NameInMap("cabin_max_price")]
                [Validation(Required=false)]
                public double? CabinMaxPrice { get; set; }

                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                [NameInMap("change_affiliate_no")]
                [Validation(Required=false)]
                public string ChangeAffiliateNo { get; set; }

                [NameInMap("change_apply_id")]
                [Validation(Required=false)]
                public string ChangeApplyId { get; set; }

                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("change_result")]
                [Validation(Required=false)]
                public string ChangeResult { get; set; }

                [NameInMap("coach_no")]
                [Validation(Required=false)]
                public string CoachNo { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("cost_department")]
                [Validation(Required=false)]
                public string CostDepartment { get; set; }

                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                [NameInMap("custom_content")]
                [Validation(Required=false)]
                public string CustomContent { get; set; }

                [NameInMap("deductible_tax")]
                [Validation(Required=false)]
                public double? DeductibleTax { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_station_location")]
                [Validation(Required=false)]
                public string DepStationLocation { get; set; }

                [NameInMap("dep_station_location_code")]
                [Validation(Required=false)]
                public string DepStationLocationCode { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("dept_station")]
                [Validation(Required=false)]
                public string DeptStation { get; set; }

                [NameInMap("dept_time")]
                [Validation(Required=false)]
                public string DeptTime { get; set; }

                [NameInMap("exceed_reason")]
                [Validation(Required=false)]
                public string ExceedReason { get; set; }

                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                [NameInMap("foreigners_tag")]
                [Validation(Required=false)]
                public string ForeignersTag { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("is_transfer_order")]
                [Validation(Required=false)]
                public string IsTransferOrder { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("long_ticket_no")]
                [Validation(Required=false)]
                public string LongTicketNo { get; set; }

                [NameInMap("mapping_company_code")]
                [Validation(Required=false)]
                public string MappingCompanyCode { get; set; }

                [NameInMap("max_cabin")]
                [Validation(Required=false)]
                public string MaxCabin { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_ticket_no")]
                [Validation(Required=false)]
                public string OrderTicketNo { get; set; }

                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("position_level")]
                [Validation(Required=false)]
                public string PositionLevel { get; set; }

                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                [NameInMap("print_ticket_price")]
                [Validation(Required=false)]
                public double? PrintTicketPrice { get; set; }

                [NameInMap("processor_oa_code")]
                [Validation(Required=false)]
                public string ProcessorOaCode { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("refund_affiliate_no")]
                [Validation(Required=false)]
                public string RefundAffiliateNo { get; set; }

                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public double? RefundFee { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("reserve_mode")]
                [Validation(Required=false)]
                public string ReserveMode { get; set; }

                [NameInMap("run_time")]
                [Validation(Required=false)]
                public string RunTime { get; set; }

                [NameInMap("scene_id")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("scene_name")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                [NameInMap("short_ticket_no")]
                [Validation(Required=false)]
                public string ShortTicketNo { get; set; }

                [NameInMap("sio")]
                [Validation(Required=false)]
                public string Sio { get; set; }

                [NameInMap("speed_package_fee")]
                [Validation(Required=false)]
                public double? SpeedPackageFee { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                [NameInMap("ticket_corp_pay_price")]
                [Validation(Required=false)]
                public string TicketCorpPayPrice { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_person_pay_price")]
                [Validation(Required=false)]
                public string TicketPersonPayPrice { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                [NameInMap("train_type")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                [NameInMap("traveler_job_no")]
                [Validation(Required=false)]
                public string TravelerJobNo { get; set; }

                [NameInMap("traveler_member_type")]
                [Validation(Required=false)]
                public string TravelerMemberType { get; set; }

                [NameInMap("traveler_member_type_name")]
                [Validation(Required=false)]
                public string TravelerMemberTypeName { get; set; }

                [NameInMap("traveler_name")]
                [Validation(Required=false)]
                public string TravelerName { get; set; }

                [NameInMap("verify_failed_reason")]
                [Validation(Required=false)]
                public string VerifyFailedReason { get; set; }

                [NameInMap("verify_status")]
                [Validation(Required=false)]
                public int? VerifyStatus { get; set; }

                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

            }

            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

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
