// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterChannelsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=true)]
        public DescribeCasterChannelsResponseChannels Channels { get; set; }
        public class DescribeCasterChannelsResponseChannels : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=true)]
            public List<DescribeCasterChannelsResponseChannelsChannel> Channel { get; set; }
            public class DescribeCasterChannelsResponseChannelsChannel : TeaModel {
                public string ChannelId { get; set; }
                public string ResourceId { get; set; }
                public string StreamUrl { get; set; }
                public string RtmpUrl { get; set; }
            }
        };

    }

}
