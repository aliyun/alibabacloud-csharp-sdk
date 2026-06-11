// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserByMobileAccountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserByMobileAccountResponseBodyResult Result { get; set; }
        public class QueryUserByMobileAccountResponseBodyResult : TeaModel {
            [NameInMap("BoundUserId")]
            [Validation(Required=false)]
            public string BoundUserId { get; set; }

            [NameInMap("ThirdAccountName")]
            [Validation(Required=false)]
            public string ThirdAccountName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
