// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
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

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }

            [NameInMap("IoTCloudConnectorId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
