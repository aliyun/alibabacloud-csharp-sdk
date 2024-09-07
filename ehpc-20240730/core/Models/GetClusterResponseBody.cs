// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetClusterResponseBody : TeaModel {
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        [NameInMap("ClusterCreateTime")]
        [Validation(Required=false)]
        public string ClusterCreateTime { get; set; }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public GetClusterResponseBodyClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class GetClusterResponseBodyClusterCustomConfiguration : TeaModel {
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        [NameInMap("ClusterModifyTime")]
        [Validation(Required=false)]
        public string ClusterModifyTime { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        [NameInMap("Manager")]
        [Validation(Required=false)]
        public GetClusterResponseBodyManager Manager { get; set; }
        public class GetClusterResponseBodyManager : TeaModel {
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDNS DNS { get; set; }
            public class GetClusterResponseBodyManagerDNS : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDirectoryService DirectoryService { get; set; }
            public class GetClusterResponseBodyManagerDirectoryService : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerManagerNode ManagerNode { get; set; }
            public class GetClusterResponseBodyManagerManagerNode : TeaModel {
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerScheduler Scheduler { get; set; }
            public class GetClusterResponseBodyManagerScheduler : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public string MaxCoreCount { get; set; }

        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public string MaxCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
