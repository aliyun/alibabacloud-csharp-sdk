// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// WB01014029
        /// </summary>
        [NameInMap("AegisClientOfflineCount")]
        [Validation(Required=false)]
        public int? AegisClientOfflineCount { get; set; }

        [NameInMap("AegisClientOnlineCount")]
        [Validation(Required=false)]
        public int? AegisClientOnlineCount { get; set; }

        /// <summary>
        /// Queries the security information about your assets. The information includes the security score and the numbers of protected and unprotected assets.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityScore")]
        [Validation(Required=false)]
        public int? SecurityScore { get; set; }

        /// <summary>
        /// DescribeSummaryInfo
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
