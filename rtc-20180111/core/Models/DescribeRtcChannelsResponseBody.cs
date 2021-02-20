// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelsResponseBody : TeaModel {
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<DescribeRtcChannelsResponseBodyChannels> Channels { get; set; }
        public class DescribeRtcChannelsResponseBodyChannels : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

        }

    }

}
