// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterCheckItemWarningStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics on risk items by risk level.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClusterCheckItemWarningStatisticsResponseBodyData Data { get; set; }
        public class GetClusterCheckItemWarningStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of high-risk items.
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// The number of low-risk items.
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// The number of medium-risk items.
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
