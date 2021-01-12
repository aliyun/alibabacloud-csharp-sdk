// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSignedEventActionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageEventId")]
        [Validation(Required=false)]
        public int? NextPageEventId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("FromBegin")]
        [Validation(Required=false)]
        public bool? FromBegin { get; set; }

        [NameInMap("ToEnd")]
        [Validation(Required=false)]
        public bool? ToEnd { get; set; }

        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeSignedEventActionsResponseBodyEventItems EventItems { get; set; }
        public class DescribeSignedEventActionsResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeSignedEventActionsResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeSignedEventActionsResponseBodyEventItemsEventItems : TeaModel {
                public int? EventId { get; set; }
                public string EventContent { get; set; }
                public string EventSig { get; set; }
                public string EventRcpt { get; set; }
            }
        };

    }

}
