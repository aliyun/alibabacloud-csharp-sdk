// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeApiGroupsResponseBody : TeaModel {
        [NameInMap("ApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribeApiGroupsResponseBodyApiGroupAttributes ApiGroupAttributes { get; set; }
        public class DescribeApiGroupsResponseBodyApiGroupAttributes : TeaModel {
            [NameInMap("ApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute> ApiGroupAttribute { get; set; }
            public class DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute : TeaModel {
                [NameInMap("BillingStatus")]
                [Validation(Required=false)]
                public string BillingStatus { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("IllegalStatus")]
                [Validation(Required=false)]
                public string IllegalStatus { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                [NameInMap("TrafficLimit")]
                [Validation(Required=false)]
                public int? TrafficLimit { get; set; }

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
