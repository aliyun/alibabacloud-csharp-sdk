// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        /// <summary>
        /// The list of SSL connections.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterSSLResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterSSLResponseBodyItems : TeaModel {
            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// The SSL connection string.
            /// </summary>
            [NameInMap("SSLConnectionString")]
            [Validation(Required=false)]
            public string SSLConnectionString { get; set; }

            /// <summary>
            /// Indicates whether SSL encryption is enabled. Valid values:
            /// 
            /// *   **Enabled**: SSL is enabled.
            /// *   **Disable**: SSL is disabled.
            /// </summary>
            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public string SSLEnabled { get; set; }

            /// <summary>
            /// The time when the server certificate expires. The time is in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SSLExpireTime")]
            [Validation(Required=false)]
            public string SSLExpireTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether automatic rotation of SSL certificates is enabled. Valid values:
        /// 
        /// *   **Enable**: The feature is enabled.
        /// *   **Disable**: The feature is disabled.
        /// 
        /// > This parameter is valid only for a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

    }

}
