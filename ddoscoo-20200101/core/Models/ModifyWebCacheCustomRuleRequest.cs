// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebCacheCustomRuleRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name, and the domain name must be associated with an instance that uses the Enhanced function plan. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
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

        /// <summary>
        /// The details of the custom rule. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **Name**: the name of the rule. This field is required and must be of the string type.
        /// 
        /// *   **Uri**: the path to the cached page. This field is required and must be of the STRING type.
        /// 
        /// *   **Mode**: the cache mode. This field is required and must be of the STRING type. Valid values:
        /// 
        ///     *   **standard**: uses the standard mode.
        ///     *   **aggressive**: uses the enhanced mode.
        ///     *   **bypass**: No data is cached.
        /// 
        /// *   **CacheTtl**: the expiration time of the page cache. This field is required and must be of the INTEGER type. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
