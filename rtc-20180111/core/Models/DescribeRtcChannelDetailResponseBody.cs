// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelDetailResponseBody : TeaModel {
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("ChannelInfo")]
        [Validation(Required=false)]
        public List<DescribeRtcChannelDetailResponseBodyChannelInfo> ChannelInfo { get; set; }
        public class DescribeRtcChannelDetailResponseBodyChannelInfo : TeaModel {
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("OS")]
            [Validation(Required=false)]
            public string OS { get; set; }

            [NameInMap("LeaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

    }

}
