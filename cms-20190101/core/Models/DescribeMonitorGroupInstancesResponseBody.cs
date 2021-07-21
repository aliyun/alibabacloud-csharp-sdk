// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupInstancesResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupInstancesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupInstancesResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupInstancesResponseBodyResourcesResource : TeaModel {
                public string Category { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public long? Id { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
