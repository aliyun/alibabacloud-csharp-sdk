// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterResponseBodyClusterInfo : TeaModel {
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("Applications")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoApplications Applications { get; set; }
            public class DescribeClusterResponseBodyClusterInfoApplications : TeaModel {
                [NameInMap("ApplicationInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoApplicationsApplicationInfo> ApplicationInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoApplicationsApplicationInfo : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EcsChargeType")]
            [Validation(Required=false)]
            public string EcsChargeType { get; set; }

            [NameInMap("EcsInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoEcsInfo EcsInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoEcsInfo : TeaModel {
                [NameInMap("Compute")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoCompute Compute { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoCompute : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                [NameInMap("Login")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoLogin Login { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoLogin : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                [NameInMap("Manager")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoManager Manager { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoManager : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

            }

            [NameInMap("HaEnable")]
            [Validation(Required=false)]
            public bool? HaEnable { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("SccClusterId")]
            [Validation(Required=false)]
            public string SccClusterId { get; set; }

            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
