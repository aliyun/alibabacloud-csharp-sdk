// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsByApiResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficControlItems")]
        [Validation(Required=false)]
        public DescribeTrafficControlsByApiResponseBodyTrafficControlItems TrafficControlItems { get; set; }
        public class DescribeTrafficControlsByApiResponseBodyTrafficControlItems : TeaModel {
            [NameInMap("TrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem> TrafficControlItem { get; set; }
            public class DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem : TeaModel {
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("TrafficControlItemId")]
                [Validation(Required=false)]
                public string TrafficControlItemId { get; set; }

                [NameInMap("TrafficControlItemName")]
                [Validation(Required=false)]
                public string TrafficControlItemName { get; set; }

            }

        }

    }

}
