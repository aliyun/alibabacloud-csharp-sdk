// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGatewayResponseBody : TeaModel {
        /// <summary>
        /// The time when the private gateway was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The ID of the self-managed cluster.
        /// </summary>
        [NameInMap("ExternalClusterId")]
        [Validation(Required=false)]
        public string ExternalClusterId { get; set; }

        /// <summary>
        /// The ID of the private gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// The alias of the private gateway.
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// The instance type used by the private gateway.
        /// 
        /// Valid values:
        /// 
        /// *   8c16g
        /// *   4c8g
        /// *   2c4g
        /// *   16c32g
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The public endpoint.
        /// </summary>
        [NameInMap("InternetDomain")]
        [Validation(Required=false)]
        public string InternetDomain { get; set; }

        /// <summary>
        /// Indicates whether Internet access is enabled.
        /// </summary>
        [NameInMap("InternetEnabled")]
        [Validation(Required=false)]
        public bool? InternetEnabled { get; set; }

        /// <summary>
        /// Indicates whether Internet access is enabled.
        /// 
        /// Valid values:
        /// 
        /// *   Creating: Internet access is being enabled.
        /// *   Failed: Internet access failed to be enabled or deleted.
        /// *   Running: Internet access is running.
        /// *   Deleted: Internet access is deleted.
        /// *   Deleting: Internet access is being deleted.
        /// </summary>
        [NameInMap("InternetStatus")]
        [Validation(Required=false)]
        public string InternetStatus { get; set; }

        /// <summary>
        /// The internal endpoint.
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        /// <summary>
        /// Indicates whether it is the default private gateway.
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The number of nodes in the private gateway.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the private gateway.
        /// 
        /// Valid values:
        /// 
        /// *   Creating
        /// *   Stopped
        /// *   Failed
        /// *   Running
        /// *   Deleted
        /// *   Deleting
        /// *   Waiting
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the private gateway was updated. The time is displayed in UTC.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
