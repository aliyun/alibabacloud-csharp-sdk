// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterResponseBodyClusterInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }
            [NameInMap("EcsChargeType")]
            [Validation(Required=false)]
            public string EcsChargeType { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("SccClusterId")]
            [Validation(Required=false)]
            public string SccClusterId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }
            [NameInMap("HaEnable")]
            [Validation(Required=false)]
            public bool? HaEnable { get; set; }
            [NameInMap("BaseOsTag")]
            [Validation(Required=false)]
            public string BaseOsTag { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("PostInstallScripts")]
            [Validation(Required=false)]
            public List<DescribeClusterResponseBodyClusterInfoPostInstallScripts> PostInstallScripts { get; set; }
            public class DescribeClusterResponseBodyClusterInfoPostInstallScripts : TeaModel {
                public string Args { get; set; }
                public string Url { get; set; }
            }
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }
            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("EcsInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoEcsInfo EcsInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoEcsInfo : TeaModel {
                [NameInMap("Manager")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoManager Manager { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoManager : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }
                };

                [NameInMap("Compute")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoCompute Compute { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoCompute : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }
                };

                [NameInMap("Login")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoLogin Login { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoLogin : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }
                };

            }
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<DescribeClusterResponseBodyClusterInfoApplications> Applications { get; set; }
            public class DescribeClusterResponseBodyClusterInfoApplications : TeaModel {
                public string Version { get; set; }
                public string Tag { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
