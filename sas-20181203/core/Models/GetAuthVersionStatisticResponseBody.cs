// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthVersionStatisticResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics about the numbers of assets protected by each edition of Security Center.
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<GetAuthVersionStatisticResponseBodyStatistics> Statistics { get; set; }
        public class GetAuthVersionStatisticResponseBodyStatistics : TeaModel {
            /// <summary>
            /// The edition of Security Center. Valid values:
            /// 
            /// *   **1**: Basic edition (Unauthorized)
            /// *   **6**: Anti-virus edition
            /// *   **5**: Advanced edition
            /// *   **3**: Enterprise edition
            /// *   **7**: Ultimate edition
            /// *   **10**: Value-added Plan edition
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// The number of authorized servers.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

    }

}
