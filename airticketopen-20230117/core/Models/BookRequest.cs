// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public BookRequestContact Contact { get; set; }
        public class BookRequestContact : TeaModel {
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_order_num")]
        [Validation(Required=false)]
        public string OutOrderNum { get; set; }

        [NameInMap("passenger_ancillary_purchase_map_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerAncillaryPurchaseMapList> PassengerAncillaryPurchaseMapList { get; set; }
        public class BookRequestPassengerAncillaryPurchaseMapList : TeaModel {
            [NameInMap("book_ancillary_req_item")]
            [Validation(Required=false)]
            public BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem BookAncillaryReqItem { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListBookAncillaryReqItem : TeaModel {
                [NameInMap("ancillary_id")]
                [Validation(Required=false)]
                public string AncillaryId { get; set; }

                [NameInMap("ancillary_type")]
                [Validation(Required=false)]
                public int? AncillaryType { get; set; }

            }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<BookRequestPassengerAncillaryPurchaseMapListPassengerList> PassengerList { get; set; }
            public class BookRequestPassengerAncillaryPurchaseMapListPassengerList : TeaModel {
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("credential")]
                [Validation(Required=false)]
                public BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential Credential { get; set; }
                public class BookRequestPassengerAncillaryPurchaseMapListPassengerListCredential : TeaModel {
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    [NameInMap("credential_num")]
                    [Validation(Required=false)]
                    public string CredentialNum { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("credential_type")]
                    [Validation(Required=false)]
                    public int? CredentialType { get; set; }

                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("first_name")]
                [Validation(Required=false)]
                public string FirstName { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("last_name")]
                [Validation(Required=false)]
                public string LastName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<BookRequestPassengerList> PassengerList { get; set; }
        public class BookRequestPassengerList : TeaModel {
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("credential")]
            [Validation(Required=false)]
            public BookRequestPassengerListCredential Credential { get; set; }
            public class BookRequestPassengerListCredential : TeaModel {
                [NameInMap("cert_issue_place")]
                [Validation(Required=false)]
                public string CertIssuePlace { get; set; }

                [NameInMap("credential_num")]
                [Validation(Required=false)]
                public string CredentialNum { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("credential_type")]
                [Validation(Required=false)]
                public int? CredentialType { get; set; }

                [NameInMap("expire_date")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mobile_phone_number")]
            [Validation(Required=false)]
            public string MobilePhoneNumber { get; set; }

            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// solution_id
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
