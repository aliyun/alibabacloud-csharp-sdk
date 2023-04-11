// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetProxyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the user who enabled the secure access proxy feature.
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// The nickname of the user who enabled the secure access proxy feature.
        /// </summary>
        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The port number used by the HTTPS protocol.
        /// </summary>
        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// Indicates whether the internal endpoint was enabled. Default value: **true**.
        /// </summary>
        [NameInMap("PrivateEnable")]
        [Validation(Required=false)]
        public bool? PrivateEnable { get; set; }

        /// <summary>
        /// The internal endpoint.
        /// </summary>
        [NameInMap("PrivateHost")]
        [Validation(Required=false)]
        public string PrivateHost { get; set; }

        /// <summary>
        /// The port number used by the protocol.
        /// </summary>
        [NameInMap("ProtocolPort")]
        [Validation(Required=false)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// The protocol type of the database. Example: MYSQL.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The ID of the secure access proxy.
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public long? ProxyId { get; set; }

        /// <summary>
        /// Indicates whether the public endpoint was enabled. Valid values:
        /// 
        /// *   **true**: The public endpoint was enabled.
        /// *   **false**: The public endpoint was disabled.
        /// </summary>
        [NameInMap("PublicEnable")]
        [Validation(Required=false)]
        public bool? PublicEnable { get; set; }

        /// <summary>
        /// The public endpoint. A public endpoint is returned no matter whether the public endpoint is enabled or disabled.
        /// 
        /// > 
        /// 
        /// *   If the value of the PublicEnable parameter is **true**, a valid public endpoint that can be resolved by using Alibaba Cloud DNS is returned.
        /// 
        /// *   If the value of the PublicEnable parameter is **false**, an invalid public endpoint that cannot be resolved by using Alibaba Cloud DNS is returned.
        /// </summary>
        [NameInMap("PublicHost")]
        [Validation(Required=false)]
        public string PublicHost { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
