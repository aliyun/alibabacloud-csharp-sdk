// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketPageQueryProductResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketPageQueryProductResponseBodyData Data { get; set; }
        public class TicketPageQueryProductResponseBodyData : TeaModel {
            [NameInMap("Products")]
            [Validation(Required=false)]
            public List<TicketPageQueryProductResponseBodyDataProducts> Products { get; set; }
            public class TicketPageQueryProductResponseBodyDataProducts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("BookingType")]
                [Validation(Required=false)]
                public int? BookingType { get; set; }

                [NameInMap("BuyRule")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsBuyRule BuyRule { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsBuyRule : TeaModel {
                    [NameInMap("AheadBuyTimePointRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsBuyRuleAheadBuyTimePointRule AheadBuyTimePointRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsBuyRuleAheadBuyTimePointRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public int? Anchor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2026-01-01</para>
                        /// </summary>
                        [NameInMap("FixedTime")]
                        [Validation(Required=false)]
                        public string FixedTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18:00</para>
                        /// </summary>
                        [NameInMap("OffsetDayOfTime")]
                        [Validation(Required=false)]
                        public string OffsetDayOfTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetUnit")]
                        [Validation(Required=false)]
                        public int? OffsetUnit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetValue")]
                        [Validation(Required=false)]
                        public int? OffsetValue { get; set; }

                    }

                    [NameInMap("ContactRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsBuyRuleContactRule ContactRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsBuyRuleContactRule : TeaModel {
                        [NameInMap("ContactFieldRule")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsBuyRuleContactRuleContactFieldRule ContactFieldRule { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsBuyRuleContactRuleContactFieldRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Certificate")]
                            [Validation(Required=false)]
                            public bool? Certificate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>[1, 2]</para>
                            /// </summary>
                            [NameInMap("CertificateTypes")]
                            [Validation(Required=false)]
                            public List<int?> CertificateTypes { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("DialingCode")]
                            [Validation(Required=false)]
                            public bool? DialingCode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Email")]
                            [Validation(Required=false)]
                            public bool? Email { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("FirstName")]
                            [Validation(Required=false)]
                            public bool? FirstName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("LastName")]
                            [Validation(Required=false)]
                            public bool? LastName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Mobile")]
                            [Validation(Required=false)]
                            public bool? Mobile { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public bool? Name { get; set; }

                        }

                    }

                    [NameInMap("CrossOrderBuyQuantityLimitRules")]
                    [Validation(Required=false)]
                    public List<TicketPageQueryProductResponseBodyDataProductsBuyRuleCrossOrderBuyQuantityLimitRules> CrossOrderBuyQuantityLimitRules { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsBuyRuleCrossOrderBuyQuantityLimitRules : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LimitDayType")]
                        [Validation(Required=false)]
                        public int? LimitDayType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("LimitDays")]
                        [Validation(Required=false)]
                        public int? LimitDays { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LimitPeriod")]
                        [Validation(Required=false)]
                        public int? LimitPeriod { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LimitQuantityType")]
                        [Validation(Required=false)]
                        public int? LimitQuantityType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LimitType")]
                        [Validation(Required=false)]
                        public int? LimitType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("MaxBuyQuantity")]
                        [Validation(Required=false)]
                        public int? MaxBuyQuantity { get; set; }

                    }

                    [NameInMap("PerOrderBuyQuantityLimitRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsBuyRulePerOrderBuyQuantityLimitRule PerOrderBuyQuantityLimitRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsBuyRulePerOrderBuyQuantityLimitRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("MaxBuyQuantity")]
                        [Validation(Required=false)]
                        public int? MaxBuyQuantity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinBuyQuantity")]
                        [Validation(Required=false)]
                        public int? MinBuyQuantity { get; set; }

                    }

                    [NameInMap("TravelerRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRule TravelerRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRule : TeaModel {
                        [NameInMap("CrowdLimitRules")]
                        [Validation(Required=false)]
                        public List<TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleCrowdLimitRules> CrowdLimitRules { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleCrowdLimitRules : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("AgeBaseTimeType")]
                            [Validation(Required=false)]
                            public int? AgeBaseTimeType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("AgeCalculateType")]
                            [Validation(Required=false)]
                            public int? AgeCalculateType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>65</para>
                            /// </summary>
                            [NameInMap("AgeMax")]
                            [Validation(Required=false)]
                            public int? AgeMax { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>18</para>
                            /// </summary>
                            [NameInMap("AgeMin")]
                            [Validation(Required=false)]
                            public int? AgeMin { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>成人票</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("CrowdQuantityLimits")]
                        [Validation(Required=false)]
                        public List<TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleCrowdQuantityLimits> CrowdQuantityLimits { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleCrowdQuantityLimits : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>成人票</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Quantity")]
                            [Validation(Required=false)]
                            public int? Quantity { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("NeedFillTraveler")]
                        [Validation(Required=false)]
                        public bool? NeedFillTraveler { get; set; }

                        [NameInMap("TravelerFieldRule")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleTravelerFieldRule TravelerFieldRule { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsBuyRuleTravelerRuleTravelerFieldRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Birthday")]
                            [Validation(Required=false)]
                            public bool? Birthday { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Certificate")]
                            [Validation(Required=false)]
                            public bool? Certificate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>[1, 2]</para>
                            /// </summary>
                            [NameInMap("CertificateTypes")]
                            [Validation(Required=false)]
                            public List<int?> CertificateTypes { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("DialingCode")]
                            [Validation(Required=false)]
                            public bool? DialingCode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Email")]
                            [Validation(Required=false)]
                            public bool? Email { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("FirstName")]
                            [Validation(Required=false)]
                            public bool? FirstName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Gender")]
                            [Validation(Required=false)]
                            public bool? Gender { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("LastName")]
                            [Validation(Required=false)]
                            public bool? LastName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Mobile")]
                            [Validation(Required=false)]
                            public bool? Mobile { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public bool? Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Nationality")]
                            [Validation(Required=false)]
                            public bool? Nationality { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("TravelerFillDimension")]
                        [Validation(Required=false)]
                        public int? TravelerFillDimension { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("TravelerQuantity")]
                        [Validation(Required=false)]
                        public int? TravelerQuantity { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>含景区大门票一张</para>
                /// </summary>
                [NameInMap("CostIncludeRemark")]
                [Validation(Required=false)]
                public string CostIncludeRemark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("DeliverGuaranteeMinutes")]
                [Validation(Required=false)]
                public int? DeliverGuaranteeMinutes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;<a href="https://example.com/detail1.jpg%22%5D">https://example.com/detail1.jpg&quot;]</a></para>
                /// </summary>
                [NameInMap("Images")]
                [Validation(Required=false)]
                public List<string> Images { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InvoiceIssuerType")]
                [Validation(Required=false)]
                public int? InvoiceIssuerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PaymentLimitMinutes")]
                [Validation(Required=false)]
                public int? PaymentLimitMinutes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>西湖游船成人票</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("RefundRule")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsRefundRule RefundRule { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsRefundRule : TeaModel {
                    [NameInMap("RefundStageRules")]
                    [Validation(Required=false)]
                    public List<TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRules> RefundStageRules { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRules : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.2056</para>
                        /// </summary>
                        [NameInMap("Fee")]
                        [Validation(Required=false)]
                        public double? Fee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("FeeBase")]
                        [Validation(Required=false)]
                        public int? FeeBase { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("FeeType")]
                        [Validation(Required=false)]
                        public int? FeeType { get; set; }

                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRulesFrom From { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRulesFrom : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Anchor")]
                            [Validation(Required=false)]
                            public int? Anchor { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-01-01</para>
                            /// </summary>
                            [NameInMap("FixedTime")]
                            [Validation(Required=false)]
                            public string FixedTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>18:00</para>
                            /// </summary>
                            [NameInMap("OffsetDayOfTime")]
                            [Validation(Required=false)]
                            public string OffsetDayOfTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetUnit")]
                            [Validation(Required=false)]
                            public int? OffsetUnit { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetValue")]
                            [Validation(Required=false)]
                            public int? OffsetValue { get; set; }

                        }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRulesTo To { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsRefundRuleRefundStageRulesTo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Anchor")]
                            [Validation(Required=false)]
                            public int? Anchor { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-01-01</para>
                            /// </summary>
                            [NameInMap("FixedTime")]
                            [Validation(Required=false)]
                            public string FixedTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>18:00</para>
                            /// </summary>
                            [NameInMap("OffsetDayOfTime")]
                            [Validation(Required=false)]
                            public string OffsetDayOfTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetUnit")]
                            [Validation(Required=false)]
                            public int? OffsetUnit { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetValue")]
                            [Validation(Required=false)]
                            public int? OffsetValue { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("RefundType")]
                    [Validation(Required=false)]
                    public int? RefundType { get; set; }

                }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsRegion Region { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsRegion : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>普通区</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ScenicId")]
                [Validation(Required=false)]
                public long? ScenicId { get; set; }

                [NameInMap("Session")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsSession Session { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsSession : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12:00</para>
                    /// </summary>
                    [NameInMap("SessionEndTime")]
                    [Validation(Required=false)]
                    public string SessionEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>08:00-12:00</para>
                    /// </summary>
                    [NameInMap("SessionName")]
                    [Validation(Required=false)]
                    public string SessionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>08:00</para>
                    /// </summary>
                    [NameInMap("SessionStartTime")]
                    [Validation(Required=false)]
                    public string SessionStartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SettlePriceCalculateType")]
                [Validation(Required=false)]
                public int? SettlePriceCalculateType { get; set; }

                [NameInMap("Spu")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsSpu Spu { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsSpu : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>门票</para>
                    /// </summary>
                    [NameInMap("PrimaryTypeName")]
                    [Validation(Required=false)]
                    public string PrimaryTypeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>门票级别日历详情</para>
                    /// </summary>
                    [NameInMap("ReserveDetail")]
                    [Validation(Required=false)]
                    public string ReserveDetail { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>门票级别日历说明</para>
                    /// </summary>
                    [NameInMap("ReserveTitle")]
                    [Validation(Required=false)]
                    public string ReserveTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>首道门票</para>
                    /// </summary>
                    [NameInMap("SecondaryTypeName")]
                    [Validation(Required=false)]
                    public string SecondaryTypeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3507</para>
                    /// </summary>
                    [NameInMap("SpuId")]
                    [Validation(Required=false)]
                    public long? SpuId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1日票</para>
                    /// </summary>
                    [NameInMap("SpuName")]
                    [Validation(Required=false)]
                    public string SpuName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>飞猪景区乐园旗舰店</para>
                /// </summary>
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("TicketKind")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsTicketKind TicketKind { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsTicketKind : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>适用于18周岁(含)至59周岁(含)的游客</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60484007</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>成人票</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("UseRule")]
                [Validation(Required=false)]
                public TicketPageQueryProductResponseBodyDataProductsUseRule UseRule { get; set; }
                public class TicketPageQueryProductResponseBodyDataProductsUseRule : TeaModel {
                    [NameInMap("EffectTimePointRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsUseRuleEffectTimePointRule EffectTimePointRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsUseRuleEffectTimePointRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public int? Anchor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2026-01-01</para>
                        /// </summary>
                        [NameInMap("FixedTime")]
                        [Validation(Required=false)]
                        public string FixedTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18:00</para>
                        /// </summary>
                        [NameInMap("OffsetDayOfTime")]
                        [Validation(Required=false)]
                        public string OffsetDayOfTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetUnit")]
                        [Validation(Required=false)]
                        public int? OffsetUnit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetValue")]
                        [Validation(Required=false)]
                        public int? OffsetValue { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>景区正门入口</para>
                    /// </summary>
                    [NameInMap("EntryAddress")]
                    [Validation(Required=false)]
                    public string EntryAddress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>请于入园前2小时至香港迪士尼度假区售票处旁人工服务站进行取票预约，服务时间上午 10:00 至 晚上 8:30</para>
                    /// </summary>
                    [NameInMap("EntryRemark")]
                    [Validation(Required=false)]
                    public string EntryRemark { get; set; }

                    [NameInMap("EntryTimePeriods")]
                    [Validation(Required=false)]
                    public List<TicketPageQueryProductResponseBodyDataProductsUseRuleEntryTimePeriods> EntryTimePeriods { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsUseRuleEntryTimePeriods : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>08:00</para>
                        /// </summary>
                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public string BeginTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>17:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public int? EntryType { get; set; }

                    [NameInMap("EntryWithVoucherRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsUseRuleEntryWithVoucherRule EntryWithVoucherRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsUseRuleEntryWithVoucherRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>凭二维码入园</para>
                        /// </summary>
                        [NameInMap("VoucherRemark")]
                        [Validation(Required=false)]
                        public string VoucherRemark { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[1]</para>
                        /// </summary>
                        [NameInMap("VoucherTypes")]
                        [Validation(Required=false)]
                        public List<int?> VoucherTypes { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("NeedAssemble")]
                    [Validation(Required=false)]
                    public bool? NeedAssemble { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("NeedPrebook")]
                    [Validation(Required=false)]
                    public bool? NeedPrebook { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>请携带有效身份证件</para>
                    /// </summary>
                    [NameInMap("OtherNote")]
                    [Validation(Required=false)]
                    public string OtherNote { get; set; }

                    [NameInMap("PickupsRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsUseRulePickupsRule PickupsRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsUseRulePickupsRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>景区游客中心</para>
                        /// </summary>
                        [NameInMap("PickupsAddress")]
                        [Validation(Required=false)]
                        public string PickupsAddress { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>凭短信取票</para>
                        /// </summary>
                        [NameInMap("VoucherRemark")]
                        [Validation(Required=false)]
                        public string VoucherRemark { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[1]</para>
                        /// </summary>
                        [NameInMap("VoucherTypes")]
                        [Validation(Required=false)]
                        public List<int?> VoucherTypes { get; set; }

                    }

                    [NameInMap("ValidityPeriodRule")]
                    [Validation(Required=false)]
                    public TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRule ValidityPeriodRule { get; set; }
                    public class TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[1, 2, 3, 4, 5, 6, 7]</para>
                        /// </summary>
                        [NameInMap("AvailableWeeks")]
                        [Validation(Required=false)]
                        public List<int?> AvailableWeeks { get; set; }

                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRuleFrom From { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRuleFrom : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Anchor")]
                            [Validation(Required=false)]
                            public int? Anchor { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-01-01</para>
                            /// </summary>
                            [NameInMap("FixedTime")]
                            [Validation(Required=false)]
                            public string FixedTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>18:00</para>
                            /// </summary>
                            [NameInMap("OffsetDayOfTime")]
                            [Validation(Required=false)]
                            public string OffsetDayOfTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetUnit")]
                            [Validation(Required=false)]
                            public int? OffsetUnit { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetValue")]
                            [Validation(Required=false)]
                            public int? OffsetValue { get; set; }

                        }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRuleTo To { get; set; }
                        public class TicketPageQueryProductResponseBodyDataProductsUseRuleValidityPeriodRuleTo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Anchor")]
                            [Validation(Required=false)]
                            public int? Anchor { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-01-01</para>
                            /// </summary>
                            [NameInMap("FixedTime")]
                            [Validation(Required=false)]
                            public string FixedTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>18:00</para>
                            /// </summary>
                            [NameInMap("OffsetDayOfTime")]
                            [Validation(Required=false)]
                            public string OffsetDayOfTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetUnit")]
                            [Validation(Required=false)]
                            public int? OffsetUnit { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OffsetValue")]
                            [Validation(Required=false)]
                            public int? OffsetValue { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[&quot;2026-01-01&quot;]</para>
                        /// </summary>
                        [NameInMap("UnavailableDates")]
                        [Validation(Required=false)]
                        public List<string> UnavailableDates { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicId不合法</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
