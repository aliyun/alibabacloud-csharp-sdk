// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsrConfigResponseBodyData Data { get; set; }
        public class GetAsrConfigResponseBodyData : TeaModel {
            [NameInMap("AsrAcousticModelId")]
            [Validation(Required=false)]
            public string AsrAcousticModelId { get; set; }

            [NameInMap("AsrClassVocabularyId")]
            [Validation(Required=false)]
            public string AsrClassVocabularyId { get; set; }

            [NameInMap("AsrCustomizationId")]
            [Validation(Required=false)]
            public string AsrCustomizationId { get; set; }

            [NameInMap("AsrVocabularyId")]
            [Validation(Required=false)]
            public string AsrVocabularyId { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
