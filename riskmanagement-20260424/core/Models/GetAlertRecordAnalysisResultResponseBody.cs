// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlertRecordAnalysisResultResponseBodyData Data { get; set; }
        public class GetAlertRecordAnalysisResultResponseBodyData : TeaModel {
            [NameInMap("AnalysisCode")]
            [Validation(Required=false)]
            public string AnalysisCode { get; set; }

            [NameInMap("UniqueTagList")]
            [Validation(Required=false)]
            public List<GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList> UniqueTagList { get; set; }
            public class GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList : TeaModel {
                [NameInMap("AlarmUniqueInfo")]
                [Validation(Required=false)]
                public string AlarmUniqueInfo { get; set; }

                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                [NameInMap("AnalysisCode")]
                [Validation(Required=false)]
                public string AnalysisCode { get; set; }

                [NameInMap("AnalysisResult")]
                [Validation(Required=false)]
                public string AnalysisResult { get; set; }

                [NameInMap("ChooseLike")]
                [Validation(Required=false)]
                public bool? ChooseLike { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("MachineInstanceId")]
                [Validation(Required=false)]
                public string MachineInstanceId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UniqueInfo")]
                [Validation(Required=false)]
                public string UniqueInfo { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
