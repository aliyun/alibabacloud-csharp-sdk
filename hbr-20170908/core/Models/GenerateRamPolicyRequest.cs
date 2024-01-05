// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GenerateRamPolicyRequest : TeaModel {
        /// <summary>
        /// The type of the policy that you want to generate. Valid values:
        /// 
        /// *   custom: custom policy
        /// *   system: system policy
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// Specifies whether to generate the policy based on an existing instance-specific rule. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireBasePolicy")]
        [Validation(Required=false)]
        public bool? RequireBasePolicy { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
