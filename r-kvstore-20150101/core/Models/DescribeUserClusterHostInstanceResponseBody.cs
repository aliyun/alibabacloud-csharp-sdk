// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeUserClusterHostInstanceResponseBody : TeaModel {
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("InstancesItems")]
        [Validation(Required=false)]
        public DescribeUserClusterHostInstanceResponseBodyInstancesItems InstancesItems { get; set; }
        public class DescribeUserClusterHostInstanceResponseBodyInstancesItems : TeaModel {
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<DescribeUserClusterHostInstanceResponseBodyInstancesItemsInstanceInfo> InstanceInfo { get; set; }
            public class DescribeUserClusterHostInstanceResponseBodyInstancesItemsInstanceInfo : TeaModel {
                public string InstanceClass { get; set; }
                public string CreateTime { get; set; }
                public string ZoneId { get; set; }
                public string InstanceStatus { get; set; }
                public string Engine { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string EngineVersion { get; set; }
                public string RegionId { get; set; }
                public string ClusterId { get; set; }
            }
        };

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("ItemNumbers")]
        [Validation(Required=false)]
        public int? ItemNumbers { get; set; }

    }

}
