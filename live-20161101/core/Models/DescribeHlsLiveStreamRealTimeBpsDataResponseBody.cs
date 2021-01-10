// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHlsLiveStreamRealTimeBpsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageData")]
        [Validation(Required=false)]
        public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageData> UsageData { get; set; }
        public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageData : TeaModel {
            [NameInMap("StreamInfos")]
            [Validation(Required=false)]
            public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfos> StreamInfos { get; set; }
            public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfos : TeaModel {
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("Infos")]
                [Validation(Required=false)]
                public List<DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfosInfos> Infos { get; set; }
                public class DescribeHlsLiveStreamRealTimeBpsDataResponseBodyUsageDataStreamInfosInfos : TeaModel {
                    [NameInMap("DownFlow")]
                    [Validation(Required=false)]
                    public float? DownFlow { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public float? Online { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                }

            }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
