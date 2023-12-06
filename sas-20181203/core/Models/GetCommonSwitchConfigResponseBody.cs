// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommonSwitchConfigResponseBodyData Data { get; set; }
        public class GetCommonSwitchConfigResponseBodyData : TeaModel {
            /// <summary>
            /// Specifies whether to turn on the switch for newly added servers. Valid values:
            /// 
            /// *   **add**: By default, the switch is turned on for newly added servers.
            /// *   **del**: By default, the switch is turned off for newly added servers.
            /// </summary>
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            /// <summary>
            /// The status of the synchronization. Valid values:
            /// 
            /// *   **sync**: The modifications are being synchronized.
            /// *   **valid**: The modifications has taken effect.
            /// </summary>
            [NameInMap("TargetSyncStatus")]
            [Validation(Required=false)]
            public string TargetSyncStatus { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
