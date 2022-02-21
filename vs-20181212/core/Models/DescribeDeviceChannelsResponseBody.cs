// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceChannelsResponseBody : TeaModel {
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<DescribeDeviceChannelsResponseBodyChannels> Channels { get; set; }
        public class DescribeDeviceChannelsResponseBodyChannels : TeaModel {
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public long? ChannelId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            [NameInMap("GbId")]
            [Validation(Required=false)]
            public string GbId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

            [NameInMap("StreamStatus")]
            [Validation(Required=false)]
            public string StreamStatus { get; set; }

        }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
