// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetScoreInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScoreInfoResponseBodyData Data { get; set; }
        public class GetScoreInfoResponseBodyData : TeaModel {
            [NameInMap("ScorePo")]
            [Validation(Required=false)]
            public List<GetScoreInfoResponseBodyDataScorePo> ScorePo { get; set; }
            public class GetScoreInfoResponseBodyDataScorePo : TeaModel {
                [NameInMap("ScoreParam")]
                [Validation(Required=false)]
                public List<GetScoreInfoResponseBodyDataScorePoScoreParam> ScoreParam { get; set; }
                public class GetScoreInfoResponseBodyDataScorePoScoreParam : TeaModel {
                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public int? ScoreSubId { get; set; }

                    [NameInMap("ScoreType")]
                    [Validation(Required=false)]
                    public int? ScoreType { get; set; }

                }

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
