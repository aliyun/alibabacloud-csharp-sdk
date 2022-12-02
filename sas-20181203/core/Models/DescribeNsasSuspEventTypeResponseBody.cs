// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNsasSuspEventTypeResponseBody : TeaModel {
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<DescribeNsasSuspEventTypeResponseBodyEventTypes> EventTypes { get; set; }
        public class DescribeNsasSuspEventTypeResponseBodyEventTypes : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SuspEventCount")]
            [Validation(Required=false)]
            public int? SuspEventCount { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
