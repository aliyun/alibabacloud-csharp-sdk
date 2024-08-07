// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeQualityAreaDistributionStatDataResponseBody : TeaModel {
        [NameInMap("QualityStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList> QualityStatDataList { get; set; }
        public class DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList : TeaModel {
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            [NameInMap("AudioSpeakOutDuration")]
            [Validation(Required=false)]
            public long? AudioSpeakOutDuration { get; set; }

            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            [NameInMap("VideoStuckRate")]
            [Validation(Required=false)]
            public string VideoStuckRate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
