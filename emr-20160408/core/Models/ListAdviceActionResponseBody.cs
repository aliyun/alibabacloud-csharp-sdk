// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListAdviceActionResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListAdviceActionResponseBodyItems Items { get; set; }
        public class ListAdviceActionResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListAdviceActionResponseBodyItemsItem> Item { get; set; }
            public class ListAdviceActionResponseBodyItemsItem : TeaModel {
                public string ActionType { get; set; }
                public string ClusterId { get; set; }
                public string Command { get; set; }
                public string Component { get; set; }
                public string ConfigItemKey { get; set; }
                public string ConfigName { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string HostgroupName { get; set; }
                public string ServiceName { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
