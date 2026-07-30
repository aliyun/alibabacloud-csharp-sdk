// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCreateRequest : TeaModel {
        [NameInMap("arrival_time")]
        [Validation(Required=false)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// <para>The external user ID. If organization personnel synchronization is enabled, use the btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20 00:00:00</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>The check-out date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20 00:00:00</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s email address. This parameter is required if the need_email parameter returned by the pre-order validation operation is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s mobile phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        /// <summary>
        /// <para>The corporate payment amount. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>The distributor order ID. Regardless of whether the order is created successfully, the distributor order ID is recorded. Do not use the same order ID to place orders multiple times.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The extended information in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>（特定企业需要传递）
        /// 1.企业支付金额：DisCorpPayPrice
        /// 2.个人支付金额：
        /// DisPersonPayPrice</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The invoice information.</para>
        /// </summary>
        [NameInMap("invoice_info")]
        [Validation(Required=false)]
        public HotelOrderCreateRequestInvoiceInfo InvoiceInfo { get; set; }
        public class HotelOrderCreateRequestInvoiceInfo : TeaModel {
            /// <summary>
            /// <para>The company address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_add")]
            [Validation(Required=false)]
            public string BuyerAdd { get; set; }

            /// <summary>
            /// <para>The bank account number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_bank_acc")]
            [Validation(Required=false)]
            public string BuyerBankAcc { get; set; }

            /// <summary>
            /// <para>The bank name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("buyer_bank_add")]
            [Validation(Required=false)]
            public string BuyerBankAdd { get; set; }

            /// <summary>
            /// <para>The company phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571-82****00</para>
            /// </summary>
            [NameInMap("buyer_phone")]
            [Validation(Required=false)]
            public string BuyerPhone { get; set; }

            /// <summary>
            /// <para>The tax number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("buyer_tax_num")]
            [Validation(Required=false)]
            public string BuyerTaxNum { get; set; }

            /// <summary>
            /// <para>The detailed delivery address. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***小区</para>
            /// </summary>
            [NameInMap("delivery_address")]
            [Validation(Required=false)]
            public string DeliveryAddress { get; set; }

            /// <summary>
            /// <para>The delivery district. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>拱墅</para>
            /// </summary>
            [NameInMap("delivery_area")]
            [Validation(Required=false)]
            public string DeliveryArea { get; set; }

            /// <summary>
            /// <para>The delivery city. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("delivery_city")]
            [Validation(Required=false)]
            public string DeliveryCity { get; set; }

            /// <summary>
            /// <para>The delivery province. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江</para>
            /// </summary>
            [NameInMap("delivery_province")]
            [Validation(Required=false)]
            public string DeliveryProvince { get; set; }

            /// <summary>
            /// <para>The delivery street. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***街道</para>
            /// </summary>
            [NameInMap("delivery_street")]
            [Validation(Required=false)]
            public string DeliveryStreet { get; set; }

            /// <summary>
            /// <para>The mailbox address. This parameter is required for electronic invoicing.</para>
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
            /// <para>demo</para>
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
            /// <para>The recipient name. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("receiver_name")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <para>The recipient phone number. This parameter is required for paper invoices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571-82****00</para>
            /// </summary>
            [NameInMap("receiver_phone")]
            [Validation(Required=false)]
            public string ReceiverPhone { get; set; }

            /// <summary>
            /// <para>The invoice remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The item ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>671570615157</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>The btrip itinerary ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb5e1abf33924b6c912bd6d80deec0eb-1</para>
        /// </summary>
        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        [NameInMap("leave_time")]
        [Validation(Required=false)]
        public string LeaveTime { get; set; }

        /// <summary>
        /// <para>The GDS membership card information.</para>
        /// </summary>
        [NameInMap("member_info")]
        [Validation(Required=false)]
        public HotelOrderCreateRequestMemberInfo MemberInfo { get; set; }
        public class HotelOrderCreateRequestMemberInfo : TeaModel {
            /// <summary>
            /// <para>The GDS card number.</para>
            /// </summary>
            [NameInMap("card_no")]
            [Validation(Required=false)]
            public string CardNo { get; set; }

            /// <summary>
            /// <para>The GDS cardholder name.</para>
            /// </summary>
            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

        }

        /// <summary>
        /// <para>The occupant information. The number of occupants cannot exceed the number specified during price validation. A maximum of two occupants are allowed per room.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public List<HotelOrderCreateRequestOccupantInfoList> OccupantInfoList { get; set; }
        public class HotelOrderCreateRequestOccupantInfoList : TeaModel {
            /// <summary>
            /// <para>The ID document number. This parameter is required if the need_certificate parameter returned by the pre-order validation operation is true.</para>
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
            /// <para>The cascading department.</para>
            /// </summary>
            [NameInMap("cascade_dept_name")]
            [Validation(Required=false)]
            public string CascadeDeptName { get; set; }

            /// <summary>
            /// <para>The cost center information.</para>
            /// </summary>
            [NameInMap("cost_center_info")]
            [Validation(Required=false)]
            public HotelOrderCreateRequestOccupantInfoListCostCenterInfo CostCenterInfo { get; set; }
            public class HotelOrderCreateRequestOccupantInfoListCostCenterInfo : TeaModel {
                /// <summary>
                /// <para>The cost center ID.</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public string CostCenterId { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// </summary>
                [NameInMap("cost_center_no")]
                [Validation(Required=false)]
                public string CostCenterNo { get; set; }

                /// <summary>
                /// <para>The invoice ID.</para>
                /// </summary>
                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project title.</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

            }

            /// <summary>
            /// <para>The customer type.
            /// When the number of occupants is 1, the customer type must be 1 (primary occupant).
            /// When the number of occupants is greater than 1, one must be the primary occupant and the rest must be co-occupants.
            /// The difference between primary occupant and co-occupant:</para>
            /// <ol>
            /// <item><description>The order can be found at the hotel front desk by providing the primary occupant\&quot;s name, but not the co-occupant\&quot;s name.</description></item>
            /// <item><description>The SMS templates for primary occupants and co-occupants are different.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("customer_type")]
            [Validation(Required=false)]
            public int? CustomerType { get; set; }

            /// <summary>
            /// <para>The user\&quot;s department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123112</para>
            /// </summary>
            [NameInMap("department_id")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            /// <summary>
            /// <para>The user\&quot;s department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>财务部</para>
            /// </summary>
            [NameInMap("department_name")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// <para>The occupant\&quot;s email address.</para>
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
            /// <para>The first name in English. This parameter is required if the need_english_name parameter returned by the pre-order validation operation is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>san</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>Specifies whether the occupant is the booker.</para>
            /// </summary>
            [NameInMap("is_booker")]
            [Validation(Required=false)]
            public bool? IsBooker { get; set; }

            /// <summary>
            /// <para>The last name in English. This parameter is required if the need_english_name parameter returned by the pre-order validation operation is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhang</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>The occupant name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The occupant\&quot;s mobile phone number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The room sequence number starting from 1, sorted in ascending order based on requirements. If multiple rooms are booked, this field indicates which occupants stay in which rooms. This field is required when the number of rooms is greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("room_no")]
            [Validation(Required=false)]
            public int? RoomNo { get; set; }

            /// <summary>
            /// <para>The employee number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87817182</para>
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
        /// <para>The personal payment amount. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("person_pay_price")]
        [Validation(Required=false)]
        public long? PersonPayPrice { get; set; }

        /// <summary>
        /// <para>The promotion information.</para>
        /// </summary>
        [NameInMap("promotion_info")]
        [Validation(Required=false)]
        public HotelOrderCreateRequestPromotionInfo PromotionInfo { get; set; }
        public class HotelOrderCreateRequestPromotionInfo : TeaModel {
            /// <summary>
            /// <para>The promotion details.</para>
            /// </summary>
            [NameInMap("promotion_detail_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderCreateRequestPromotionInfoPromotionDetailInfoList> PromotionDetailInfoList { get; set; }
            public class HotelOrderCreateRequestPromotionInfoPromotionDetailInfoList : TeaModel {
                /// <summary>
                /// <para>The selection status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("check_status")]
                [Validation(Required=false)]
                public bool? CheckStatus { get; set; }

                /// <summary>
                /// <para>Specifies whether the promotion needs to be selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("need_check")]
                [Validation(Required=false)]
                public bool? NeedCheck { get; set; }

                /// <summary>
                /// <para>The promotion code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tripBybtCrossPromotion-%</para>
                /// </summary>
                [NameInMap("promotion_code")]
                [Validation(Required=false)]
                public string PromotionCode { get; set; }

                /// <summary>
                /// <para>The promotion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23778127</para>
                /// </summary>
                [NameInMap("promotion_id")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The promotion name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅优惠</para>
                /// </summary>
                [NameInMap("promotion_name")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>The promotion amount. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public long? PromotionPrice { get; set; }

                /// <summary>
                /// <para>The promotion type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("promotion_type")]
                [Validation(Required=false)]
                public string PromotionType { get; set; }

            }

            /// <summary>
            /// <para>The total promotion amount. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("promotion_total_price")]
            [Validation(Required=false)]
            public long? PromotionTotalPrice { get; set; }

        }

        /// <summary>
        /// <para>The rate plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1399417428510</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>The room ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187211</para>
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// <para>The number of rooms.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("rp_type")]
        [Validation(Required=false)]
        public int? RpType { get; set; }

        /// <summary>
        /// <para>The seller ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2088441675613762</para>
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// <para>The standard hotel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198781</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        /// <summary>
        /// <para>The total order price. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        /// <summary>
        /// <para>The validation result.</para>
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
