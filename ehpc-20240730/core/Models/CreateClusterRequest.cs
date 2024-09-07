// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class CreateClusterRequestAdditionalPackages : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddons> Addons { get; set; }
        public class CreateClusterRequestAddons : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public string ResourcesSpec { get; set; }

            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public string ServicesSpec { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCredentials ClusterCredentials { get; set; }
        public class CreateClusterRequestClusterCredentials : TeaModel {
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class CreateClusterRequestClusterCustomConfiguration : TeaModel {
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        [NameInMap("Manager")]
        [Validation(Required=false)]
        public CreateClusterRequestManager Manager { get; set; }
        public class CreateClusterRequestManager : TeaModel {
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDNS DNS { get; set; }
            public class CreateClusterRequestManagerDNS : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDirectoryService DirectoryService { get; set; }
            public class CreateClusterRequestManagerDirectoryService : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public NodeTemplate ManagerNode { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerScheduler Scheduler { get; set; }
            public class CreateClusterRequestManagerScheduler : TeaModel {
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
        public int? MaxCoreCount { get; set; }

        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<QueueTemplate> Queues { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<SharedStorageTemplate> SharedStorages { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTags> Tags { get; set; }
        public class CreateClusterRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
