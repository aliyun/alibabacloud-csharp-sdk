// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheResponseBody : TeaModel {
        [NameInMap("GlobalDistributeCaches")]
        [Validation(Required=false)]
        public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches> GlobalDistributeCaches { get; set; }
        public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches : TeaModel {
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubInstances")]
            [Validation(Required=false)]
            public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances> SubInstances { get; set; }
            public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances : TeaModel {
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

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

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
