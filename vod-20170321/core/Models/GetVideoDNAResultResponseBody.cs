// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoDNAResultResponseBody : TeaModel {
        [NameInMap("AIVideoDNAResult")]
        [Validation(Required=false)]
        public GetVideoDNAResultResponseBodyAIVideoDNAResult AIVideoDNAResult { get; set; }
        public class GetVideoDNAResultResponseBodyAIVideoDNAResult : TeaModel {
            [NameInMap("FpShots")]
            [Validation(Required=false)]
            public List<GetVideoDNAResultResponseBodyAIVideoDNAResultFpShots> FpShots { get; set; }
            public class GetVideoDNAResultResponseBodyAIVideoDNAResultFpShots : TeaModel {
                [NameInMap("FpShotSlices")]
                [Validation(Required=false)]
                public List<GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlices> FpShotSlices { get; set; }
                public class GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlices : TeaModel {
                    [NameInMap("Duplication")]
                    [Validation(Required=false)]
                    public GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlicesDuplication Duplication { get; set; }
                    public class GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlicesDuplication : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlicesInput Input { get; set; }
                    public class GetVideoDNAResultResponseBodyAIVideoDNAResultFpShotsFpShotSlicesInput : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                }

                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                [NameInMap("Similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
