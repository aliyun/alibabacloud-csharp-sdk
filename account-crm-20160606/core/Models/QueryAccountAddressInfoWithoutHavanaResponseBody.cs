// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountAddressInfoWithoutHavanaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ProfileInfo")]
        [Validation(Required=false)]
        public QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfo ProfileInfo { get; set; }
        public class QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfo : TeaModel {
            [NameInMap("AccountAttr")]
            [Validation(Required=false)]
            public string AccountAttr { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("Address2")]
            [Validation(Required=false)]
            public string Address2 { get; set; }

            [NameInMap("Address3")]
            [Validation(Required=false)]
            public string Address3 { get; set; }

            [NameInMap("Address4")]
            [Validation(Required=false)]
            public string Address4 { get; set; }

            [NameInMap("Address5")]
            [Validation(Required=false)]
            public string Address5 { get; set; }

            [NameInMap("Address6")]
            [Validation(Required=false)]
            public string Address6 { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfoCity City { get; set; }
            public class QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfoCity : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("HavanaId")]
            [Validation(Required=false)]
            public string HavanaId { get; set; }

            [NameInMap("PostCode")]
            [Validation(Required=false)]
            public string PostCode { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfoProvince Province { get; set; }
            public class QueryAccountAddressInfoWithoutHavanaResponseBodyProfileInfoProvince : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("TrueName")]
            [Validation(Required=false)]
            public string TrueName { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
