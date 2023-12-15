// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ValidateVpcConnectivityResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the API Gateway instance is connected to the port. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Connected")]
        [Validation(Required=false)]
        public bool? Connected { get; set; }

        /// <summary>
        /// Indicates whether the instance in the authorization is an ECS instance or an SLB instance when the instance ID in the authorization is an IP address. Valid values:
        /// 
        /// *   **ECS**
        /// *   **SLB**
        /// *   **INVALID**: The instance type corresponding to the IP address is invalid.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
