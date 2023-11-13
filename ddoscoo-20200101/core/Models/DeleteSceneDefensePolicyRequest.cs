// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteSceneDefensePolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the policy that you want to delete.
        /// 
        /// > You can call the [DescribeSceneDefensePolicies](~~159382~~) operation to query the IDs of all policies.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
