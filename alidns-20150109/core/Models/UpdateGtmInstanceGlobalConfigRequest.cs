// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmInstanceGlobalConfigRequest : TeaModel {
        /// <summary>
        /// The alert group of the GTM instance. Currently, only one alert group is supported.
        /// 
        /// >  This parameter is required for the first update, but is optional for later updates.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// The CNAME record of a domain name, which must be the primary domain name. When **CnameMode** is **CUSTOM**, this parameter is required for access.
        /// </summary>
        [NameInMap("CnameCustomDomainName")]
        [Validation(Required=false)]
        public string CnameCustomDomainName { get; set; }

        /// <summary>
        /// Specifies whether the CNAME record is user-defined or automatically assigned by the system. Valid values:
        /// 
        /// *   **SYSTEM_ASSIGN**: Assigned by the system
        /// *   **CUSTOM**: User-defined
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// The ID of the GTM instance whose configuration you want to modify.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the GTM instance.
        /// 
        /// >  This parameter is required for the first update, but is not required for later updates.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The load balancing policy. Valid values:
        /// 
        /// *   **ALL_RR**: Load balancing
        /// 
        /// *   **RATIO**: Weighted round robin
        /// 
        /// > This parameter is required for the first update, but is optional for later updates.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The time when the modification takes effect.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The primary domain name.
        /// 
        /// >  This parameter is required for the first update, but is optional for later updates.
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

    }

}
