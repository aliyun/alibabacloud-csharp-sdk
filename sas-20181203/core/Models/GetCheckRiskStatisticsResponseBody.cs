// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckRiskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of risk scenarios.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array consisting of the statistics on check items that are used in risk scenarios.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCheckRiskStatisticsResponseBodyData> Data { get; set; }
        public class GetCheckRiskStatisticsResponseBodyData : TeaModel {
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

            /// <summary>
            /// The number of passed check items.
            /// </summary>
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// The name of the risk scenario.
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The statistics on check items that are used in the risk scenario by baseline type.
            /// </summary>
            [NameInMap("SubStatistics")]
            [Validation(Required=false)]
            public List<GetCheckRiskStatisticsResponseBodyDataSubStatistics> SubStatistics { get; set; }
            public class GetCheckRiskStatisticsResponseBodyDataSubStatistics : TeaModel {
                /// <summary>
                /// The name of the baseline type.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

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

                /// <summary>
                /// The number of passed check items.
                /// </summary>
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                /// <summary>
                /// The total number of check items.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// The baseline type.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// The total number of check items.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
