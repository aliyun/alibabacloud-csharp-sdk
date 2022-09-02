// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiTrafficControlsResponseBody : TeaModel {
        [NameInMap("ApiTrafficControls")]
        [Validation(Required=false)]
        public DescribeApiTrafficControlsResponseBodyApiTrafficControls ApiTrafficControls { get; set; }
        public class DescribeApiTrafficControlsResponseBodyApiTrafficControls : TeaModel {
            [NameInMap("ApiTrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem> ApiTrafficControlItem { get; set; }
            public class DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("TrafficControlId")]
                [Validation(Required=false)]
                public string TrafficControlId { get; set; }

                [NameInMap("TrafficControlName")]
                [Validation(Required=false)]
                public string TrafficControlName { get; set; }

            }

        }

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
