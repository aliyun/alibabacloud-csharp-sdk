// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class DescribeSyncInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public DescribeSyncInfoResponseBodyInstanceInfo InstanceInfo { get; set; }
        public class DescribeSyncInfoResponseBodyInstanceInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }
            [NameInMap("ImageVersionName")]
            [Validation(Required=false)]
            public string ImageVersionName { get; set; }
            [NameInMap("PlanCode")]
            [Validation(Required=false)]
            public string PlanCode { get; set; }
            [NameInMap("EcsUuid")]
            [Validation(Required=false)]
            public string EcsUuid { get; set; }
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public int? AccessType { get; set; }
            [NameInMap("EcsStatus")]
            [Validation(Required=false)]
            public string EcsStatus { get; set; }
            [NameInMap("PlanUpgradeStatus")]
            [Validation(Required=false)]
            public int? PlanUpgradeStatus { get; set; }
            [NameInMap("ZoneNo")]
            [Validation(Required=false)]
            public string ZoneNo { get; set; }
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
            [NameInMap("EcsEip")]
            [Validation(Required=false)]
            public string EcsEip { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("EcsInternetIp")]
            [Validation(Required=false)]
            public string EcsInternetIp { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Renewable")]
            [Validation(Required=false)]
            public bool? Renewable { get; set; }
            [NameInMap("EcsIntranetIp")]
            [Validation(Required=false)]
            public string EcsIntranetIp { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public int? UpgradeStatus { get; set; }
            [NameInMap("PlanUpgradeable")]
            [Validation(Required=false)]
            public string PlanUpgradeable { get; set; }
            [NameInMap("CustomName")]
            [Validation(Required=false)]
            public string CustomName { get; set; }
            [NameInMap("EcsNetworkType")]
            [Validation(Required=false)]
            public string EcsNetworkType { get; set; }
            [NameInMap("PublicAccessControl")]
            [Validation(Required=false)]
            public int? PublicAccessControl { get; set; }
            [NameInMap("VendorCode")]
            [Validation(Required=false)]
            public string VendorCode { get; set; }
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
        };

    }

}
