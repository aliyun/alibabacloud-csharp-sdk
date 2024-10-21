// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class LookupTmchNoticeResponseBody : TeaModel {
        [NameInMap("Claims")]
        [Validation(Required=false)]
        public LookupTmchNoticeResponseBodyClaims Claims { get; set; }
        public class LookupTmchNoticeResponseBodyClaims : TeaModel {
            [NameInMap("Claim")]
            [Validation(Required=false)]
            public List<LookupTmchNoticeResponseBodyClaimsClaim> Claim { get; set; }
            public class LookupTmchNoticeResponseBodyClaimsClaim : TeaModel {
                [NameInMap("ClassDescs")]
                [Validation(Required=false)]
                public LookupTmchNoticeResponseBodyClaimsClaimClassDescs ClassDescs { get; set; }
                public class LookupTmchNoticeResponseBodyClaimsClaimClassDescs : TeaModel {
                    [NameInMap("ClassDesc")]
                    [Validation(Required=false)]
                    public List<LookupTmchNoticeResponseBodyClaimsClaimClassDescsClassDesc> ClassDesc { get; set; }
                    public class LookupTmchNoticeResponseBodyClaimsClaimClassDescsClassDesc : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18</para>
                        /// </summary>
                        [NameInMap("ClassNum")]
                        [Validation(Required=false)]
                        public int? ClassNum { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>New Zealand</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                    }

                }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public LookupTmchNoticeResponseBodyClaimsClaimContacts Contacts { get; set; }
                public class LookupTmchNoticeResponseBodyClaimsClaimContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<LookupTmchNoticeResponseBodyClaimsClaimContactsContact> Contact { get; set; }
                    public class LookupTmchNoticeResponseBodyClaimsClaimContactsContact : TeaModel {
                        [NameInMap("Addr")]
                        [Validation(Required=false)]
                        public LookupTmchNoticeResponseBodyClaimsClaimContactsContactAddr Addr { get; set; }
                        public class LookupTmchNoticeResponseBodyClaimsClaimContactsContactAddr : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>NZ</para>
                            /// </summary>
                            [NameInMap("Cc")]
                            [Validation(Required=false)]
                            public string Cc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Auckland</para>
                            /// </summary>
                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1010</para>
                            /// </summary>
                            [NameInMap("Pc")]
                            [Validation(Required=false)]
                            public string Pc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Auckland</para>
                            /// </summary>
                            [NameInMap("Sp")]
                            [Validation(Required=false)]
                            public string Sp { get; set; }

                            [NameInMap("Street")]
                            [Validation(Required=false)]
                            public LookupTmchNoticeResponseBodyClaimsClaimContactsContactAddrStreet Street { get; set; }
                            public class LookupTmchNoticeResponseBodyClaimsClaimContactsContactAddrStreet : TeaModel {
                                [NameInMap("Street")]
                                [Validation(Required=false)]
                                public List<string> Street { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                        /// </summary>
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4472335**8</para>
                        /// </summary>
                        [NameInMap("Fax")]
                        [Validation(Required=false)]
                        public string Fax { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Tom</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Tom</para>
                        /// </summary>
                        [NameInMap("Org")]
                        [Validation(Required=false)]
                        public string Org { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>agent</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1390000****</para>
                        /// </summary>
                        [NameInMap("Voice")]
                        [Validation(Required=false)]
                        public string Voice { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Class 9: Calculators; bags, coverings,containers, carriers and holders for mobile phones, personal handheld computers and notebooks; headphones; speakers; blank storage media;batteries. Class 16: Paper</para>
                /// </summary>
                [NameInMap("GoodsAndServices")]
                [Validation(Required=false)]
                public string GoodsAndServices { get; set; }

                [NameInMap("Holders")]
                [Validation(Required=false)]
                public LookupTmchNoticeResponseBodyClaimsClaimHolders Holders { get; set; }
                public class LookupTmchNoticeResponseBodyClaimsClaimHolders : TeaModel {
                    [NameInMap("Holder")]
                    [Validation(Required=false)]
                    public List<LookupTmchNoticeResponseBodyClaimsClaimHoldersHolder> Holder { get; set; }
                    public class LookupTmchNoticeResponseBodyClaimsClaimHoldersHolder : TeaModel {
                        [NameInMap("Addr")]
                        [Validation(Required=false)]
                        public LookupTmchNoticeResponseBodyClaimsClaimHoldersHolderAddr Addr { get; set; }
                        public class LookupTmchNoticeResponseBodyClaimsClaimHoldersHolderAddr : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>NZ</para>
                            /// </summary>
                            [NameInMap("Cc")]
                            [Validation(Required=false)]
                            public string Cc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Wellington</para>
                            /// </summary>
                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>6011</para>
                            /// </summary>
                            [NameInMap("Pc")]
                            [Validation(Required=false)]
                            public string Pc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Wellington</para>
                            /// </summary>
                            [NameInMap("Sp")]
                            [Validation(Required=false)]
                            public string Sp { get; set; }

                            [NameInMap("Street")]
                            [Validation(Required=false)]
                            public LookupTmchNoticeResponseBodyClaimsClaimHoldersHolderAddrStreet Street { get; set; }
                            public class LookupTmchNoticeResponseBodyClaimsClaimHoldersHolderAddrStreet : TeaModel {
                                [NameInMap("Street")]
                                [Validation(Required=false)]
                                public List<string> Street { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>owner</para>
                        /// </summary>
                        [NameInMap("Entitlement")]
                        [Validation(Required=false)]
                        public string Entitlement { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Whitcoulls 2011 Limited</para>
                        /// </summary>
                        [NameInMap("Org")]
                        [Validation(Required=false)]
                        public string Org { get; set; }

                    }

                }

                [NameInMap("JurDesc")]
                [Validation(Required=false)]
                public LookupTmchNoticeResponseBodyClaimsClaimJurDesc JurDesc { get; set; }
                public class LookupTmchNoticeResponseBodyClaimsClaimJurDesc : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>New Zealand</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NZ</para>
                    /// </summary>
                    [NameInMap("JurCC")]
                    [Validation(Required=false)]
                    public string JurCC { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>POTED</para>
                /// </summary>
                [NameInMap("MarkName")]
                [Validation(Required=false)]
                public string MarkName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>586608000000</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>noted</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-10-15T00:00:00.0Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-10-13T00:00:00.0Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01C10C8E-0468-468C-BCD9-E709BDD0AE8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
