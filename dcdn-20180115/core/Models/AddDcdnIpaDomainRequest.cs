// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class AddDcdnIpaDomainRequest : TeaModel {
        /// <summary>
        /// The URL that is used for health checks.
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// The domain name to be added to IPA.
        /// 
        /// A wildcard domain that starts with a period (.) is supported, such as .example.com.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **udp**
        /// *   **tcp**
        /// 
        /// **
        /// 
        /// **Description** For example: `{"protocol":"udp"}`.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify a value for this parameter, the system automatically assigns the ID of the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The acceleration region. Default value: domestic. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: outside the Chinese mainland
        /// *   **global**: global
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The information about the addresses of origin servers.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// The top-level domain.
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
