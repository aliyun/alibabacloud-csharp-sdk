// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListDiagnoseInfoForSingleCardResponseBody : TeaModel {
        [NameInMap("DiagnoseInfo")]
        [Validation(Required=false)]
        public List<ListDiagnoseInfoForSingleCardResponseBodyDiagnoseInfo> DiagnoseInfo { get; set; }
        public class ListDiagnoseInfoForSingleCardResponseBodyDiagnoseInfo : TeaModel {
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("CardIp")]
            [Validation(Required=false)]
            public string CardIp { get; set; }

            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            [NameInMap("DiagnoseTaskId")]
            [Validation(Required=false)]
            public string DiagnoseTaskId { get; set; }

            [NameInMap("DiagnoseTime")]
            [Validation(Required=false)]
            public long? DiagnoseTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("IccId")]
            [Validation(Required=false)]
            public string IccId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WirelessCloudConnectorId")]
            [Validation(Required=false)]
            public string WirelessCloudConnectorId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
