// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAIProtectModeRequest : TeaModel {
        /// <summary>
        /// The details of the Intelligent Protection policy. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **AiTemplate**: the level of the Intelligent Protection policy. This field is required and must be of the STRING type. Valid values:
        /// 
        ///     *   **level30**: the Low level
        ///     *   **level60**: the Normal level
        ///     *   **level90**: the Strict level
        /// 
        /// *   **AiMode**: the mode of the Intelligent Protection policy. This field is required and must be of the string type. Valid values:
        /// 
        ///     *   **watch**: the Warning mode
        ///     *   **defense**: the Defense mode
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for a domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
