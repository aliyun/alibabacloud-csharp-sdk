// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafOrderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafOrderResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafOrderResponseBodyResultObject : TeaModel {
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public long? ExpirationDate { get; set; }

        }

    }

}
