// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigDomainSecurityProfileRequest : TeaModel {
        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// The configurations for the global mitigation policy feature. The configurations include the following fields:
        /// 
        /// *   **global_rule_mode**: optional. The mode for the global mitigation policy feature. Data type: string. Valid values:
        /// 
        ///     *   **weak**: loose.
        ///     *   **default**: normal.
        ///     *   **hard**: strict.
        /// 
        /// *   **global_rule_enable**: optional. Specifies whether to enable the global mitigation policy feature. Data type: string. Valid values:
        /// 
        ///     *   **0**: disabled.
        ///     *   **1**: enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

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

    }

}
