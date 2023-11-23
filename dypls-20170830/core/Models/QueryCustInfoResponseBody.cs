// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryCustInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryCustInfoResponseBodyData Data { get; set; }
        public class QueryCustInfoResponseBodyData : TeaModel {
            [NameInMap("CertifyType")]
            [Validation(Required=false)]
            public int? CertifyType { get; set; }

            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            [NameInMap("CustId")]
            [Validation(Required=false)]
            public long? CustId { get; set; }

            [NameInMap("CustName")]
            [Validation(Required=false)]
            public string CustName { get; set; }

            [NameInMap("IsDayuCustomer")]
            [Validation(Required=false)]
            public bool? IsDayuCustomer { get; set; }

            [NameInMap("OsStatus")]
            [Validation(Required=false)]
            public int? OsStatus { get; set; }

            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            [NameInMap("UserTag")]
            [Validation(Required=false)]
            public long? UserTag { get; set; }

            [NameInMap("UserTag2")]
            [Validation(Required=false)]
            public long? UserTag2 { get; set; }

        }

    }

}
