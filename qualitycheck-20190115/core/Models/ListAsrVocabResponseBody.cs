// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListAsrVocabResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAsrVocabResponseBodyData Data { get; set; }
        public class ListAsrVocabResponseBodyData : TeaModel {
            [NameInMap("AsrVocab")]
            [Validation(Required=false)]
            public List<ListAsrVocabResponseBodyDataAsrVocab> AsrVocab { get; set; }
            public class ListAsrVocabResponseBodyDataAsrVocab : TeaModel {
                public string VocabularyId { get; set; }
                public string UpdateTime { get; set; }
                public string CreateTime { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
