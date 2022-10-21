// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<NodeGroupConfig> NodeGroups { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
