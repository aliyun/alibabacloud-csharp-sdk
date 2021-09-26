// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }
            [NameInMap("ImageVersionName")]
            [Validation(Required=false)]
            public string ImageVersionName { get; set; }
            [NameInMap("SeriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public int? AccessType { get; set; }
            [NameInMap("EcsStatus")]
            [Validation(Required=false)]
            public string EcsStatus { get; set; }
            [NameInMap("Operatable")]
            [Validation(Required=false)]
            public bool? Operatable { get; set; }
            [NameInMap("PlanUpgradeStatus")]
            [Validation(Required=false)]
            public int? PlanUpgradeStatus { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("Upgradeable")]
            [Validation(Required=false)]
            public bool? Upgradeable { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }
            [NameInMap("Renewable")]
            [Validation(Required=false)]
            public bool? Renewable { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public int? UpgradeStatus { get; set; }
            [NameInMap("PlanUpgradeable")]
            [Validation(Required=false)]
            public bool? PlanUpgradeable { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }
            [NameInMap("PublicAccessControl")]
            [Validation(Required=false)]
            public int? PublicAccessControl { get; set; }
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }
        };

    }

}
