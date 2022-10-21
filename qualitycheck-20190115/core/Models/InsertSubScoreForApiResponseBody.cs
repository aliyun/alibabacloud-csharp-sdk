// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class InsertSubScoreForApiResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertSubScoreForApiResponseBodyData Data { get; set; }
        public class InsertSubScoreForApiResponseBodyData : TeaModel {
            [NameInMap("ScoreSubId")]
            [Validation(Required=false)]
            public long? ScoreSubId { get; set; }

            [NameInMap("ScoreSubName")]
            [Validation(Required=false)]
            public string ScoreSubName { get; set; }

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
