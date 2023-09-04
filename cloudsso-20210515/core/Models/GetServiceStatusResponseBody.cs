// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status information of CloudSSO.
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public GetServiceStatusResponseBodyServiceStatus ServiceStatus { get; set; }
        public class GetServiceStatusResponseBodyServiceStatus : TeaModel {
            /// <summary>
            /// The ID of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// Indicates whether you have permissions to enable CloudSSO. Valid values:
            /// 
            /// *   Success: You have permissions to enable CloudSSO.
            /// *   Failed: You do not have permissions to enable CloudSSO.
            /// 
            /// >  The value of this parameter is returned only if the value of `Status` is `Disabled`.
            /// </summary>
            [NameInMap("PrerequisiteCheckResult")]
            [Validation(Required=false)]
            public string PrerequisiteCheckResult { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionsInUse")]
            [Validation(Required=false)]
            public List<string> RegionsInUse { get; set; }

            /// <summary>
            /// Indicates whether CloudSSO is enabled. Valid values:
            /// 
            /// *   Enabled
            /// *   Disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
