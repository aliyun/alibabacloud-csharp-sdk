// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHlsLiveStreamRealTimeBpsDataResponse : TeaModel {
        [NameInMap("Time")]
        [Validation(Required=true)]
        public string Time { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("UsageData")]
        [Validation(Required=true)]
        public List<DescribeHlsLiveStreamRealTimeBpsDataResponseUsageData> UsageData { get; set; }
        public class DescribeHlsLiveStreamRealTimeBpsDataResponseUsageData : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("StreamInfos")]
            [Validation(Required=true)]
            public List<DescribeHlsLiveStreamRealTimeBpsDataResponseUsageDataStreamInfos> StreamInfos { get; set; }
            public class DescribeHlsLiveStreamRealTimeBpsDataResponseUsageDataStreamInfos : TeaModel {
                [NameInMap("StreamName")]
                [Validation(Required=true)]
                public string StreamName { get; set; }

                [NameInMap("Infos")]
                [Validation(Required=true)]
                public List<DescribeHlsLiveStreamRealTimeBpsDataResponseUsageDataStreamInfosInfos> Infos { get; set; }
                public class DescribeHlsLiveStreamRealTimeBpsDataResponseUsageDataStreamInfosInfos : TeaModel {
                    [NameInMap("DownFlow")]
                    [Validation(Required=true)]
                    public float? DownFlow { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=true)]
                    public string Rate { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=true)]
                    public float? Online { get; set; }

                }

            }

        }

    }

}
