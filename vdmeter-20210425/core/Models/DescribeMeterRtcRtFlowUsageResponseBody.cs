// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcRtFlowUsageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcRtFlowUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcRtFlowUsageResponseBodyData : TeaModel {
            [NameInMap("AnchorFlowValue")]
            [Validation(Required=false)]
            public float? AnchorFlowValue { get; set; }

            [NameInMap("AudienceFlowValue")]
            [Validation(Required=false)]
            public float? AudienceFlowValue { get; set; }

            [NameInMap("FlowValue")]
            [Validation(Required=false)]
            public float? FlowValue { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
