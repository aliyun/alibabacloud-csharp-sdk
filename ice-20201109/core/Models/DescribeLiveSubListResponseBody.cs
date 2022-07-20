// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeLiveSubListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubInfoList")]
        [Validation(Required=false)]
        public List<DescribeLiveSubListResponseBodySubInfoList> SubInfoList { get; set; }
        public class DescribeLiveSubListResponseBodySubInfoList : TeaModel {
            [NameInMap("CacheDuration")]
            [Validation(Required=false)]
            public string CacheDuration { get; set; }

            [NameInMap("CpuUsageRate")]
            [Validation(Required=false)]
            public string CpuUsageRate { get; set; }

            [NameInMap("FirstFrameDuration")]
            [Validation(Required=false)]
            public string FirstFrameDuration { get; set; }

            [NameInMap("PlayFps")]
            [Validation(Required=false)]
            public string PlayFps { get; set; }

            [NameInMap("SecondPlayRate")]
            [Validation(Required=false)]
            public string SecondPlayRate { get; set; }

            [NameInMap("SubNetBitrate")]
            [Validation(Required=false)]
            public string SubNetBitrate { get; set; }

            [NameInMap("SubRate")]
            [Validation(Required=false)]
            public string SubRate { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("VideoStuck")]
            [Validation(Required=false)]
            public string VideoStuck { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
