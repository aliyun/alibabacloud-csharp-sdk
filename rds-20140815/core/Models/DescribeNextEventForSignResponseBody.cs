// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeNextEventForSignResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeNextEventForSignResponseBodyEventItems EventItems { get; set; }
        public class DescribeNextEventForSignResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeNextEventForSignResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeNextEventForSignResponseBodyEventItemsEventItems : TeaModel {
                public int? EventId { get; set; }
                public string EventContent { get; set; }
            }
        };

    }

}
