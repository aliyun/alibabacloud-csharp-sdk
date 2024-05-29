// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefenseObjectsRequest : TeaModel {
        /// <summary>
        /// The ID of the policy that you want to query.
        /// 
        /// > You can call the [DescribeSceneDefensePolicies](https://help.aliyun.com/document_detail/159382.html) operation to query the IDs of all policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not configure this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
