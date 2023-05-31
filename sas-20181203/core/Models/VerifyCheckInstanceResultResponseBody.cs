// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyCheckInstanceResultResponseBodyData Data { get; set; }
        public class VerifyCheckInstanceResultResponseBodyData : TeaModel {
            /// <summary>
            /// An array consisting of instances that failed the check.
            /// </summary>
            [NameInMap("FailInstances")]
            [Validation(Required=false)]
            public List<string> FailInstances { get; set; }

            /// <summary>
            /// The operation code of the task that checks the configurations of cloud services. Valid values:
            /// 
            /// *   **Throttling**
            /// *   **ActionTrialUnauthorized**
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
