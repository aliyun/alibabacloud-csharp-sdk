// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DeletePolicyInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the master instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// A array of JSON strings. The JSON strings in the array indicate the IDs of the associated clusters for which the policy is deleted.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

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
