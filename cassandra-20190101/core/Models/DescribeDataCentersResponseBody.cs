// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeDataCentersResponseBody : TeaModel {
        [NameInMap("DataCenters")]
        [Validation(Required=false)]
        public DescribeDataCentersResponseBodyDataCenters DataCenters { get; set; }
        public class DescribeDataCentersResponseBodyDataCenters : TeaModel {
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public List<DescribeDataCentersResponseBodyDataCentersDataCenter> DataCenter { get; set; }
            public class DescribeDataCentersResponseBodyDataCentersDataCenter : TeaModel {
                [NameInMap("AutoRenewPeriod")]
                [Validation(Required=false)]
                public int? AutoRenewPeriod { get; set; }

                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CommodityInstance")]
                [Validation(Required=false)]
                public string CommodityInstance { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DataCenterId")]
                [Validation(Required=false)]
                public string DataCenterId { get; set; }

                [NameInMap("DataCenterName")]
                [Validation(Required=false)]
                public string DataCenterName { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
