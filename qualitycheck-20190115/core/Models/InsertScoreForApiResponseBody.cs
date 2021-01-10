// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class InsertScoreForApiResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertScoreForApiResponseBodyData Data { get; set; }
        public class InsertScoreForApiResponseBodyData : TeaModel {
            [NameInMap("ScoreName")]
            [Validation(Required=false)]
            public string ScoreName { get; set; }
            [NameInMap("ScoreId")]
            [Validation(Required=false)]
            public long? ScoreId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
