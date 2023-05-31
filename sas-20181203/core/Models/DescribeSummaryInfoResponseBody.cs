// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// The number of unprotected assets.
        /// </summary>
        [NameInMap("AegisClientOfflineCount")]
        [Validation(Required=false)]
        public int? AegisClientOfflineCount { get; set; }

        /// <summary>
        /// The number of protected assets.
        /// </summary>
        [NameInMap("AegisClientOnlineCount")]
        [Validation(Required=false)]
        public int? AegisClientOnlineCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The security score of the assets. Valid values:
        /// 
        /// *   95 to 100: The assets are secure.
        /// *   85 to 94: The assets are exposed to a few security risks. We recommend that you reinforce your security system in a timely manner.
        /// *   70 to 84: The assets are exposed to multiple security risks. We recommend that you reinforce your security system in a timely manner.
        /// *   69 or lower: The current security system is unable to protect the assets against intrusions. We recommend that you reinforce your security system at the earliest opportunity.
        /// </summary>
        [NameInMap("SecurityScore")]
        [Validation(Required=false)]
        public int? SecurityScore { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
