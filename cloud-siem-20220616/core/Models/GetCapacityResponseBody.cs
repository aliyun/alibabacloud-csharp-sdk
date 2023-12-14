// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetCapacityResponseBody : TeaModel {
        /// <summary>
        /// The information about the storage capacity.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCapacityResponseBodyData Data { get; set; }
        public class GetCapacityResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the Logstores for the threat analysis feature exist on the user side. Valid values:
            /// 
            /// *   true: The logs are in the normal state. The log analysis feature is available.
            /// *   false: The logs are being cleared. The log analysis feature is unavailable.
            /// </summary>
            [NameInMap("ExistLogStore")]
            [Validation(Required=false)]
            public bool? ExistLogStore { get; set; }

            /// <summary>
            /// The purchased storage capacity of the threat analysis feature. Unit: GB.
            /// </summary>
            [NameInMap("PreservedCapacity")]
            [Validation(Required=false)]
            public long? PreservedCapacity { get; set; }

            /// <summary>
            /// The billable storage capacity of the threat analysis feature. Unit: GB.
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public double? UsedCapacity { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
