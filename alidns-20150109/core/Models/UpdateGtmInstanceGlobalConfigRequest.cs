// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmInstanceGlobalConfigRequest : TeaModel {
        /// <summary>
        /// The alert group. Only one alert group is supported.
        /// 
        /// >  This parameter is required only for the first modification.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// If you set **CnameMode** to **CUSTOM**, you must specify the CnameCustomDomainName parameter, which must be set to a primary domain name.
        /// </summary>
        [NameInMap("CnameCustomDomainName")]
        [Validation(Required=false)]
        public string CnameCustomDomainName { get; set; }

        /// <summary>
        /// Specifies whether to use a system-assigned canonical name (CNAME) or a custom CNAME to access GTM. Valid values:
        /// 
        /// *   **SYSTEM_ASSIGN**: system-assigned CNAME
        /// *   **CUSTOM**: custom CNAME
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// The ID of the GTM instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the GTM instance.
        /// 
        /// >  This parameter is required only for the first modification.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The balancing policy. Valid values:
        /// 
        /// *   **ALL_RR**: load balancing
        /// *   **RATIO**: weighted round-robin
        /// 
        /// >  This parameter is required only for the first modification.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The global time-to-live (TTL).
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The primary domain name.
        /// 
        /// >  This parameter is required only for the first modification.
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

    }

}
