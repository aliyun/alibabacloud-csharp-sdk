// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBinarySecurityPolicyRequest : TeaModel {
        /// <summary>
        /// The information about the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The content of the policy. Specify a value in the JSON format. You can specify the following keys:
        /// 
        /// *   **policyMode**: the type of the policy. Default value: requireAttestor.
        /// *   **requiredAttestors**: the required witnesses.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The status of the policy. Valid values:
        /// 
        /// *   **enable**
        /// *   **disable**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
