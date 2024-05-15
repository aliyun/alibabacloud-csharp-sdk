// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CheckGrantRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow Anti-DDoS Origin to check the service-linked role. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsSlr")]
        [Validation(Required=false)]
        public bool? IsSlr { get; set; }

        /// <summary>
        /// The ID of the region where the Anti-DDoS Origin instance resides.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
