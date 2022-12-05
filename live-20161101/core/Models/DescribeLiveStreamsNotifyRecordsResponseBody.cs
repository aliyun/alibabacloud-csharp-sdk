// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyRecordsResponseBody : TeaModel {
        [NameInMap("NotifyRecordsInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo NotifyRecordsInfo { get; set; }
        public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo : TeaModel {
            [NameInMap("LiveStreamNotifyRecordsInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo> LiveStreamNotifyRecordsInfo { get; set; }
            public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("NotifyContent")]
                [Validation(Required=false)]
                public string NotifyContent { get; set; }

                [NameInMap("NotifyResult")]
                [Validation(Required=false)]
                public string NotifyResult { get; set; }

                [NameInMap("NotifyTime")]
                [Validation(Required=false)]
                public string NotifyTime { get; set; }

                [NameInMap("NotifyType")]
                [Validation(Required=false)]
                public string NotifyType { get; set; }

                [NameInMap("NotifyUrl")]
                [Validation(Required=false)]
                public string NotifyUrl { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
