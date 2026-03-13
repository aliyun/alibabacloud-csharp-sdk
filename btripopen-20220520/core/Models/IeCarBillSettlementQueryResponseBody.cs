// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeCarBillSettlementQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IeCarBillSettlementQueryResponseBodyModule Module { get; set; }
        public class IeCarBillSettlementQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<IeCarBillSettlementQueryResponseBodyModuleItems> Items { get; set; }
            public class IeCarBillSettlementQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20251201</para>
                /// </summary>
                [NameInMap("account_month")]
                [Validation(Required=false)]
                public string AccountMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("adjust_time")]
                [Validation(Required=false)]
                public string AdjustTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123aaa</para>
                /// </summary>
                [NameInMap("alipay_id")]
                [Validation(Required=false)]
                public string AlipayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>124</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_arr_city_code")]
                [Validation(Required=false)]
                public string ApplyArrCityCode { get; set; }

                [NameInMap("apply_arr_city_name")]
                [Validation(Required=false)]
                public string ApplyArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("apply_dep_city_code")]
                [Validation(Required=false)]
                public string ApplyDepCityCode { get; set; }

                [NameInMap("apply_dep_city_name")]
                [Validation(Required=false)]
                public string ApplyDepCityName { get; set; }

                [NameInMap("apply_extend_field")]
                [Validation(Required=false)]
                public string ApplyExtendField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>265741695</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:123@qq.com">123@qq.com</a></para>
                /// </summary>
                [NameInMap("approver_email")]
                [Validation(Required=false)]
                public string ApproverEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("approver_id")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                [NameInMap("approver_name")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>131000</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_country")]
                [Validation(Required=false)]
                public string ArrCountry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-02 10:00:00</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-02 10:00:00</para>
                /// </summary>
                [NameInMap("arr_date_local")]
                [Validation(Required=false)]
                public string ArrDateLocal { get; set; }

                [NameInMap("arr_location")]
                [Validation(Required=false)]
                public string ArrLocation { get; set; }

                [NameInMap("base_location")]
                [Validation(Required=false)]
                public string BaseLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time")]
                [Validation(Required=false)]
                public string BillRecordTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-11-01 00:00:00</para>
                /// </summary>
                [NameInMap("bill_record_time_str")]
                [Validation(Required=false)]
                public string BillRecordTimeStr { get; set; }

                [NameInMap("billing_entity")]
                [Validation(Required=false)]
                public string BillingEntity { get; set; }

                [NameInMap("book_channel")]
                [Validation(Required=false)]
                public string BookChannel { get; set; }

                [NameInMap("book_mode")]
                [Validation(Required=false)]
                public string BookMode { get; set; }

                [NameInMap("book_model")]
                [Validation(Required=false)]
                public string BookModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("book_time")]
                [Validation(Required=false)]
                public string BookTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-01 10:00:00</para>
                /// </summary>
                [NameInMap("book_time_local")]
                [Validation(Required=false)]
                public string BookTimeLocal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("booker_id")]
                [Validation(Required=false)]
                public string BookerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
                [NameInMap("booker_job_no")]
                [Validation(Required=false)]
                public string BookerJobNo { get; set; }

                [NameInMap("booker_name")]
                [Validation(Required=false)]
                public string BookerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("booker_use_id")]
                [Validation(Required=false)]
                public string BookerUseId { get; set; }

                [NameInMap("business_category")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                [NameInMap("capital_direction")]
                [Validation(Required=false)]
                public string CapitalDirection { get; set; }

                [NameInMap("car_level")]
                [Validation(Required=false)]
                public string CarLevel { get; set; }

                [NameInMap("cascade_department")]
                [Validation(Required=false)]
                public string CascadeDepartment { get; set; }

                [NameInMap("category_desc")]
                [Validation(Required=false)]
                public string CategoryDesc { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs1</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>code1</para>
                /// </summary>
                [NameInMap("cost_department")]
                [Validation(Required=false)]
                public string CostDepartment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("coupon")]
                [Validation(Required=false)]
                public double? Coupon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("coupon_price")]
                [Validation(Required=false)]
                public double? CouponPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;key1\&quot;:\&quot;value1\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;,\&quot;key3\&quot;:\&quot;value3\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("custom_content")]
                [Validation(Required=false)]
                public string CustomContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.11</para>
                /// </summary>
                [NameInMap("deductible_tax")]
                [Validation(Required=false)]
                public double? DeductibleTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>131000</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_country")]
                [Validation(Required=false)]
                public string DepCountry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-01 10:00:00</para>
                /// </summary>
                [NameInMap("dep_date_local")]
                [Validation(Required=false)]
                public string DepDateLocal { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1112</para>
                /// </summary>
                [NameInMap("department_id")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("dept_city")]
                [Validation(Required=false)]
                public string DeptCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-01 10:00:00</para>
                /// </summary>
                [NameInMap("dept_date")]
                [Validation(Required=false)]
                public string DeptDate { get; set; }

                [NameInMap("dept_location")]
                [Validation(Required=false)]
                public string DeptLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("driver_add_detail")]
                [Validation(Required=false)]
                public string DriverAddDetail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("driver_add_fee")]
                [Validation(Required=false)]
                public double? DriverAddFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("estimate_drive_distance")]
                [Validation(Required=false)]
                public string EstimateDriveDistance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110.0</para>
                /// </summary>
                [NameInMap("estimate_price")]
                [Validation(Required=false)]
                public double? EstimatePrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>140101</para>
                /// </summary>
                [NameInMap("fee_type")]
                [Validation(Required=false)]
                public string FeeType { get; set; }

                [NameInMap("fee_type_desc")]
                [Validation(Required=false)]
                public string FeeTypeDesc { get; set; }

                [NameInMap("financial_subject")]
                [Validation(Required=false)]
                public string FinancialSubject { get; set; }

                [NameInMap("foreigners_tag")]
                [Validation(Required=false)]
                public string ForeignersTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("last_department")]
                [Validation(Required=false)]
                public string LastDepartment { get; set; }

                [NameInMap("level_name")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <para>Location</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("main_apply_id")]
                [Validation(Required=false)]
                public string MainApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>q1</para>
                /// </summary>
                [NameInMap("mapping_company_code")]
                [Validation(Required=false)]
                public string MappingCompanyCode { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1017034204020120044</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("order_price")]
                [Validation(Required=false)]
                public double? OrderPrice { get; set; }

                [NameInMap("order_status_desc")]
                [Validation(Required=false)]
                public string OrderStatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("origin_apply_id")]
                [Validation(Required=false)]
                public string OriginApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("over_apply_id")]
                [Validation(Required=false)]
                public string OverApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EN01002423</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("person_settle_fee")]
                [Validation(Required=false)]
                public double? PersonSettleFee { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("position_level")]
                [Validation(Required=false)]
                public string PositionLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72328485</para>
                /// </summary>
                [NameInMap("primary_id")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>www123</para>
                /// </summary>
                [NameInMap("processor_oa_code")]
                [Validation(Required=false)]
                public string ProcessorOaCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("protocol_discount_fee")]
                [Validation(Required=false)]
                public double? ProtocolDiscountFee { get; set; }

                [NameInMap("provider_name")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111224324</para>
                /// </summary>
                [NameInMap("purchase_order_id")]
                [Validation(Required=false)]
                public string PurchaseOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("real_drive_distance")]
                [Validation(Required=false)]
                public string RealDriveDistance { get; set; }

                [NameInMap("real_from_addr")]
                [Validation(Required=false)]
                public string RealFromAddr { get; set; }

                [NameInMap("real_to_addr")]
                [Validation(Required=false)]
                public string RealToAddr { get; set; }

                [NameInMap("record_status")]
                [Validation(Required=false)]
                public string RecordStatus { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("scene_id")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("scene_name")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public double? ServiceFee { get; set; }

                [NameInMap("settle_type_desc")]
                [Validation(Required=false)]
                public string SettleTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110.0</para>
                /// </summary>
                [NameInMap("settlement_fee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("settlement_grant_fee")]
                [Validation(Required=false)]
                public double? SettlementGrantFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("settlement_time")]
                [Validation(Required=false)]
                public string SettlementTime { get; set; }

                [NameInMap("settlement_type")]
                [Validation(Required=false)]
                public string SettlementType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>188385292</para>
                /// </summary>
                [NameInMap("show_sub_order_id")]
                [Validation(Required=false)]
                public string ShowSubOrderId { get; set; }

                /// <summary>
                /// <para>SIO</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIO</para>
                /// </summary>
                [NameInMap("sio")]
                [Validation(Required=false)]
                public string Sio { get; set; }

                [NameInMap("special_order")]
                [Validation(Required=false)]
                public string SpecialOrder { get; set; }

                [NameInMap("special_reason")]
                [Validation(Required=false)]
                public string SpecialReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>188385292</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("supplement_apply_id")]
                [Validation(Required=false)]
                public string SupplementApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs2</para>
                /// </summary>
                [NameInMap("third_invoice_id")]
                [Validation(Required=false)]
                public string ThirdInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("third_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_part_business_id")]
                [Validation(Required=false)]
                public string ThirdPartBusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7244-1968</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("time_type")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                [NameInMap("trade_action_desc")]
                [Validation(Required=false)]
                public string TradeActionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:123@qq.com">123@qq.com</a></para>
                /// </summary>
                [NameInMap("traveler_email")]
                [Validation(Required=false)]
                public string TravelerEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("traveler_id")]
                [Validation(Required=false)]
                public string TravelerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A1234</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("traveler_use_id")]
                [Validation(Required=false)]
                public string TravelerUseId { get; set; }

                [NameInMap("user_confirm_desc")]
                [Validation(Required=false)]
                public string UserConfirmDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("vehicle_scene_id")]
                [Validation(Required=false)]
                public string VehicleSceneId { get; set; }

                [NameInMap("vehicle_scene_name")]
                [Validation(Required=false)]
                public string VehicleSceneName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("voucher_type")]
                [Validation(Required=false)]
                public int? VoucherType { get; set; }

                [NameInMap("voucher_type_desc")]
                [Validation(Required=false)]
                public string VoucherTypeDesc { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-14</para>
            /// </summary>
            [NameInMap("period_end")]
            [Validation(Required=false)]
            public string PeriodEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-10-13</para>
            /// </summary>
            [NameInMap("period_start")]
            [Validation(Required=false)]
            public string PeriodStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4MDAwMDAwMDA4YTU2NDMy</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_num")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A1984987-9C0D-5EEB-A2AC-0D5D76D41705</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b5287ed17606676287351344d0095</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
