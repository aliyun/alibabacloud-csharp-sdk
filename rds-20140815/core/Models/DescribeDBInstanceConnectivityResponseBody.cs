// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceConnectivityResponseBody : TeaModel {
        /// <summary>
        /// The error code for connection diagnosis. Valid values:
        /// 
        /// *   **SRC_IP_NOT_IN_USER_WHITELIST**: The source IP address is not added to the whitelist.
        /// *   **CONNECTION_ABNORMAL**: The connection to the cluster is normal.
        /// </summary>
        [NameInMap("ConnCheckErrorCode")]
        [Validation(Required=false)]
        public string ConnCheckErrorCode { get; set; }

        /// <summary>
        /// The error message for connection diagnosis.
        /// </summary>
        [NameInMap("ConnCheckErrorMessage")]
        [Validation(Required=false)]
        public string ConnCheckErrorMessage { get; set; }

        /// <summary>
        /// The connection diagnosis result. Valid values:
        /// 
        /// *   **Success**
        /// *   **Failed**
        /// </summary>
        [NameInMap("ConnCheckResult")]
        [Validation(Required=false)]
        public string ConnCheckResult { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DbInstanceName")]
        [Validation(Required=false)]
        public string DbInstanceName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
