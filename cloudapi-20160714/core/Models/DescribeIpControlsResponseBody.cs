// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlsResponseBody : TeaModel {
        [NameInMap("IpControlInfos")]
        [Validation(Required=false)]
        public DescribeIpControlsResponseBodyIpControlInfos IpControlInfos { get; set; }
        public class DescribeIpControlsResponseBodyIpControlInfos : TeaModel {
            [NameInMap("IpControlInfo")]
            [Validation(Required=false)]
            public List<DescribeIpControlsResponseBodyIpControlInfosIpControlInfo> IpControlInfo { get; set; }
            public class DescribeIpControlsResponseBodyIpControlInfosIpControlInfo : TeaModel {
                public string CreateTime { get; set; }
                public string Description { get; set; }
                public string IpControlId { get; set; }
                public string IpControlName { get; set; }
                public string IpControlType { get; set; }
                public string ModifiedTime { get; set; }
                public string RegionId { get; set; }
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
