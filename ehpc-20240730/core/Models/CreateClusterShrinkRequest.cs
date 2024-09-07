// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        [NameInMap("Addons")]
        [Validation(Required=false)]
        public string AddonsShrink { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public string ClusterCredentialsShrink { get; set; }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public string ClusterCustomConfigurationShrink { get; set; }

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
        public string ManagerShrink { get; set; }

        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public string QueuesShrink { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public string SharedStoragesShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
