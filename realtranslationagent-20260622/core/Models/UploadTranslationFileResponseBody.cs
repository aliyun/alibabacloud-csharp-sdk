// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class UploadTranslationFileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadTranslationFileResponseBodyData Data { get; set; }
        public class UploadTranslationFileResponseBodyData : TeaModel {
            [NameInMap("CreditBreakdown")]
            [Validation(Required=false)]
            public string CreditBreakdown { get; set; }

            [NameInMap("CreditsAvailable")]
            [Validation(Required=false)]
            public bool? CreditsAvailable { get; set; }

            [NameInMap("DetectedLang")]
            [Validation(Required=false)]
            public string DetectedLang { get; set; }

            [NameInMap("EstimatedCostCredits")]
            [Validation(Required=false)]
            public double? EstimatedCostCredits { get; set; }

            [NameInMap("EstimatedTime")]
            [Validation(Required=false)]
            public long? EstimatedTime { get; set; }

            [NameInMap("Fonts")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Fonts { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            [NameInMap("SensitiveDetected")]
            [Validation(Required=false)]
            public bool? SensitiveDetected { get; set; }

            [NameInMap("SensitiveTags")]
            [Validation(Required=false)]
            public List<string> SensitiveTags { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public long? WordCount { get; set; }

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
