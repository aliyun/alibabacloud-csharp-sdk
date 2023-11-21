// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHADiagnoseConfigResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The availability check method of the instance. Valid values:
        /// 
        /// *   **LONG**: Alibaba Cloud uses persistent connections to check the availability of the instance.
        /// *   **SHORT**: Alibaba Cloud uses short-lived connections to check the availability of the instance.
        /// </summary>
        [NameInMap("TcpConnectionType")]
        [Validation(Required=false)]
        public string TcpConnectionType { get; set; }

    }

}
