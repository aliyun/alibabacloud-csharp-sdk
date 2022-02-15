// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataShareInstancesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDataShareInstancesResponseBodyItems Items { get; set; }
        public class DescribeDataShareInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDataShareInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDataShareInstancesResponseBodyItemsDBInstance : TeaModel {
                public string DBInstanceId { get; set; }
                public string DBInstanceMode { get; set; }
                public string DataShareStatus { get; set; }
                public string Description { get; set; }
                public string RegionId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
