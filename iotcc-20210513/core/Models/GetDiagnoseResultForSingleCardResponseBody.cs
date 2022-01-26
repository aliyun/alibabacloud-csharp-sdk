// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class GetDiagnoseResultForSingleCardResponseBody : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("CardIp")]
        [Validation(Required=false)]
        public string CardIp { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DiagnoseItem")]
        [Validation(Required=false)]
        public List<GetDiagnoseResultForSingleCardResponseBodyDiagnoseItem> DiagnoseItem { get; set; }
        public class GetDiagnoseResultForSingleCardResponseBodyDiagnoseItem : TeaModel {
            [NameInMap("Part")]
            [Validation(Required=false)]
            public string Part { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ErrorResult")]
        [Validation(Required=false)]
        public List<GetDiagnoseResultForSingleCardResponseBodyErrorResult> ErrorResult { get; set; }
        public class GetDiagnoseResultForSingleCardResponseBodyErrorResult : TeaModel {
            [NameInMap("ErrorDes")]
            [Validation(Required=false)]
            public string ErrorDes { get; set; }

            [NameInMap("ErrorLevel")]
            [Validation(Required=false)]
            public string ErrorLevel { get; set; }

            [NameInMap("ErrorPart")]
            [Validation(Required=false)]
            public string ErrorPart { get; set; }

            [NameInMap("ErrorSuggestion")]
            [Validation(Required=false)]
            public string ErrorSuggestion { get; set; }

        }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
