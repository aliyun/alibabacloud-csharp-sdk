// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosThresholdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Thresholds")]
        [Validation(Required=false)]
        public DescribeDdosThresholdResponseBodyThresholds Thresholds { get; set; }
        public class DescribeDdosThresholdResponseBodyThresholds : TeaModel {
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public List<DescribeDdosThresholdResponseBodyThresholdsThreshold> Threshold { get; set; }
            public class DescribeDdosThresholdResponseBodyThresholdsThreshold : TeaModel {
                public int? Bps { get; set; }
                public string DdosType { get; set; }
                public int? ElasticBps { get; set; }
                public string InstanceId { get; set; }
                public string InternetIp { get; set; }
                public bool? IsAuto { get; set; }
                public int? MaxBps { get; set; }
                public int? MaxPps { get; set; }
                public int? Pps { get; set; }
            }
        };

    }

}
