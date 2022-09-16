// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCustomizedListHeadersResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<DescribeCustomizedListHeadersResponseBodyHeaders> Headers { get; set; }
        public class DescribeCustomizedListHeadersResponseBodyHeaders : TeaModel {
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            [NameInMap("HeaderName")]
            [Validation(Required=false)]
            public string HeaderName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
