// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiIpControlsResponseBody : TeaModel {
        [NameInMap("ApiIpControls")]
        [Validation(Required=false)]
        public DescribeApiIpControlsResponseBodyApiIpControls ApiIpControls { get; set; }
        public class DescribeApiIpControlsResponseBodyApiIpControls : TeaModel {
            [NameInMap("ApiIpControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem> ApiIpControlItem { get; set; }
            public class DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string BoundTime { get; set; }
                public string IpControlId { get; set; }
                public string IpControlName { get; set; }
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
