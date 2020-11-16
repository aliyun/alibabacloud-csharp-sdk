// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamCountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("StreamCountInfos")]
        [Validation(Required=true)]
        public DescribeLiveStreamCountResponseStreamCountInfos StreamCountInfos { get; set; }
        public class DescribeLiveStreamCountResponseStreamCountInfos : TeaModel {
            [NameInMap("StreamCountInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfo> StreamCountInfo { get; set; }
            public class DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfo : TeaModel {
                public long Count { get; set; }
                public long Limit { get; set; }
                public string Type { get; set; }
                public DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfoStreamCountDetails StreamCountDetails { get; set; }
                public class DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfoStreamCountDetails : TeaModel {
                    [NameInMap("StreamCountDetail")]
                    [Validation(Required=true)]
                    public List<DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail> StreamCountDetail { get; set; }
                    public class DescribeLiveStreamCountResponseStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=true)]
                        public string Format { get; set; }

                        [NameInMap("VideoDataRate")]
                        [Validation(Required=true)]
                        public long VideoDataRate { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=true)]
                        public long Count { get; set; }

                    }

                }
            }
        };

    }

}
