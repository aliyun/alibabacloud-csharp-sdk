// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeStsGrantStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StsGrant")]
        [Validation(Required=false)]
        public DescribeStsGrantStatusResponseBodyStsGrant StsGrant { get; set; }
        public class DescribeStsGrantStatusResponseBodyStsGrant : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
        };

    }

}
