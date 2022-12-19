// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineResponseBody : TeaModel {
        /// <summary>
        /// The number of bound servers.
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        /// <summary>
        /// The shortage in the quota for cores of servers that can be protected.
        /// </summary>
        [NameInMap("InsufficientCoreCount")]
        [Validation(Required=false)]
        public int? InsufficientCoreCount { get; set; }

        /// <summary>
        /// The shortage in the quota for servers that can be protected.
        /// </summary>
        [NameInMap("InsufficientEcsCount")]
        [Validation(Required=false)]
        public int? InsufficientEcsCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status code that indicates the result. Valid values:
        /// 
        /// *   **0**: The servers are bound to or unbound from Security Center.
        /// *   **1**: The values that you specified for the parameters are invalid.
        /// *   **2**: The quota for servers that can be protected is insufficient.
        /// *   **3**: The quota for cores of servers that can be protected is insufficient.
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// The number of unbound servers.
        /// </summary>
        [NameInMap("UnBindCount")]
        [Validation(Required=false)]
        public int? UnBindCount { get; set; }

    }

}
