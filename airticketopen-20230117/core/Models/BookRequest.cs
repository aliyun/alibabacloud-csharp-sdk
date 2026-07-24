// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookRequest : TeaModel {
        /// <summary>
        /// <para>The contact information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public BookRequestContact Contact { get; set; }
        public class BookRequestContact : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gao******@gmail.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

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
            /// <para>The last name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>The country calling code.</para>
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
            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// <para>The external order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x091-2023-0220-j-0001</para>
        /// </summary>
        [NameInMap("out_order_num")]
        [Validation(Required=false)]
        public string OutOrderNum { get; set; }

        /// <summary>
        /// <para>The mapping between passengers and ancillary purchases.</para>
        /// </summary>
        [NameInMap("passenger_ancillary_purchase_map_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerAncillaryPurchaseMapList> PassengerAncillaryPurchaseMapList { get; set; }
        public class BookRequestPassengerAncillaryPurchaseMapList : TeaModel {
            /// <summary>
            /// <para>The ancillary product object for the booking request.</para>
            /// </summary>
            [NameInMap("book_ancillary_req_item")]
            [Validation(Required=false)]
            public BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem BookAncillaryReqItem { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem : TeaModel {
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
                /// <para>The ancillary product type. Currently supported value: 4 (paid baggage). More types will be supported in the future.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ancillary_type")]
                [Validation(Required=false)]
                public int? AncillaryType { get; set; }

            }

            /// <summary>
            /// <para>The list of passengers who purchase the same ancillary product.</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<BookRequestPassengerAncillaryPurchaseMapListPassengerList> PassengerList { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListPassengerList : TeaModel {
                /// <summary>
                /// <para>The date of birth in yyyyMMdd format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20020320</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>The credential information.</para>
                /// </summary>
                [NameInMap("credential")]
                [Validation(Required=false)]
                public BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential Credential { get; set; }
                public class BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential : TeaModel {
                    /// <summary>
                    /// <para>The place of issue. Use a two-letter country code.</para>
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
                    /// <para>E1***5673</para>
                    /// </summary>
                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    /// <summary>
                    /// <para>The credential type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: ID card</description></item>
                    /// <item><description>1: passport</description></item>
                    /// <item><description>2: student ID</description></item>
                    /// <item><description>3: military ID</description></item>
                    /// <item><description>4: Home Return Permit</description></item>
                    /// <item><description>5: Taiwan Compatriot Permit</description></item>
                    /// <item><description>6: Hong Kong and Macau Travel Permit</description></item>
                    /// <item><description>7: international seafarer certificate</description></item>
                    /// <item><description>8: foreigner permanent residence permit</description></item>
                    /// <item><description>10: police officer certificate</description></item>
                    /// <item><description>11: soldier certificate</description></item>
                    /// <item><description>12: Taiwan Travel Permit</description></item>
                    /// <item><description>13: Taiwan Entry Permit</description></item>
                    /// <item><description>14: household register</description></item>
                    /// <item><description>15: birth certificate</description></item>
                    /// <item><description>16: driver license</description></item>
                    /// <item><description>17: Hong Kong and Macau resident residence permit</description></item>
                    /// <item><description>18: Taiwan resident residence permit.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("credential_type")]
                    [Validation(Required=false)]
                    public int? CredentialType { get; set; }

                    /// <summary>
                    /// <para>The expiration date of the credential.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20290102</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                /// <summary>
                /// <para>The first name.</para>
                /// <para>This parameter is required.</para>
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
                /// <item><description>0: MALE</description></item>
                /// <item><description>1: FEMALE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The last name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// <para>The country calling code for the mobile phone number.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>The mobile phone number.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>182******92</para>
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                /// <summary>
                /// <para>The nationality.</para>
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
                /// <item><description>0: adult</description></item>
                /// <item><description>1: child</description></item>
                /// <item><description>8: infant.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of passengers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerList> PassengerList { get; set; }
        public class BookRequestPassengerList : TeaModel {
            /// <summary>
            /// <para>The date of birth in yyyyMMdd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20200320</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The credential information.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public BookRequestPassengerListCredential Credential { get; set; }
            public class BookRequestPassengerListCredential : TeaModel {
                /// <summary>
                /// <para>The place of issue. Use a two-letter country code.</para>
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
                /// <item><description>0: ID card</description></item>
                /// <item><description>1: passport</description></item>
                /// <item><description>4: Home Return Permit</description></item>
                /// <item><description>5: Taiwan Compatriot Permit</description></item>
                /// <item><description>6: Hong Kong and Macau Travel Permit</description></item>
                /// <item><description>12: Taiwan Travel Permit</description></item>
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
                /// <para>The expiration date of the credential.</para>
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
            /// <para>This parameter is required.</para>
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
            /// <item><description>0: MALE</description></item>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>The country calling code for the mobile phone number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>The mobile phone number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183******95</para>
            /// </summary>
            [NameInMap("mobile_phone_number")]
            [Validation(Required=false)]
            public string MobilePhoneNumber { get; set; }

            /// <summary>
            /// <para>The nationality. Use a two-letter country code.</para>
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
            /// <item><description>0: adult</description></item>
            /// <item><description>1: child</description></item>
            /// <item><description>8: infant.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>solution_id.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
