// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the policy template that you want to manage.
        /// 
        /// > You can call the [ListDefensePolicies](~~195814~~) operation to query the IDs of all policy templates.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public List<string> PolicyId { get; set; }

        /// <summary>
        /// The ID of the region where the automatic snapshot policy is created.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
