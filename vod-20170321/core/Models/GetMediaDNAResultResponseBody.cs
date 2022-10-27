// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaDNAResultResponseBody : TeaModel {
        [NameInMap("DNAResult")]
        [Validation(Required=false)]
        public GetMediaDNAResultResponseBodyDNAResult DNAResult { get; set; }
        public class GetMediaDNAResultResponseBodyDNAResult : TeaModel {
            [NameInMap("VideoDNA")]
            [Validation(Required=false)]
            public List<GetMediaDNAResultResponseBodyDNAResultVideoDNA> VideoDNA { get; set; }
            public class GetMediaDNAResultResponseBodyDNAResultVideoDNA : TeaModel {
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<GetMediaDNAResultResponseBodyDNAResultVideoDNADetail> Detail { get; set; }
                public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetail : TeaModel {
                    [NameInMap("Duplication")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication Duplication { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput Input { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput : TeaModel {
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
