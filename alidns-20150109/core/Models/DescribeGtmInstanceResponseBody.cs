// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// The number of access policies of the GTM instance.
        /// </summary>
        [NameInMap("AccessStrategyNum")]
        [Validation(Required=false)]
        public int? AccessStrategyNum { get; set; }

        /// <summary>
        /// The number of address pools of the GTM instance.
        /// </summary>
        [NameInMap("AddressPoolNum")]
        [Validation(Required=false)]
        public int? AddressPoolNum { get; set; }

        /// <summary>
        /// The alert group of the GTM instance.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// The domain name of the GTM instance to which the service domain name is mapped by using a CNAME record.
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// Indicates whether the CNAME is a custom domain name or is assigned by the system. Valid values:
        /// 
        /// *   **SYSTEM_ASSIGN**
        /// *   **CUSTOM**
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// The time when the GTM instance was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the GTM instance was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The time when the GTM instance expires.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the GTM instance expires.
        /// </summary>
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// The ID of the GTM instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the GTM instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The load balancing policy. Valid values:
        /// 
        /// *   **ALL_RR**: round robin
        /// *   **RATIO**: weighted round-robin
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The global time to live (TTL).
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The domain name of the application.
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

        /// <summary>
        /// The version code.
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
