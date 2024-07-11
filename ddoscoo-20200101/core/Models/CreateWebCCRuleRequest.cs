// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateWebCCRuleRequest : TeaModel {
        /// <summary>
        /// The action on the requests that trigger the custom frequency control rule. Valid values:
        /// 
        /// *   **close**: blocks the requests.
        /// *   **captcha**: triggers Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Act")]
        [Validation(Required=false)]
        public string Act { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// >  A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The matching mode. Valid values:
        /// 
        /// *   **prefix**: prefix match.
        /// *   **match**: exact match.
        /// 
        /// >  If the **URI** of the check path contains parameters, you must set this parameter to **prefix**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The name of the rule. The name can be up to 128 characters in length and contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Proxy instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](https://help.aliyun.com/document_detail/94485.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The blocking duration. Valid values: **60** to **86400**. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The check path.
        /// 
        /// >  The URI cannot be modified. The domain name of the website, the check path, and the rule name uniquely identify a rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
