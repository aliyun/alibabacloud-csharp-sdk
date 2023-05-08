// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckResultResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyCheckResultResponseBodyData Data { get; set; }
        public class VerifyCheckResultResponseBodyData : TeaModel {
            /// <summary>
            /// The operation code of the cloud service configuration task. Valid values:
            /// 
            /// *   **Throttling**: frequency limit
            /// *   **ActionTrialUnauthorized**: an error that is related to unauthorized operations
            /// </summary>
            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
