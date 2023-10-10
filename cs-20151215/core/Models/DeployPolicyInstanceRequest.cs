// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeployPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// The action of the policy. Valid values:
        /// 
        /// *   `deny`: Deployments that match the policy are denied.
        /// *   `warn`: Alerts are generated for Deployments that match the policy.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// The applicable scope of the policy instance. If you leave this parameter empty, the policy instance is applicable to all namespaces.
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// The parameters of the policy instance.
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
