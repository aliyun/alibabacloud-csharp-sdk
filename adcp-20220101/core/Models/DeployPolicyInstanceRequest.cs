// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DeployPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the master instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// An array of JSON strings. The JSON strings in the array indicate the IDs of the associated clusters in which the policy instance is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// A list of namespaces.
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// The action of the policy. Valid values:
        /// 
        /// *   deny: blocks deployments that match the policy.
        /// *   warn: generates alerts for deployments that match the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// The name of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
