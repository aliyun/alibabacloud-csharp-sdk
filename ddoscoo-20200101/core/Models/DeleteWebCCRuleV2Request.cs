// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteWebCCRuleV2Request : TeaModel {
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
        /// The source of the rule. Valid values:
        /// 
        /// *   **manual** (default): manually created.
        /// *   **clover**: automatically created. Specify this value when you want to delete intelligent protection rules.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The names of the rules that you want to delete.
        /// </summary>
        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public string RuleNames { get; set; }

    }

}
