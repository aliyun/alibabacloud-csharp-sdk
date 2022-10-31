// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterChannelsResponseBody : TeaModel {
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public DescribeCasterChannelsResponseBodyChannels Channels { get; set; }
        public class DescribeCasterChannelsResponseBodyChannels : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public List<DescribeCasterChannelsResponseBodyChannelsChannel> Channel { get; set; }
            public class DescribeCasterChannelsResponseBodyChannelsChannel : TeaModel {
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("FaceBeauty")]
                [Validation(Required=false)]
                public string FaceBeauty { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
