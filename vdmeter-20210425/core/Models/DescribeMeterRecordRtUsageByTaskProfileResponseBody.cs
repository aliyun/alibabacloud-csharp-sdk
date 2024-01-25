// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRecordRtUsageByTaskProfileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRecordRtUsageByTaskProfileResponseBodyData> Data { get; set; }
        public class DescribeMeterRecordRtUsageByTaskProfileResponseBodyData : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            [NameInMap("ServiceArea")]
            [Validation(Required=false)]
            public string ServiceArea { get; set; }

            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
