// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
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
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

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
