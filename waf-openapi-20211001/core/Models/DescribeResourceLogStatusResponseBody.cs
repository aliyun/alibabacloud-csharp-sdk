// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeResourceLogStatusResponseBodyResult> Result { get; set; }
        public class DescribeResourceLogStatusResponseBodyResult : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
