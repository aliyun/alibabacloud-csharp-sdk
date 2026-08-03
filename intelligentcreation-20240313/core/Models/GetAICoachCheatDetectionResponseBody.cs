// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachCheatDetectionResponseBody : TeaModel {
        [NameInMap("cheatId")]
        [Validation(Required=false)]
        public string CheatId { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("imageCheat")]
        [Validation(Required=false)]
        public GetAICoachCheatDetectionResponseBodyImageCheat ImageCheat { get; set; }
        public class GetAICoachCheatDetectionResponseBodyImageCheat : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyImageCheatList> List { get; set; }
            public class GetAICoachCheatDetectionResponseBodyImageCheatList : TeaModel {
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("voiceCheat")]
        [Validation(Required=false)]
        public GetAICoachCheatDetectionResponseBodyVoiceCheat VoiceCheat { get; set; }
        public class GetAICoachCheatDetectionResponseBodyVoiceCheat : TeaModel {
            [NameInMap("comparisonList")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyVoiceCheatComparisonList> ComparisonList { get; set; }
            public class GetAICoachCheatDetectionResponseBodyVoiceCheatComparisonList : TeaModel {
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("originalList")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyVoiceCheatOriginalList> OriginalList { get; set; }
            public class GetAICoachCheatDetectionResponseBodyVoiceCheatOriginalList : TeaModel {
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
