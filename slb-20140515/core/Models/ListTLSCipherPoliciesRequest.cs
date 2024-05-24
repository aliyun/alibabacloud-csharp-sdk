// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ListTLSCipherPoliciesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the information about the associated listeners. Valid values:
        /// 
        /// *   **true**: returns the information about the associated listeners.
        /// *   **false** (default): does not return the information about the associated listeners.
        /// </summary>
        [NameInMap("IncludeListener")]
        [Validation(Required=false)]
        public bool? IncludeListener { get; set; }

        /// <summary>
        /// The maximum number of TLS policies to be queried in this call. Valid values: **1** to **100**. If you do not set this parameter, the default value **20** is used.
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// The name of the TLS policy. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first query or no next query is to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the TLS policy.
        /// </summary>
        [NameInMap("TLSCipherPolicyId")]
        [Validation(Required=false)]
        public string TLSCipherPolicyId { get; set; }

    }

}
