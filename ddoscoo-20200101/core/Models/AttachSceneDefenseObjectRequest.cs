// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AttachSceneDefenseObjectRequest : TeaModel {
        /// <summary>
        /// The type of the object. Set the value to **Domain**, which indicates a domain name.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The object that you want to add to the policy. Separate multiple objects with commas (,).
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public string Objects { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// > You can call the [DescribeSceneDefensePolicies](~~159382~~) operation to query the IDs of all policies.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
