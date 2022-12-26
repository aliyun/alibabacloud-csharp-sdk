// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckRiskStatisticsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCheckRiskStatisticsResponseBodyData> Data { get; set; }
        public class GetCheckRiskStatisticsResponseBodyData : TeaModel {
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("SubStatistics")]
            [Validation(Required=false)]
            public List<GetCheckRiskStatisticsResponseBodyDataSubStatistics> SubStatistics { get; set; }
            public class GetCheckRiskStatisticsResponseBodyDataSubStatistics : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("HighWarningCount")]
                [Validation(Required=false)]
                public int? HighWarningCount { get; set; }

                [NameInMap("LowWarningCount")]
                [Validation(Required=false)]
                public int? LowWarningCount { get; set; }

                [NameInMap("MediumWarningCount")]
                [Validation(Required=false)]
                public int? MediumWarningCount { get; set; }

                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
