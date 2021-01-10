// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterChannelsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public DescribeCasterChannelsResponseBodyChannels Channels { get; set; }
        public class DescribeCasterChannelsResponseBodyChannels : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public List<DescribeCasterChannelsResponseBodyChannelsChannel> Channel { get; set; }
            public class DescribeCasterChannelsResponseBodyChannelsChannel : TeaModel {
                public string RtmpUrl { get; set; }
                public string ChannelId { get; set; }
                public string ResourceId { get; set; }
                public string StreamUrl { get; set; }
            }
        };

    }

}
