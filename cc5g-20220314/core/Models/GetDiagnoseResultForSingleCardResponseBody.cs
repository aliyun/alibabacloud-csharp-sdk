// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
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

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

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

            [NameInMap("SubItems")]
            [Validation(Required=false)]
            public List<GetDiagnoseResultForSingleCardResponseBodyDiagnoseItemSubItems> SubItems { get; set; }
            public class GetDiagnoseResultForSingleCardResponseBodyDiagnoseItemSubItems : TeaModel {
                [NameInMap("SubItem")]
                [Validation(Required=false)]
                public string SubItem { get; set; }

                [NameInMap("SubItemInfo")]
                [Validation(Required=false)]
                public string SubItemInfo { get; set; }

                [NameInMap("SubItemStatus")]
                [Validation(Required=false)]
                public string SubItemStatus { get; set; }

            }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ErrorResult")]
        [Validation(Required=false)]
        public List<GetDiagnoseResultForSingleCardResponseBodyErrorResult> ErrorResult { get; set; }
        public class GetDiagnoseResultForSingleCardResponseBodyErrorResult : TeaModel {
            [NameInMap("ErrorDesc")]
            [Validation(Required=false)]
            public string ErrorDesc { get; set; }

            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public string ErrorItem { get; set; }

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

        [NameInMap("IccId")]
        [Validation(Required=false)]
        public string IccId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
