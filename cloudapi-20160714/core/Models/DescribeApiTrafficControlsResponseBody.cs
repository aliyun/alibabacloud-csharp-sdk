// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiTrafficControlsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ApiTrafficControls")]
        [Validation(Required=false)]
        public DescribeApiTrafficControlsResponseBodyApiTrafficControls ApiTrafficControls { get; set; }
        public class DescribeApiTrafficControlsResponseBodyApiTrafficControls : TeaModel {
            [NameInMap("ApiTrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem> ApiTrafficControlItem { get; set; }
            public class DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem : TeaModel {
                public string BoundTime { get; set; }
                public string ApiId { get; set; }
                public string TrafficControlId { get; set; }
                public string TrafficControlName { get; set; }
                public string ApiName { get; set; }
            }
        };

    }

}
