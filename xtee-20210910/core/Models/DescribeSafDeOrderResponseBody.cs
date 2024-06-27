// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafDeOrderResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafDeOrderResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafDeOrderResponseBodyResultObject : TeaModel {
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public long? ExpirationDate { get; set; }

            [NameInMap("openUserType")]
            [Validation(Required=false)]
            public int? OpenUserType { get; set; }

        }

    }

}
