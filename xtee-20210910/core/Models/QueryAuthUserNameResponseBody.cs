// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class QueryAuthUserNameResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public QueryAuthUserNameResponseBodyResultObject ResultObject { get; set; }
        public class QueryAuthUserNameResponseBodyResultObject : TeaModel {
            [NameInMap("company")]
            [Validation(Required=false)]
            public string Company { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
