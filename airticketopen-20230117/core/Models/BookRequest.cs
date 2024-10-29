// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookRequest : TeaModel {
        /// <summary>
        /// <para>contact information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public BookRequestContact Contact { get; set; }
        public class BookRequestContact : TeaModel {
            /// <summary>
            /// <para>email address</para>
            /// 
            /// <b>Example:</b>
            /// <para>gao******@gmail.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

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
            /// <para>last name</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>country code</para>
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
            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// <para>external order number(buyer customization)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x091-2023-0220-j-0001</para>
        /// </summary>
        [NameInMap("out_order_num")]
        [Validation(Required=false)]
        public string OutOrderNum { get; set; }

        /// <summary>
        /// <para>passenger-ancillary purchase relationship</para>
        /// </summary>
        [NameInMap("passenger_ancillary_purchase_map_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerAncillaryPurchaseMapList> PassengerAncillaryPurchaseMapList { get; set; }
        public class BookRequestPassengerAncillaryPurchaseMapList : TeaModel {
            /// <summary>
            /// <para>ancillary information</para>
            /// </summary>
            [NameInMap("book_ancillary_req_item")]
            [Validation(Required=false)]
            public BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem BookAncillaryReqItem { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem : TeaModel {
                /// <summary>
                /// <para>ancillary product ID, returned by AncillarySuggest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MDY2NTAxLCJleHAiOjE2NxNzM3MDEsIm5ix</para>
                /// </summary>
                [NameInMap("ancillary_id")]
                [Validation(Required=false)]
                public string AncillaryId { get; set; }

                /// <summary>
                /// <para>type of ancillary product, only support &quot;4&quot;(4 means paid baggage) currently.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ancillary_type")]
                [Validation(Required=false)]
                public int? AncillaryType { get; set; }

            }

            /// <summary>
            /// <para>passenger list for unified ancillary purchases</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<BookRequestPassengerAncillaryPurchaseMapListPassengerList> PassengerList { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListPassengerList : TeaModel {
                /// <summary>
                /// <para>date of birth (yyyyMMdd)</para>
                /// 
                /// <b>Example:</b>
                /// <para>20020320</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>travel document</para>
                /// </summary>
                [NameInMap("credential")]
                [Validation(Required=false)]
                public BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential Credential { get; set; }
                public class BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential : TeaModel {
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
                    /// <para>E1***5673</para>
                    /// </summary>
                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    /// <summary>
                    /// <para>travel document type , only support &quot;1&quot;(1 means passport) currently</para>
                    /// <para>This parameter is required.</para>
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
                    /// <para>20290102</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                /// <summary>
                /// <para>first name</para>
                /// <para>This parameter is required.</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>last name</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG</para>
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// <para>country code for mobile phone number</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <para>mobile phone number</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>182******92</para>
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
                /// <para>passenger type 0: adult; 1: child; 8: Infant</para>
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
        /// <para>passenger list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerList> PassengerList { get; set; }
        public class BookRequestPassengerList : TeaModel {
            /// <summary>
            /// <para>date of birth (yyyyMMdd)</para>
            /// 
            /// <b>Example:</b>
            /// <para>20200320</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>travel document</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public BookRequestPassengerListCredential Credential { get; set; }
            public class BookRequestPassengerListCredential : TeaModel {
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
                /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>mobile country code</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>mobile phone number</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183******95</para>
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
        /// <para>solution_id returned by Enrich</para>
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
