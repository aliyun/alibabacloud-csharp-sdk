// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20210416.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            [NameInMap("InstancePurchaseStorage")]
            [Validation(Required=false)]
            public long? InstancePurchaseStorage { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("InstanceTotalStorage")]
            [Validation(Required=false)]
            public long? InstanceTotalStorage { get; set; }
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceConnectionQuota")]
            [Validation(Required=false)]
            public int? InstanceConnectionQuota { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("InstanceDatabaseQuota")]
            [Validation(Required=false)]
            public long? InstanceDatabaseQuota { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("SeriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }
            [NameInMap("InstanceConnectionMaxBandwidth")]
            [Validation(Required=false)]
            public int? InstanceConnectionMaxBandwidth { get; set; }
            [NameInMap("InstanceConnections")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributeInstanceConnections> InstanceConnections { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributeInstanceConnections : TeaModel {
                public string VpcId { get; set; }
                public int? InstanceConnectionBandwidth { get; set; }
                public string InstanceConnectionDomain { get; set; }
                public List<string> SecurityGroupIds { get; set; }
                public List<string> VswitchIds { get; set; }
            }
        };

    }

}
