// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleDiagnoseResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetTitleDiagnoseResponseData Data { get; set; }
        public class GetTitleDiagnoseResponseData : TeaModel {
            [NameInMap("ContainCoreClasses")]
            [Validation(Required=true)]
            public string ContainCoreClasses { get; set; }
            [NameInMap("OverLengthLimit")]
            [Validation(Required=true)]
            public string OverLengthLimit { get; set; }
            [NameInMap("WordSpelledCorrectError")]
            [Validation(Required=true)]
            public string WordSpelledCorrectError { get; set; }
            [NameInMap("AllUppercaseWords")]
            [Validation(Required=true)]
            public string AllUppercaseWords { get; set; }
            [NameInMap("NoFirstUppercaseList")]
            [Validation(Required=true)]
            public string NoFirstUppercaseList { get; set; }
            [NameInMap("DuplicateWords")]
            [Validation(Required=true)]
            public string DuplicateWords { get; set; }
            [NameInMap("DisableWords")]
            [Validation(Required=true)]
            public string DisableWords { get; set; }
            [NameInMap("WordCount")]
            [Validation(Required=true)]
            public string WordCount { get; set; }
            [NameInMap("TotalScore")]
            [Validation(Required=true)]
            public string TotalScore { get; set; }
            [NameInMap("LanguageQualityScore")]
            [Validation(Required=true)]
            public string LanguageQualityScore { get; set; }
        };

    }

}
