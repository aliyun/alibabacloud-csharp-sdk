// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAreaBlockSwitchRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable or disable the Location Blacklist (Domain Names) policy for a domain name. The value is a string that consists of a JSON struct. The JSON struct contains the following parameters:
        /// 
        /// *   **RegionblockEnable**: the status of the Location Blacklist (Domain Names) policy. This parameter is required and must be of the INTEGER type. Valid values:
        /// 
        ///     *   **1**: enables the policy.
        ///     *   **0**: disables the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The domain name for which you want to enable or disable the Location Blacklist policy.
        /// 
        /// > You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all the domain names that are added to Anti-DDoS Pro or Anti-DDoS Premium.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

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
