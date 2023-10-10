// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// The action of the policy. Valid values:
        /// 
        /// *   `deny`: Deployments that match the policy are denied.
        /// *   `warn`: Alerts are generated for deployments that match the policy.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// The ID of the policy instance.
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The namespaces to which the policy is applied. The policy is applied to all namespaces if this parameter is left empty.
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// The parameters of the policy instance. For more information, see [Predefined security policies of ACK](~~359819~~).
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
