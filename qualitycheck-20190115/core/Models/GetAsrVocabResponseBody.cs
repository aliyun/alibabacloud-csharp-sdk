// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetAsrVocabResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsrVocabResponseBodyData Data { get; set; }
        public class GetAsrVocabResponseBodyData : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public GetAsrVocabResponseBodyDataWords Words { get; set; }
            public class GetAsrVocabResponseBodyDataWords : TeaModel {
                [NameInMap("Word")]
                [Validation(Required=false)]
                public List<GetAsrVocabResponseBodyDataWordsWord> Word { get; set; }
                public class GetAsrVocabResponseBodyDataWordsWord : TeaModel {
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

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
