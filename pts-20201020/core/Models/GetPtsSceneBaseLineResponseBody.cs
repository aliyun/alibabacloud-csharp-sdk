// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneBaseLineResponseBody : TeaModel {
        [NameInMap("Baseline")]
        [Validation(Required=false)]
        public GetPtsSceneBaseLineResponseBodyBaseline Baseline { get; set; }
        public class GetPtsSceneBaseLineResponseBodyBaseline : TeaModel {
            [NameInMap("ApiBaselines")]
            [Validation(Required=false)]
            public List<GetPtsSceneBaseLineResponseBodyBaselineApiBaselines> ApiBaselines { get; set; }
            public class GetPtsSceneBaseLineResponseBodyBaselineApiBaselines : TeaModel {
                public float? AvgRt { get; set; }
                public float? AvgTps { get; set; }
                public long? FailCountBiz { get; set; }
                public long? FailCountReq { get; set; }
                public long? Id { get; set; }
                public int? MaxRt { get; set; }
                public int? MinRt { get; set; }
                public string Name { get; set; }
                public float? Seg90Rt { get; set; }
                public float? Seg99Rt { get; set; }
                public float? SuccessRateBiz { get; set; }
                public float? SuccessRateReq { get; set; }
            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("SceneBaseline")]
            [Validation(Required=false)]
            public GetPtsSceneBaseLineResponseBodyBaselineSceneBaseline SceneBaseline { get; set; }
            public class GetPtsSceneBaseLineResponseBodyBaselineSceneBaseline : TeaModel {
                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public float? AvgRt { get; set; }

                [NameInMap("AvgTps")]
                [Validation(Required=false)]
                public float? AvgTps { get; set; }

                [NameInMap("FailCountBiz")]
                [Validation(Required=false)]
                public long? FailCountBiz { get; set; }

                [NameInMap("FailCountReq")]
                [Validation(Required=false)]
                public long? FailCountReq { get; set; }

                [NameInMap("Seg90Rt")]
                [Validation(Required=false)]
                public float? Seg90Rt { get; set; }

                [NameInMap("Seg99Rt")]
                [Validation(Required=false)]
                public float? Seg99Rt { get; set; }

                [NameInMap("SuccessRateBiz")]
                [Validation(Required=false)]
                public float? SuccessRateBiz { get; set; }

                [NameInMap("SuccessRateReq")]
                [Validation(Required=false)]
                public float? SuccessRateReq { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
