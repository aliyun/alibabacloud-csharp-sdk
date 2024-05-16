/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class AddCdnDomainRequest : TeaModel {
        /// <summary>
        /// The workload type of the accelerated domain name. Valid values:
        /// 
        /// *   **web**: images and small files
        /// *   **download**: large files
        /// *   **video**: on-demand video and audio streaming
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CdnType")]
        [Validation(Required=false)]
        public string CdnType { get; set; }

        /// <summary>
        /// The URL that is used to check the accessibility of the origin server.
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// The domain name that you want to add to Alibaba Cloud CDN.
        /// 
        /// A wildcard domain that starts with a period (.) is supported, such as .example.com.
        /// 
        /// This parameter is required.
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
        /// The ID of the resource group.
        /// 
        /// If you do not set this parameter, the system uses the ID of the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The acceleration region. Default value: domestic. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: global (excluding the Chinese mainland)
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// Details about the tags. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddCdnDomainRequestTag> Tag { get; set; }
        public class AddCdnDomainRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. Valid values of N: **1 to 20**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. Valid values of N: **1 to 20**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The top-level domain.
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
