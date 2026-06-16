// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultRequest : TeaModel {
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        [NameInMap("UniqueTagList")]
        [Validation(Required=false)]
        public List<GetAlertRecordAnalysisResultRequestUniqueTagList> UniqueTagList { get; set; }
        public class GetAlertRecordAnalysisResultRequestUniqueTagList : TeaModel {
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            [NameInMap("ChooseLike")]
            [Validation(Required=false)]
            public bool? ChooseLike { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

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

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
