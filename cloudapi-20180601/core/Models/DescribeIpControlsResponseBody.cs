// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

                [NameInMap("IpControlType")]
                [Validation(Required=false)]
                public string IpControlType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
