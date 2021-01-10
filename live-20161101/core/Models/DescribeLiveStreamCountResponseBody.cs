// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamCountInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamCountResponseBodyStreamCountInfos StreamCountInfos { get; set; }
        public class DescribeLiveStreamCountResponseBodyStreamCountInfos : TeaModel {
            [NameInMap("StreamCountInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo> StreamCountInfo { get; set; }
            public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo : TeaModel {
                public string Type { get; set; }
                public DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails StreamCountDetails { get; set; }
                public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails : TeaModel {
                    [NameInMap("StreamCountDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail> StreamCountDetail { get; set; }
                    public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail : TeaModel {
                        [NameInMap("VideoDataRate")]
                        [Validation(Required=false)]
                        public long? VideoDataRate { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                    }

                }
                public long? Limit { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
