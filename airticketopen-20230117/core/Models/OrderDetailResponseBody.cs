// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderDetailResponseBodyData Data { get; set; }
        public class OrderDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>ancillary product fulfillment details</para>
            /// </summary>
            [NameInMap("ancillary_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataAncillaryItemDetailList> AncillaryItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataAncillaryItemDetailList : TeaModel {
                /// <summary>
                /// <para>the ancillary buyer booked</para>
                /// </summary>
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListAncillary Ancillary { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillary : TeaModel {
                    /// <summary>
                    /// <para>ancillay_id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MDY2NTAxLCJleHAiOjE2NxNzM3MDEsIm5ix</para>
                    /// </summary>
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    /// <summary>
                    /// <para>ancillary product type currently supports 4: paid luggage</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>KG</para>
                        /// </summary>
                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10.0</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public double? Price { get; set; }

                    }

                }

                /// <summary>
                /// <para>passenger</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListPassenger : TeaModel {
                    /// <summary>
                    /// <para>date of birth (yyyyMMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>travel document</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential : TeaModel {
                        /// <summary>
                        /// <para>place of issue, two-letter code</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>travel document number</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>travel document type , only support &quot;1&quot;(1 means passport) currently.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>expiration date</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>gender 0: male; 1: female</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>last name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>country code for mobile phone number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>mobile phone number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>nationality</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>passenger type 0: adult; 1: child; 8: infant</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>segment ID list, these segments share the same ancillary</para>
                /// </summary>
                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            /// <summary>
            /// <para>baggage rule mapping, key is passenger type, value is baggage allowance details</para>
            /// </summary>
            [NameInMap("baggage_allowance_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataBaggageAllowanceMapValue> BaggageAllowanceMap { get; set; }

            /// <summary>
            /// <para>book time(timestamp)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210784000</para>
            /// </summary>
            [NameInMap("book_time")]
            [Validation(Required=false)]
            public long? BookTime { get; set; }

            /// <summary>
            /// <para>flight product fulfillment details</para>
            /// </summary>
            [NameInMap("flight_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataFlightItemDetailList> FlightItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataFlightItemDetailList : TeaModel {
                /// <summary>
                /// <para>b PNR(airline booking code) list</para>
                /// </summary>
                [NameInMap("b_pnr_list")]
                [Validation(Required=false)]
                public List<string> BPnrList { get; set; }

                /// <summary>
                /// <para>c PNR(airline booking code) list</para>
                /// </summary>
                [NameInMap("c_pnr_list")]
                [Validation(Required=false)]
                public List<string> CPnrList { get; set; }

                /// <summary>
                /// <para>flight price information for current passenger</para>
                /// </summary>
                [NameInMap("flight_price")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListFlightPrice FlightPrice { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightPrice : TeaModel {
                    /// <summary>
                    /// <para>selling price</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public double? SellPrice { get; set; }

                    /// <summary>
                    /// <para>tax</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public double? Tax { get; set; }

                }

                /// <summary>
                /// <para>RBD information in flight segment dimension</para>
                /// </summary>
                [NameInMap("flight_segment_cabin_relation")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation> FlightSegmentCabinRelation { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation : TeaModel {
                    /// <summary>
                    /// <para>RBD</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>cabin class</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>cabin class description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>economy class</para>
                    /// </summary>
                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <para>availability</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("cabin_quantity")]
                    [Validation(Required=false)]
                    public string CabinQuantity { get; set; }

                    /// <summary>
                    /// <para>segment ID format: flight no.+departure airport[IATA airport code]+arrival airport[IATA airport code]+departure time(yyMMddHHmm)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                }

                /// <summary>
                /// <para>passenger</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListPassenger : TeaModel {
                    /// <summary>
                    /// <para>date of birth (yyyyMMdd)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>travel document</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential : TeaModel {
                        /// <summary>
                        /// <para>place of issue, two-letter code</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>travel document number</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>travel document type , only support &quot;1&quot;(1 means passport) currently.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>expiration date</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>gender 0: MALE; 1: FEMALE</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>last name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>mobile country code</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>mobile phone number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>nationality (two-letter code)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>passenger type 0: adult; 1: child; 8: infant</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>ticketing airline</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO</para>
                /// </summary>
                [NameInMap("ticket_air_line")]
                [Validation(Required=false)]
                public string TicketAirLine { get; set; }

                /// <summary>
                /// <para>ticket number list</para>
                /// </summary>
                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

            /// <summary>
            /// <para>order number created by book</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>order status </para>
            /// <para>1: order creation in process; </para>
            /// <para>2: order creation successful; </para>
            /// <para>3: order paid; </para>
            /// <para>4: order successful; </para>
            /// <para>5: order closed</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>external order number(customized by buyer when book)</para>
            /// 
            /// <b>Example:</b>
            /// <para>x091-2023-0220-j-0001</para>
            /// </summary>
            [NameInMap("out_order_num")]
            [Validation(Required=false)]
            public string OutOrderNum { get; set; }

            /// <summary>
            /// <para>the information about all passenger of current order</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataPassengerList> PassengerList { get; set; }
            public class OrderDetailResponseBodyDataPassengerList : TeaModel {
                /// <summary>
                /// <para>date of birth (yyyyMMdd)</para>
                /// 
                /// <b>Example:</b>
                /// <para>20020301</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>travel document</para>
                /// </summary>
                [NameInMap("credential")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataPassengerListCredential Credential { get; set; }
                public class OrderDetailResponseBodyDataPassengerListCredential : TeaModel {
                    /// <summary>
                    /// <para>place of issue, two-letter code</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    /// <summary>
                    /// <para>travel document number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>E1***5674</para>
                    /// </summary>
                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    /// <summary>
                    /// <para>travel document type , only support &quot;1&quot;(1 means passport) currently.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("credential_type")]
                    [Validation(Required=false)]
                    public int? CredentialType { get; set; }

                    /// <summary>
                    /// <para>expiration date</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20290101</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                /// <summary>
                /// <para>first name</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAN</para>
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                /// <summary>
                /// <para>gender 0: MALE; 1: FEMALE</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>last name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// <para>mobile country code</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>mobile phone number</para>
                /// 
                /// <b>Example:</b>
                /// <para>183******96</para>
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                /// <summary>
                /// <para>nationality (two-letter code)</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>passenger type 0: adult; 1: child; 8: infant</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>payment status </para>
            /// <para>1: payment in process; </para>
            /// <para>2: deduction successful; </para>
            /// <para>3: paid to the seller; </para>
            /// <para>4: transaction closed</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>pay time(timestamp)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210788000</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// <para>discount amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public double? PromotionPrice { get; set; }

            /// <summary>
            /// <para>actual payment amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("real_pay_price")]
            [Validation(Required=false)]
            public double? RealPayPrice { get; set; }

            /// <summary>
            /// <para>change and refund policy mapping, key is passenger type, value is change and refund policy details</para>
            /// </summary>
            [NameInMap("refund_change_rule_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

            /// <summary>
            /// <para>buyer nickname</para>
            /// 
            /// <b>Example:</b>
            /// <para>nick</para>
            /// </summary>
            [NameInMap("session_nick")]
            [Validation(Required=false)]
            public string SessionNick { get; set; }

            /// <summary>
            /// <para>the solution buyer booked</para>
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public OrderDetailResponseBodyDataSolution Solution { get; set; }
            public class OrderDetailResponseBodyDataSolution : TeaModel {
                /// <summary>
                /// <para>adult fare</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>adult tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>child fare</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>child tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>infant fare</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>infant tax</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                /// <summary>
                /// <para>journey list</para>
                /// </summary>
                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionJourneyList> JourneyList { get; set; }
                public class OrderDetailResponseBodyDataSolutionJourneyList : TeaModel {
                    /// <summary>
                    /// <para>segment list</para>
                    /// </summary>
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<OrderDetailResponseBodyDataSolutionJourneyListSegmentList> SegmentList { get; set; }
                    public class OrderDetailResponseBodyDataSolutionJourneyListSegmentList : TeaModel {
                        /// <summary>
                        /// <para>arrival airport code (capitalized)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_airport")]
                        [Validation(Required=false)]
                        public string ArrivalAirport { get; set; }

                        /// <summary>
                        /// <para>arrival city code (capitalized)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_city")]
                        [Validation(Required=false)]
                        public string ArrivalCity { get; set; }

                        /// <summary>
                        /// <para>arrival terminal</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("arrival_terminal")]
                        [Validation(Required=false)]
                        public string ArrivalTerminal { get; set; }

                        /// <summary>
                        /// <para>arrival time in string format (yyyy-MM-dd HH:mm:ss)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 10:40:00</para>
                        /// </summary>
                        [NameInMap("arrival_time")]
                        [Validation(Required=false)]
                        public string ArrivalTime { get; set; }

                        /// <summary>
                        /// <para>availability</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// <para>RBD</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>cabin class</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>code share or not</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <para>departure airport code (capitalized)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("departure_airport")]
                        [Validation(Required=false)]
                        public string DepartureAirport { get; set; }

                        /// <summary>
                        /// <para>departure city code (capitalized)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("departure_city")]
                        [Validation(Required=false)]
                        public string DepartureCity { get; set; }

                        /// <summary>
                        /// <para>departure terminal</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("departure_terminal")]
                        [Validation(Required=false)]
                        public string DepartureTerminal { get; set; }

                        /// <summary>
                        /// <para>departure time in string format (yyyy-MM-dd HH:mm:ss)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 07:55:00</para>
                        /// </summary>
                        [NameInMap("departure_time")]
                        [Validation(Required=false)]
                        public string DepartureTime { get; set; }

                        /// <summary>
                        /// <para>equipment type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32Q</para>
                        /// </summary>
                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        /// <summary>
                        /// <para>flight time, unit: minute</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        /// <summary>
                        /// <para>marketing airline code (eg: KA)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("marketing_airline")]
                        [Validation(Required=false)]
                        public string MarketingAirline { get; set; }

                        /// <summary>
                        /// <para>marketing airline flight no. (eg: KA5809)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no")]
                        [Validation(Required=false)]
                        public string MarketingFlightNo { get; set; }

                        /// <summary>
                        /// <para>marketing airline flight no. (eg: 5809)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no_int")]
                        [Validation(Required=false)]
                        public int? MarketingFlightNoInt { get; set; }

                        /// <summary>
                        /// <para>operating airline code (eg: CX)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("operating_airline")]
                        [Validation(Required=false)]
                        public string OperatingAirline { get; set; }

                        /// <summary>
                        /// <para>operating airline flight no. (eg: CX601)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <para>segment ID format: flight no.+departure airport[IATA airport code]+arrival airport[IATA airport code]+departure time(MMdd)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295-PVG-MFM-20230310</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>stop city list when stop_quantity &gt; 1 , use “,” for seperation</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SEL,HKG</para>
                        /// </summary>
                        [NameInMap("stop_city_list")]
                        [Validation(Required=false)]
                        public string StopCityList { get; set; }

                        /// <summary>
                        /// <para>number of stops</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                    /// <summary>
                    /// <para>number of transfers</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_count")]
                    [Validation(Required=false)]
                    public int? TransferCount { get; set; }

                }

                /// <summary>
                /// <para>product type description</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("product_type_description")]
                [Validation(Required=false)]
                public string ProductTypeDescription { get; set; }

                /// <summary>
                /// <para>refund coupon description</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("refund_ticket_coupon_description")]
                [Validation(Required=false)]
                public string RefundTicketCouponDescription { get; set; }

                /// <summary>
                /// <para>through check-in baggage policy</para>
                /// </summary>
                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList : TeaModel {
                    /// <summary>
                    /// <para>through check-in baggage policy type</para>
                    /// <ol>
                    /// <item><description>baggage through check-in between segments</description></item>
                    /// <item><description>baggage re-check-in needed between segments</description></item>
                    /// <item><description>baggage through check-in at stop city ( applies for stop flight )</description></item>
                    /// <item><description>baggage re-checkin needed at stop city ( applies for stop flight )</description></item>
                    /// </ol>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    /// <summary>
                    /// <para>segment id list. all the listed segment ids share the same baggage through check-in policy</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>baggage rule list</para>
                /// </summary>
                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList : TeaModel {
                    /// <summary>
                    /// <para>baggage rule mapping, key is passenger type, value is baggage allowance details</para>
                    /// </summary>
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    /// <summary>
                    /// <para>segment id list. all the listed segment ids share the same baggage rule</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>change and refund policy</para>
                /// </summary>
                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList : TeaModel {
                    /// <summary>
                    /// <para>change and refund policy mapping, key is passenger type, value is change and refund policy details</para>
                    /// </summary>
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    /// <summary>
                    /// <para>segment id list. all the listed segment ids share the same change and refund policy</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>solution_id</para>
                /// 
                /// <b>Example:</b>
                /// <para>eJwz8DeySEo0NjQ01TU3TUxxx</para>
                /// </summary>
                [NameInMap("solution_id")]
                [Validation(Required=false)]
                public string SolutionId { get; set; }

            }

            /// <summary>
            /// <para>order success time(timestamp)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210786000</para>
            /// </summary>
            [NameInMap("succeed_time")]
            [Validation(Required=false)]
            public long? SucceedTime { get; set; }

            /// <summary>
            /// <para>total price of current order</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public double? TotalPrice { get; set; }

            /// <summary>
            /// <para>transaction number</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error data</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http reqeust has been processed successfully，status code is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
