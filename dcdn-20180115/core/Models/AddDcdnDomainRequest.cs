// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class AddDcdnDomainRequest : TeaModel {
        /// <summary>
        /// The URL that is used for health checks.
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// The domain name that you want to add. You can specify only one domain name in each request.
        /// 
        /// Wildcard domain names are supported. A wildcard domain name must start with a period (.), such as .example.com.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Computing service type. Valid values:
        /// 
        /// *   **routine**
        /// *   **image**
        /// *   **cloudFunction**
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the resource group. If you do not specify a value for this parameter, the system automatically assigns the ID of the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The Acceleration scen. Supported:
        /// 
        /// * apiscene:API acceleration.
        /// * webservicescene: accelerate website business.
        /// * staticscene: video and graphic acceleration.
        /// * (Empty): no scene.
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// The acceleration region. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: outside the Chinese mainland
        /// *   **global**: global
        /// 
        /// Default value: **domestic**.
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
        /// The information about the tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddDcdnDomainRequestTag> Tag { get; set; }
        public class AddDcdnDomainRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag. Valid values of N: **1 to 20**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag. Valid values of N: **1 to 20**.
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
