// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayQosListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QosInfoList")]
        [Validation(Required=false)]
        public List<DescribePlayQosListResponseBodyQosInfoList> QosInfoList { get; set; }
        public class DescribePlayQosListResponseBodyQosInfoList : TeaModel {
            [NameInMap("QosFirstFrame")]
            [Validation(Required=false)]
            public float? QosFirstFrame { get; set; }

            [NameInMap("QosKbps")]
            [Validation(Required=false)]
            public float? QosKbps { get; set; }

            [NameInMap("QosPlay")]
            [Validation(Required=false)]
            public float? QosPlay { get; set; }

            [NameInMap("QosPlayFail")]
            [Validation(Required=false)]
            public float? QosPlayFail { get; set; }

            [NameInMap("QosRealPlay")]
            [Validation(Required=false)]
            public float? QosRealPlay { get; set; }

            [NameInMap("QosSecondPlayRate")]
            [Validation(Required=false)]
            public float? QosSecondPlayRate { get; set; }

            [NameInMap("QosSeedFailRate")]
            [Validation(Required=false)]
            public float? QosSeedFailRate { get; set; }

            [NameInMap("QosSeekDuration")]
            [Validation(Required=false)]
            public double? QosSeekDuration { get; set; }

            [NameInMap("QosSlowPlayRate")]
            [Validation(Required=false)]
            public float? QosSlowPlayRate { get; set; }

            [NameInMap("QosStuckDuration100s")]
            [Validation(Required=false)]
            public double? QosStuckDuration100s { get; set; }

            [NameInMap("QosStuckRate")]
            [Validation(Required=false)]
            public float? QosStuckRate { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
