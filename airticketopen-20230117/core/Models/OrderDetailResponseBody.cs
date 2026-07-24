// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderDetailResponseBodyData Data { get; set; }
        public class OrderDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ancillary product fulfillment details.</para>
            /// </summary>
            [NameInMap("ancillary_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataAncillaryItemDetailList> AncillaryItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataAncillaryItemDetailList : TeaModel {
                /// <summary>
                /// <para>The ancillary product details.</para>
                /// </summary>
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListAncillary Ancillary { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillary : TeaModel {
                    /// <summary>
                    /// <para>The ancillary product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MDY2NTAxLCJleHAiOjE2NxNzM3MDEsIm5ix</para>
                    /// </summary>
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    /// <summary>
                    /// <para>The ancillary product type. Currently supported value: 4 (paid baggage).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    /// <summary>
                    /// <para>The baggage ancillary details.</para>
                    /// </summary>
                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListAncillaryBaggageAncillary : TeaModel {
                        /// <summary>
                        /// <para>The number of baggage pieces. Valid values: 3, 2, 1, 0, and -2. A value of -2 indicates weight-based calculation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        /// <summary>
                        /// <para>The baggage weight, ranging from 0 to 50. When isAllWeight is set to true, this value represents the total weight of all pieces.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        /// <summary>
                        /// <para>The baggage weight unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KG</para>
                        /// </summary>
                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the weight represents the total weight of all baggage pieces.</para>
                        /// </summary>
                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        /// <summary>
                        /// <para>The total price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.0</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public double? Price { get; set; }

                    }

                }

                /// <summary>
                /// <para>The passenger information.</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataAncillaryItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataAncillaryItemDetailListPassenger : TeaModel {
                    /// <summary>
                    /// <para>The date of birth in yyyyMMdd format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>The credential information.</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataAncillaryItemDetailListPassengerCredential : TeaModel {
                        /// <summary>
                        /// <para>The place of issuance, represented as a two-letter code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>The credential number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>The credential type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: ID card.</description></item>
                        /// <item><description>1: passport.</description></item>
                        /// <item><description>4: Home Return Permit.</description></item>
                        /// <item><description>5: Mainland Travel Permit for Taiwan Residents.</description></item>
                        /// <item><description>6: Exit-Entry Permit for Hong Kong and Macao Residents.</description></item>
                        /// <item><description>12: Taiwan Travel Permit.</description></item>
                        /// <item><description>19: no credential.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>The credential expiration date.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>The first name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>The gender. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: MALE.</description></item>
                    /// <item><description>1: FEMALE.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>The last name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>The country code of the mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>The mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The two-letter nationality code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>The passenger type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: adult.</description></item>
                    /// <item><description>1: child.</description></item>
                    /// <item><description>8: infant.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>The segment IDs to which the ancillary product applies.</para>
                /// </summary>
                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            /// <summary>
            /// <para>The mapping of passenger types to baggage rules.</para>
            /// </summary>
            [NameInMap("baggage_allowance_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataBaggageAllowanceMapValue> BaggageAllowanceMap { get; set; }

            /// <summary>
            /// <para>The booking time (order creation time). The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210784000</para>
            /// </summary>
            [NameInMap("book_time")]
            [Validation(Required=false)]
            public long? BookTime { get; set; }

            /// <summary>
            /// <para>The flight ticket fulfillment details.</para>
            /// </summary>
            [NameInMap("flight_item_detail_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataFlightItemDetailList> FlightItemDetailList { get; set; }
            public class OrderDetailResponseBodyDataFlightItemDetailList : TeaModel {
                /// <summary>
                /// <para>The list of bPnr values.</para>
                /// </summary>
                [NameInMap("b_pnr_list")]
                [Validation(Required=false)]
                public List<string> BPnrList { get; set; }

                /// <summary>
                /// <para>The list of cPnr values.</para>
                /// </summary>
                [NameInMap("c_pnr_list")]
                [Validation(Required=false)]
                public List<string> CPnrList { get; set; }

                /// <summary>
                /// <para>The passenger price information.</para>
                /// </summary>
                [NameInMap("flight_price")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListFlightPrice FlightPrice { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightPrice : TeaModel {
                    /// <summary>
                    /// <para>The selling price. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public double? SellPrice { get; set; }

                    /// <summary>
                    /// <para>The tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public double? Tax { get; set; }

                }

                /// <summary>
                /// <para>The list of segment-cabin information.</para>
                /// </summary>
                [NameInMap("flight_segment_cabin_relation")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation> FlightSegmentCabinRelation { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListFlightSegmentCabinRelation : TeaModel {
                    /// <summary>
                    /// <para>The cabin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>The cabin class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The cabin class description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>economy class</para>
                    /// </summary>
                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <para>The number of available tickets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("cabin_quantity")]
                    [Validation(Required=false)]
                    public string CabinQuantity { get; set; }

                    /// <summary>
                    /// <para>The segment ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HO1295-PVG-MFM-20230310</para>
                    /// </summary>
                    [NameInMap("segment_id")]
                    [Validation(Required=false)]
                    public string SegmentId { get; set; }

                }

                /// <summary>
                /// <para>The passenger information.</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataFlightItemDetailListPassenger Passenger { get; set; }
                public class OrderDetailResponseBodyDataFlightItemDetailListPassenger : TeaModel {
                    /// <summary>
                    /// <para>The date of birth in yyyyMMdd format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20020301</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>The credential information.</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential Credential { get; set; }
                    public class OrderDetailResponseBodyDataFlightItemDetailListPassengerCredential : TeaModel {
                        /// <summary>
                        /// <para>The place of issuance, represented as a two-letter code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("cert_issue_place")]
                        [Validation(Required=false)]
                        public string CertIssuePlace { get; set; }

                        /// <summary>
                        /// <para>The credential number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>E1***5674</para>
                        /// </summary>
                        [NameInMap("credential_num")]
                        [Validation(Required=false)]
                        public string CredentialNum { get; set; }

                        /// <summary>
                        /// <para>The credential type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: ID card.</description></item>
                        /// <item><description>1: passport.</description></item>
                        /// <item><description>4: Home Return Permit.</description></item>
                        /// <item><description>5: Mainland Travel Permit for Taiwan Residents.</description></item>
                        /// <item><description>6: Exit-Entry Permit for Hong Kong and Macao Residents.</description></item>
                        /// <item><description>12: Taiwan Travel Permit.</description></item>
                        /// <item><description>19: no credential.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("credential_type")]
                        [Validation(Required=false)]
                        public int? CredentialType { get; set; }

                        /// <summary>
                        /// <para>The credential expiration date.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20290101</para>
                        /// </summary>
                        [NameInMap("expire_date")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                    }

                    /// <summary>
                    /// <para>The first name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>The gender. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: MALE.</description></item>
                    /// <item><description>1: FEMALE.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public int? Gender { get; set; }

                    /// <summary>
                    /// <para>The last name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>The country code of the mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("mobile_country_code")]
                    [Validation(Required=false)]
                    public string MobileCountryCode { get; set; }

                    /// <summary>
                    /// <para>The mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>183******96</para>
                    /// </summary>
                    [NameInMap("mobile_phone_number")]
                    [Validation(Required=false)]
                    public string MobilePhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The two-letter nationality code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    /// <summary>
                    /// <para>The passenger type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: adult.</description></item>
                    /// <item><description>1: child.</description></item>
                    /// <item><description>8: infant.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>The ticketing airline. Multiple ticketing airlines may be concatenated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO</para>
                /// </summary>
                [NameInMap("ticket_air_line")]
                [Validation(Required=false)]
                public string TicketAirLine { get; set; }

                /// <summary>
                /// <para>The list of ticket numbers.</para>
                /// </summary>
                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

            /// <summary>
            /// <para>The order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>The order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Booking in progress.</description></item>
            /// <item><description>2: Booking succeeded.</description></item>
            /// <item><description>3: Order paid.</description></item>
            /// <item><description>4: Order succeeded.</description></item>
            /// <item><description>5: Order closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The external order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x091-2023-0220-j-0001</para>
            /// </summary>
            [NameInMap("out_order_num")]
            [Validation(Required=false)]
            public string OutOrderNum { get; set; }

            /// <summary>
            /// <para>The passenger list.</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<OrderDetailResponseBodyDataPassengerList> PassengerList { get; set; }
            public class OrderDetailResponseBodyDataPassengerList : TeaModel {
                /// <summary>
                /// <para>The date of birth in yyyyMMdd format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20020301</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>The credential information.</para>
                /// </summary>
                [NameInMap("credential")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataPassengerListCredential Credential { get; set; }
                public class OrderDetailResponseBodyDataPassengerListCredential : TeaModel {
                    /// <summary>
                    /// <para>The place of issuance, represented as a two-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    /// <summary>
                    /// <para>The credential number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>E1***5674</para>
                    /// </summary>
                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    /// <summary>
                    /// <para>The credential type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: ID card.</description></item>
                    /// <item><description>1: passport.</description></item>
                    /// <item><description>4: Home Return Permit.</description></item>
                    /// <item><description>5: Mainland Travel Permit for Taiwan Residents.</description></item>
                    /// <item><description>6: Exit-Entry Permit for Hong Kong and Macao Residents.</description></item>
                    /// <item><description>12: Taiwan Travel Permit.</description></item>
                    /// <item><description>19: no credential.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("credential_type")]
                    [Validation(Required=false)]
                    public int? CredentialType { get; set; }

                    /// <summary>
                    /// <para>The credential expiration date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20290101</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                /// <summary>
                /// <para>The first name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAN</para>
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                /// <summary>
                /// <para>The gender. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: MALE.</description></item>
                /// <item><description>1: FEMALE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The last name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// <para>The country code of the mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>The mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>183******96</para>
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                /// <summary>
                /// <para>The two-letter nationality code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>The passenger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: adult.</description></item>
                /// <item><description>1: child.</description></item>
                /// <item><description>8: infant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The payment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Initialized.</description></item>
            /// <item><description>1: Created.</description></item>
            /// <item><description>2: Payment succeeded.</description></item>
            /// <item><description>4: Transaction closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The payment time. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210788000</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// <para>The discount amount. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("promotion_price")]
            [Validation(Required=false)]
            public double? PromotionPrice { get; set; }

            /// <summary>
            /// <para>The actual payment amount. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("real_pay_price")]
            [Validation(Required=false)]
            public double? RealPayPrice { get; set; }

            /// <summary>
            /// <para>The mapping of passenger types to refund and change rules.</para>
            /// </summary>
            [NameInMap("refund_change_rule_map")]
            [Validation(Required=false)]
            public Dictionary<string, DataRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

            /// <summary>
            /// <para>The buyer nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nick</para>
            /// </summary>
            [NameInMap("session_nick")]
            [Validation(Required=false)]
            public string SessionNick { get; set; }

            /// <summary>
            /// <para>The flight information.</para>
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public OrderDetailResponseBodyDataSolution Solution { get; set; }
            public class OrderDetailResponseBodyDataSolution : TeaModel {
                /// <summary>
                /// <para>The unit price for an adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("adult_price")]
                [Validation(Required=false)]
                public double? AdultPrice { get; set; }

                /// <summary>
                /// <para>The tax for an adult.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("adult_tax")]
                [Validation(Required=false)]
                public double? AdultTax { get; set; }

                /// <summary>
                /// <para>The unit price for a child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("child_price")]
                [Validation(Required=false)]
                public double? ChildPrice { get; set; }

                /// <summary>
                /// <para>The tax for a child.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("child_tax")]
                [Validation(Required=false)]
                public double? ChildTax { get; set; }

                /// <summary>
                /// <para>The unit price for an infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("infant_price")]
                [Validation(Required=false)]
                public double? InfantPrice { get; set; }

                /// <summary>
                /// <para>The tax for an infant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("infant_tax")]
                [Validation(Required=false)]
                public double? InfantTax { get; set; }

                /// <summary>
                /// <para>The journey list.</para>
                /// </summary>
                [NameInMap("journey_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionJourneyList> JourneyList { get; set; }
                public class OrderDetailResponseBodyDataSolutionJourneyList : TeaModel {
                    /// <summary>
                    /// <para>The segment information.</para>
                    /// </summary>
                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<OrderDetailResponseBodyDataSolutionJourneyListSegmentList> SegmentList { get; set; }
                    public class OrderDetailResponseBodyDataSolutionJourneyListSegmentList : TeaModel {
                        /// <summary>
                        /// <para>The three-letter IATA code of the arrival airport (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_airport")]
                        [Validation(Required=false)]
                        public string ArrivalAirport { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the arrival city (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MFM</para>
                        /// </summary>
                        [NameInMap("arrival_city")]
                        [Validation(Required=false)]
                        public string ArrivalCity { get; set; }

                        /// <summary>
                        /// <para>The arrival terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("arrival_terminal")]
                        [Validation(Required=false)]
                        public string ArrivalTerminal { get; set; }

                        /// <summary>
                        /// <para>The arrival date and time in string format (yyyy-MM-dd HH:mm:ss).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 10:40:00</para>
                        /// </summary>
                        [NameInMap("arrival_time")]
                        [Validation(Required=false)]
                        public string ArrivalTime { get; set; }

                        /// <summary>
                        /// <para>The number of remaining seats.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// <para>The cabin.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>The cabin class.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the flight is a codeshare flight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the departure airport (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PVG</para>
                        /// </summary>
                        [NameInMap("departure_airport")]
                        [Validation(Required=false)]
                        public string DepartureAirport { get; set; }

                        /// <summary>
                        /// <para>The three-letter IATA code of the departure city (uppercase).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHA</para>
                        /// </summary>
                        [NameInMap("departure_city")]
                        [Validation(Required=false)]
                        public string DepartureCity { get; set; }

                        /// <summary>
                        /// <para>The departure terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("departure_terminal")]
                        [Validation(Required=false)]
                        public string DepartureTerminal { get; set; }

                        /// <summary>
                        /// <para>The departure date and time in string format (yyyy-MM-dd HH:mm:ss).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-10 07:55:00</para>
                        /// </summary>
                        [NameInMap("departure_time")]
                        [Validation(Required=false)]
                        public string DepartureTime { get; set; }

                        /// <summary>
                        /// <para>The aircraft type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32Q</para>
                        /// </summary>
                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        /// <summary>
                        /// <para>The flight duration. Unit: minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>165</para>
                        /// </summary>
                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        /// <summary>
                        /// <para>The marketing airline code (for example, HO).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("marketing_airline")]
                        [Validation(Required=false)]
                        public string MarketingAirline { get; set; }

                        /// <summary>
                        /// <para>The marketing flight number (for example, HO1295).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no")]
                        [Validation(Required=false)]
                        public string MarketingFlightNo { get; set; }

                        /// <summary>
                        /// <para>The numeric marketing flight number (for example, 1295).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1295</para>
                        /// </summary>
                        [NameInMap("marketing_flight_no_int")]
                        [Validation(Required=false)]
                        public int? MarketingFlightNoInt { get; set; }

                        /// <summary>
                        /// <para>The operating airline code (for example, CX).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO</para>
                        /// </summary>
                        [NameInMap("operating_airline")]
                        [Validation(Required=false)]
                        public string OperatingAirline { get; set; }

                        /// <summary>
                        /// <para>The operating flight number (for example, CX601).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <para>The segment ID. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HO1295-PVG-MFM-20230310</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>The list of stopover cities. This parameter has a value when stopQuantity is greater than 0. Multiple cities are separated by commas.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SEL,HKG</para>
                        /// </summary>
                        [NameInMap("stop_city_list")]
                        [Validation(Required=false)]
                        public string StopCityList { get; set; }

                        /// <summary>
                        /// <para>The number of stopover cities.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of transfers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_count")]
                    [Validation(Required=false)]
                    public int? TransferCount { get; set; }

                }

                /// <summary>
                /// <para>The baggage through-check rules.</para>
                /// </summary>
                [NameInMap("segment_baggage_check_in_info_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList> SegmentBaggageCheckInInfoList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageCheckInInfoList : TeaModel {
                    /// <summary>
                    /// <para>The baggage through-check rule type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: baggage is checked through between segments.</description></item>
                    /// <item><description>2: baggage must be rechecked between segments.</description></item>
                    /// <item><description>3: baggage is checked through at stopover cities.</description></item>
                    /// <item><description>4: baggage must be rechecked at stopover cities.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info_type")]
                    [Validation(Required=false)]
                    public int? LuggageDirectInfoType { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs. These segments share the same baggage through-check rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>The complimentary baggage rules.</para>
                /// </summary>
                [NameInMap("segment_baggage_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList> SegmentBaggageMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentBaggageMappingList : TeaModel {
                    /// <summary>
                    /// <para>The mapping of passenger types to complimentary baggage allowances.</para>
                    /// </summary>
                    [NameInMap("passenger_baggage_allowance_mapping")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue> PassengerBaggageAllowanceMapping { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs. These segments share the same complimentary baggage rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                /// <summary>
                /// <para>The refund and change rules.</para>
                /// </summary>
                [NameInMap("segment_refund_change_rule_mapping_list")]
                [Validation(Required=false)]
                public List<OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList> SegmentRefundChangeRuleMappingList { get; set; }
                public class OrderDetailResponseBodyDataSolutionSegmentRefundChangeRuleMappingList : TeaModel {
                    /// <summary>
                    /// <para>The mapping of passenger types to refund and change rules.</para>
                    /// </summary>
                    [NameInMap("refund_change_rule_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue> RefundChangeRuleMap { get; set; }

                    /// <summary>
                    /// <para>The list of segment IDs. These segments share the same refund and change rule.</para>
                    /// </summary>
                    [NameInMap("segment_id_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentIdList { get; set; }

                }

                [NameInMap("solution_attribute")]
                [Validation(Required=false)]
                public OrderDetailResponseBodyDataSolutionSolutionAttribute SolutionAttribute { get; set; }
                public class OrderDetailResponseBodyDataSolutionSolutionAttribute : TeaModel {
                    [NameInMap("issue_time_info")]
                    [Validation(Required=false)]
                    public OrderDetailResponseBodyDataSolutionSolutionAttributeIssueTimeInfo IssueTimeInfo { get; set; }
                    public class OrderDetailResponseBodyDataSolutionSolutionAttributeIssueTimeInfo : TeaModel {
                        [NameInMap("issue_ticket_type")]
                        [Validation(Required=false)]
                        public int? IssueTicketType { get; set; }

                        [NameInMap("issue_time_limit")]
                        [Validation(Required=false)]
                        public int? IssueTimeLimit { get; set; }

                    }

                    [NameInMap("supply_source_type")]
                    [Validation(Required=false)]
                    public string SupplySourceType { get; set; }

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
            /// <para>The ticketing time. The value is a 13-digit timestamp. This parameter has a value only after ticketing is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677210786000</para>
            /// </summary>
            [NameInMap("succeed_time")]
            [Validation(Required=false)]
            public long? SucceedTime { get; set; }

            /// <summary>
            /// <para>The total order price. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public double? TotalPrice { get; set; }

            /// <summary>
            /// <para>The transaction number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
