// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeGroupedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeGroupedInstancesResponseBodyInstances : TeaModel {
            [NameInMap("AsapVulInstanceCount")]
            [Validation(Required=false)]
            public long? AsapVulInstanceCount { get; set; }

            [NameInMap("FieldAliasName")]
            [Validation(Required=false)]
            public string FieldAliasName { get; set; }

            [NameInMap("GroupFlag")]
            [Validation(Required=false)]
            public int? GroupFlag { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public string InstanceCount { get; set; }

            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public string RiskInstanceCount { get; set; }

            [NameInMap("UnProtectedInstanceCount")]
            [Validation(Required=false)]
            public string UnProtectedInstanceCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeGroupedInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeGroupedInstancesResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
