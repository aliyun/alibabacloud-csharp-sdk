// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelListResponseBody : TeaModel {
        [NameInMap("ChannelList")]
        [Validation(Required=false)]
        public DescribeRtcChannelListResponseBodyChannelList ChannelList { get; set; }
        public class DescribeRtcChannelListResponseBodyChannelList : TeaModel {
            [NameInMap("ChannelList")]
            [Validation(Required=false)]
            public List<DescribeRtcChannelListResponseBodyChannelListChannelList> ChannelList { get; set; }
            public class DescribeRtcChannelListResponseBodyChannelListChannelList : TeaModel {
                [NameInMap("CallArea")]
                [Validation(Required=false)]
                public DescribeRtcChannelListResponseBodyChannelListChannelListCallArea CallArea { get; set; }
                public class DescribeRtcChannelListResponseBodyChannelListChannelListCallArea : TeaModel {
                    [NameInMap("CallArea")]
                    [Validation(Required=false)]
                    public List<string> CallArea { get; set; }

                }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("TotalUserCnt")]
                [Validation(Required=false)]
                public long? TotalUserCnt { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
