// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetQosAttributeResponseBody : TeaModel {
        [NameInMap("QosPolicies")]
        [Validation(Required=false)]
        public List<GetQosAttributeResponseBodyQosPolicies> QosPolicies { get; set; }
        public class GetQosAttributeResponseBodyQosPolicies : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("DestCidr")]
            [Validation(Required=false)]
            public string DestCidr { get; set; }

            [NameInMap("DestPortRange")]
            [Validation(Required=false)]
            public string DestPortRange { get; set; }

            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("QosPolicieDescription")]
            [Validation(Required=false)]
            public string QosPolicieDescription { get; set; }

            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            [NameInMap("QosPolicieName")]
            [Validation(Required=false)]
            public string QosPolicieName { get; set; }

            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        [NameInMap("QosCars")]
        [Validation(Required=false)]
        public List<GetQosAttributeResponseBodyQosCars> QosCars { get; set; }
        public class GetQosAttributeResponseBodyQosCars : TeaModel {
            [NameInMap("MaxBandwidthAbs")]
            [Validation(Required=false)]
            public int? MaxBandwidthAbs { get; set; }

            [NameInMap("QosCarName")]
            [Validation(Required=false)]
            public string QosCarName { get; set; }

            [NameInMap("PercentSourceType")]
            [Validation(Required=false)]
            public string PercentSourceType { get; set; }

            [NameInMap("MinBandwidthAbs")]
            [Validation(Required=false)]
            public int? MinBandwidthAbs { get; set; }

            [NameInMap("MaxBandwidthPercent")]
            [Validation(Required=false)]
            public int? MaxBandwidthPercent { get; set; }

            [NameInMap("QosCarDescription")]
            [Validation(Required=false)]
            public string QosCarDescription { get; set; }

            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("MinBandwidthPercent")]
            [Validation(Required=false)]
            public int? MinBandwidthPercent { get; set; }

            [NameInMap("QosCarId")]
            [Validation(Required=false)]
            public string QosCarId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorConfigSmartAGCount")]
        [Validation(Required=false)]
        public int? ErrorConfigSmartAGCount { get; set; }

        [NameInMap("QosName")]
        [Validation(Required=false)]
        public string QosName { get; set; }

        [NameInMap("QosDescription")]
        [Validation(Required=false)]
        public string QosDescription { get; set; }

    }

}
