// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaDNAResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DNAResult")]
        [Validation(Required=false)]
        public GetMediaDNAResultResponseBodyDNAResult DNAResult { get; set; }
        public class GetMediaDNAResultResponseBodyDNAResult : TeaModel {
            [NameInMap("VideoDNA")]
            [Validation(Required=false)]
            public List<GetMediaDNAResultResponseBodyDNAResultVideoDNA> VideoDNA { get; set; }
            public class GetMediaDNAResultResponseBodyDNAResultVideoDNA : TeaModel {
                public string PrimaryKey { get; set; }
                public string Similarity { get; set; }
                public List<GetMediaDNAResultResponseBodyDNAResultVideoDNADetail> Detail { get; set; }
                public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetail : TeaModel {
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                }
            }
        };

    }

}
