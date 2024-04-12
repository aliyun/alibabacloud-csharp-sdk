// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetDatabaseAccountResponseBody : TeaModel {
        [NameInMap("DatabaseAccount")]
        [Validation(Required=false)]
        public GetDatabaseAccountResponseBodyDatabaseAccount DatabaseAccount { get; set; }
        public class GetDatabaseAccountResponseBodyDatabaseAccount : TeaModel {
            [NameInMap("DatabaseAccountId")]
            [Validation(Required=false)]
            public string DatabaseAccountId { get; set; }

            [NameInMap("DatabaseAccountName")]
            [Validation(Required=false)]
            public string DatabaseAccountName { get; set; }

            [NameInMap("DatabaseSchema")]
            [Validation(Required=false)]
            public string DatabaseSchema { get; set; }

            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            [NameInMap("LoginAttribute")]
            [Validation(Required=false)]
            public string LoginAttribute { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
