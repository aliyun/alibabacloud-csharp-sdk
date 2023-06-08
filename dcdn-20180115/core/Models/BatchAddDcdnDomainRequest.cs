// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchAddDcdnDomainRequest : TeaModel {
        /// <summary>
        /// The following table describes the fields in the Sources parameter.
        /// 
        /// | Field | Type | Required | Description |
        /// | ----- | ---- | -------- | ----------- |
        /// | type | String | Yes | The type of the origin server. Valid values: **ipaddr**: the IP address  
        /// 
        /// **domain**: the domain name  
        /// 
        /// **oss**: the endpoint of an Object Storage Service (OSS) bucket  
        /// 
        /// **fc_domain**: the domain name of Function Compute |
        /// | content | String | Yes | The address of the origin server. You can specify an IP address or a domain name. |
        /// | port | Integer | No | The port. Valid values: **80**: the default port  
        /// 
        /// **443**: the HTTPS port  
        /// 
        /// A custom port |
        /// | priority | String | No | The priority of the origin server if multiple origin servers are specified. Default value: 20. Valid values: **20**: the primary origin server  
        /// 
        /// **30**: the secondary origin server |
        /// | weight | String | No | The weight of the origin server if multiple origin servers are specified. Valid values: 0 to 100. Default value: 10. |
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// The top-level domain name.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Adds one or more domain names to Dynamic Route for CDN (DCDN).
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// **Prerequisites**:
        /// 
        /// *   The [DCDN service is activated](~~64926~~).
        /// *   Internet Content Provider (ICP) filing is complete for the accelerated domain names.
        /// 
        /// > 
        /// *   If the content of the origin server is not stored on Alibaba Cloud, the content must be reviewed. After you submit the request, the review is complete by the end of the following business day.
        /// *   The maximum number of domain names configured at a time is 50.
        /// *   The maximum number of times that each user can call this operation per second is 30.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
