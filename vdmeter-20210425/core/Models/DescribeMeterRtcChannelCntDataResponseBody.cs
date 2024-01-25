// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcChannelCntDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcChannelCntDataResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcChannelCntDataResponseBodyData : TeaModel {
            [NameInMap("ChannelCnt")]
            [Validation(Required=false)]
            public long? ChannelCnt { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
