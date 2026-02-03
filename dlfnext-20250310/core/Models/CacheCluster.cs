// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CacheCluster : TeaModel {
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("clusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("deployInstanceVersion")]
        [Validation(Required=false)]
        public string DeployInstanceVersion { get; set; }

        [NameInMap("deployOptionsVersion")]
        [Validation(Required=false)]
        public long? DeployOptionsVersion { get; set; }

        [NameInMap("instanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        [NameInMap("optionsVersion")]
        [Validation(Required=false)]
        public long? OptionsVersion { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

        [NameInMap("vSwitches")]
        [Validation(Required=false)]
        public List<CacheClusterVSwitches> VSwitches { get; set; }
        public class CacheClusterVSwitches : TeaModel {
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
