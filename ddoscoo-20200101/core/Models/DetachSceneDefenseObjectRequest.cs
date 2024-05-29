// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DetachSceneDefenseObjectRequest : TeaModel {
        /// <summary>
        /// The type of the object. Set the value to **Domain**, which indicates a domain name.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The protection asset that you want to remove from a policy. Separate multiple protection assets with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public string Objects { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// > You can call the [DescribeSceneDefensePolicies](https://help.aliyun.com/document_detail/159382.html) operation to query the IDs of all policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
