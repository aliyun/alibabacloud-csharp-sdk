// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyTlsConfigRequest : TeaModel {
        /// <summary>
        /// The details of the TLS policy. The value is a JSON string that contains the following fields:
        /// 
        /// *   **ssl_protocols**: the version of TLS. This field is required. Data type: string. Valid values:
        /// 
        ///     *   **tls1.0**: TLS 1.0 and later
        ///     *   **tls1.1**: TLS 1.1 and later
        ///     *   **tls1.2**: TLS 1.2 and later
        /// 
        /// *   **ssl_ciphers**: the type of the cipher suite. This field is required. Data type: string. Valid values:
        /// 
        ///     *   **all**: all cipher suites, which include strong and weak cipher suites
        ///     *   **improved**: enhanced cipher suites
        ///     *   **strong**: strong cipher suites
        ///     *   **default**: default cipher suites, which include only strong cipher suites
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
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
