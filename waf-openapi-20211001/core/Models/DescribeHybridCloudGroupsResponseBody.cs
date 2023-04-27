// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeHybridCloudGroupsResponseBodyGroups : TeaModel {
            [NameInMap("BackSourceMark")]
            [Validation(Required=false)]
            public string BackSourceMark { get; set; }

            [NameInMap("ContinentsValue")]
            [Validation(Required=false)]
            public int? ContinentsValue { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("LoadBalanceIp")]
            [Validation(Required=false)]
            public string LoadBalanceIp { get; set; }

            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public long? LocationId { get; set; }

            [NameInMap("OperatorValue")]
            [Validation(Required=false)]
            public int? OperatorValue { get; set; }

            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }

            [NameInMap("RegionCodeValue")]
            [Validation(Required=false)]
            public int? RegionCodeValue { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
