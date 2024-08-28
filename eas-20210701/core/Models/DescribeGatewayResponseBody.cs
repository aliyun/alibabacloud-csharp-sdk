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
        /// The private gateway alias.
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// The instance type used for the private gateway.
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

        [NameInMap("InternetStatus")]
        [Validation(Required=false)]
        public string InternetStatus { get; set; }

        /// <summary>
        /// The internal endpoint.
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

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
        /// The state of the private gateway.
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
