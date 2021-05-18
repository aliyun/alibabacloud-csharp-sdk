// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleDiagnoseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTitleDiagnoseResponseBodyData Data { get; set; }
        public class GetTitleDiagnoseResponseBodyData : TeaModel {
            [NameInMap("DuplicateWords")]
            [Validation(Required=false)]
            public string DuplicateWords { get; set; }
            [NameInMap("ContainCoreClasses")]
            [Validation(Required=false)]
            public string ContainCoreClasses { get; set; }
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }
            [NameInMap("LanguageQualityScore")]
            [Validation(Required=false)]
            public string LanguageQualityScore { get; set; }
            [NameInMap("AllUppercaseWords")]
            [Validation(Required=false)]
            public string AllUppercaseWords { get; set; }
            [NameInMap("OverLengthLimit")]
            [Validation(Required=false)]
            public string OverLengthLimit { get; set; }
            [NameInMap("DisableWords")]
            [Validation(Required=false)]
            public string DisableWords { get; set; }
            [NameInMap("NoFirstUppercaseList")]
            [Validation(Required=false)]
            public string NoFirstUppercaseList { get; set; }
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public string TotalScore { get; set; }
            [NameInMap("WordSpelledCorrectError")]
            [Validation(Required=false)]
            public string WordSpelledCorrectError { get; set; }
        };

    }

}
