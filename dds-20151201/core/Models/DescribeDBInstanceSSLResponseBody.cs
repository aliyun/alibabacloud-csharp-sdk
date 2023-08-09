// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// The name of the SSL certificate.
        /// </summary>
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the SSL certificate expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in Coordinated Universal Time (UTC).
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

        /// <summary>
        /// The status of the SSL feature. Valid values:
        /// 
        /// *   **Open**: The SSL feature is enabled.
        /// *   **Closed**: The SSL feature is disabled.
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public string SSLStatus { get; set; }

    }

}
