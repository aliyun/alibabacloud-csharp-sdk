// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterMpuTranscodeRtUsageByTaskProfileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterMpuTranscodeRtUsageByTaskProfileResponseBodyData> Data { get; set; }
        public class DescribeMeterMpuTranscodeRtUsageByTaskProfileResponseBodyData : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("ServiceArea")]
            [Validation(Required=false)]
            public string ServiceArea { get; set; }

            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
