// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribePolarxDbInstancesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribePolarxDbInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribePolarxDbInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribePolarxDbInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribePolarxDbInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                public string Status { get; set; }
                public string ExpireTime { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public string DBType { get; set; }
                public string LockMode { get; set; }
                public string VPCId { get; set; }
                public string RegionId { get; set; }
                public string Network { get; set; }
                public string DBVersion { get; set; }
                public string Description { get; set; }
                public string NodeClass { get; set; }
                public int? StorageUsed { get; set; }
                public int? NodeCount { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceId { get; set; }
                public string Engine { get; set; }
                public string LockReason { get; set; }
                public string StatusDesc { get; set; }
            }
        };

    }

}
