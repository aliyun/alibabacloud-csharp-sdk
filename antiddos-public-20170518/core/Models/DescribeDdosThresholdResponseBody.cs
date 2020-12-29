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
        public List<DescribeDdosThresholdResponseBodyThresholds> Thresholds { get; set; }
        public class DescribeDdosThresholdResponseBodyThresholds : TeaModel {
            [NameInMap("DdosType")]
            [Validation(Required=false)]
            public string DdosType { get; set; }

            [NameInMap("IsAuto")]
            [Validation(Required=false)]
            public bool? IsAuto { get; set; }

            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public int? MaxBps { get; set; }

            [NameInMap("ElasticBps")]
            [Validation(Required=false)]
            public int? ElasticBps { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            [NameInMap("MaxPps")]
            [Validation(Required=false)]
            public int? MaxPps { get; set; }

        }

    }

}
