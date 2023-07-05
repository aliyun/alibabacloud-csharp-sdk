// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CheckResourceSupportOperateRequest : TeaModel {
        /// <summary>
        /// The resource ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the service resource. Valid values:
        /// 
        /// *   **NLB**: a Network Load Balancer (NLB) instance
        /// *   **CLB**: a Classic Load Balancer (CLB) instance
        /// *   **ALB**: an Application Load Balancer (ALB) instance
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the zone where the service resource is deployed.
        /// 
        /// You can call the [DescribeZones](~~120502~~) operation to obtain the zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
