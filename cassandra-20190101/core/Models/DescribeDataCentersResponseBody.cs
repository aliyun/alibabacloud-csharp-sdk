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
                public string Status { get; set; }
                public string VpcId { get; set; }
                public string VswitchId { get; set; }
                public string ExpireTime { get; set; }
                public int? DiskSize { get; set; }
                public string PayType { get; set; }
                public string DiskType { get; set; }
                public string InstanceType { get; set; }
                public string LockMode { get; set; }
                public int? AutoRenewPeriod { get; set; }
                public string RegionId { get; set; }
                public bool? AutoRenewal { get; set; }
                public string CommodityInstance { get; set; }
                public int? NodeCount { get; set; }
                public string DataCenterName { get; set; }
                public string ZoneId { get; set; }
                public string CreatedTime { get; set; }
                public string ClusterId { get; set; }
                public string DataCenterId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
