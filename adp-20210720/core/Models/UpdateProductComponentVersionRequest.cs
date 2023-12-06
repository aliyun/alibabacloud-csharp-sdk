// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateProductComponentVersionRequest : TeaModel {
        [NameInMap("componentOrchestrationValues")]
        [Validation(Required=false)]
        public string ComponentOrchestrationValues { get; set; }

        [NameInMap("componentSpecificationUid")]
        [Validation(Required=false)]
        public string ComponentSpecificationUid { get; set; }

        [NameInMap("componentSpecificationValues")]
        [Validation(Required=false)]
        public string ComponentSpecificationValues { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("newComponentVersionUID")]
        [Validation(Required=false)]
        public string NewComponentVersionUID { get; set; }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public UpdateProductComponentVersionRequestPolicy Policy { get; set; }
        public class UpdateProductComponentVersionRequestPolicy : TeaModel {
            [NameInMap("multiCluster")]
            [Validation(Required=false)]
            public UpdateProductComponentVersionRequestPolicyMultiCluster MultiCluster { get; set; }
            public class UpdateProductComponentVersionRequestPolicyMultiCluster : TeaModel {
                [NameInMap("autoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                [NameInMap("targetClusters")]
                [Validation(Required=false)]
                public List<string> TargetClusters { get; set; }

            }

        }

        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("unsetComponentVersionSpec")]
        [Validation(Required=false)]
        public bool? UnsetComponentVersionSpec { get; set; }

    }

}
