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
                        [NameInMap("ClassNum")]
                        [Validation(Required=false)]
                        public int? ClassNum { get; set; }

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
                            [NameInMap("Cc")]
                            [Validation(Required=false)]
                            public string Cc { get; set; }

                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            [NameInMap("Pc")]
                            [Validation(Required=false)]
                            public string Pc { get; set; }

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

                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }

                        [NameInMap("Fax")]
                        [Validation(Required=false)]
                        public string Fax { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Org")]
                        [Validation(Required=false)]
                        public string Org { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Voice")]
                        [Validation(Required=false)]
                        public string Voice { get; set; }

                    }

                }

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
                            [NameInMap("Cc")]
                            [Validation(Required=false)]
                            public string Cc { get; set; }

                            [NameInMap("City")]
                            [Validation(Required=false)]
                            public string City { get; set; }

                            [NameInMap("Pc")]
                            [Validation(Required=false)]
                            public string Pc { get; set; }

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

                        [NameInMap("Entitlement")]
                        [Validation(Required=false)]
                        public string Entitlement { get; set; }

                        [NameInMap("Org")]
                        [Validation(Required=false)]
                        public string Org { get; set; }

                    }

                }

                [NameInMap("JurDesc")]
                [Validation(Required=false)]
                public LookupTmchNoticeResponseBodyClaimsClaimJurDesc JurDesc { get; set; }
                public class LookupTmchNoticeResponseBodyClaimsClaimJurDesc : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("JurCC")]
                    [Validation(Required=false)]
                    public string JurCC { get; set; }

                }

                [NameInMap("MarkName")]
                [Validation(Required=false)]
                public string MarkName { get; set; }

            }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
