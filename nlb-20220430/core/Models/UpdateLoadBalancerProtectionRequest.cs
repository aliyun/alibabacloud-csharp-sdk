// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateLoadBalancerProtectionRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        [NameInMap("DeletionProtectionReason")]
        [Validation(Required=false)]
        public string DeletionProtectionReason { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
