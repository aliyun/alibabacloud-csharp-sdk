// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsControlHistoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ControlInfo")]
        [Validation(Required=true)]
        public DescribeLiveStreamsControlHistoryResponseControlInfo ControlInfo { get; set; }
        public class DescribeLiveStreamsControlHistoryResponseControlInfo : TeaModel {
            [NameInMap("LiveStreamControlInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamsControlHistoryResponseControlInfoLiveStreamControlInfo> LiveStreamControlInfo { get; set; }
            public class DescribeLiveStreamsControlHistoryResponseControlInfoLiveStreamControlInfo : TeaModel {
                public string StreamName { get; set; }
                public string ClientIP { get; set; }
                public string Action { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
