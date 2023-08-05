// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionSummaryResponseBody : TeaModel {
        /// <summary>
        /// The statistics.
        /// </summary>
        [NameInMap("InterceptionSummary")]
        [Validation(Required=false)]
        public GetInterceptionSummaryResponseBodyInterceptionSummary InterceptionSummary { get; set; }
        public class GetInterceptionSummaryResponseBodyInterceptionSummary : TeaModel {
            /// <summary>
            /// The number of clusters that are not protected.
            /// </summary>
            [NameInMap("CloseClusterCount")]
            [Validation(Required=false)]
            public int? CloseClusterCount { get; set; }

            /// <summary>
            /// The number of disabled cluster defense rules.
            /// </summary>
            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            /// <summary>
            /// The total number of clusters.
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// The total number of interception records for the specified cluster.
            /// </summary>
            [NameInMap("InterceptionCountInDays")]
            [Validation(Required=false)]
            public int? InterceptionCountInDays { get; set; }

            /// <summary>
            /// The number of clusters that are protected.
            /// </summary>
            [NameInMap("OpenClusterCount")]
            [Validation(Required=false)]
            public int? OpenClusterCount { get; set; }

            /// <summary>
            /// The number of enabled cluster defense rules.
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            /// <summary>
            /// The number of security risks that are detected in the last 180 days.
            /// </summary>
            [NameInMap("RiskCount180Day")]
            [Validation(Required=false)]
            public long? RiskCount180Day { get; set; }

            /// <summary>
            /// The number of security risks that are detected in the last 30 days.
            /// </summary>
            [NameInMap("RiskCount30Day")]
            [Validation(Required=false)]
            public long? RiskCount30Day { get; set; }

            /// <summary>
            /// The number of security risks that are detected in the last 24 hours.
            /// </summary>
            [NameInMap("RiskCountToday")]
            [Validation(Required=false)]
            public long? RiskCountToday { get; set; }

            /// <summary>
            /// The total number of cluster defense rules.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
