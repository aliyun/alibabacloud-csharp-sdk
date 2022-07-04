// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpDdosThresholdResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public DescribeIpDdosThresholdResponseBodyThreshold Threshold { get; set; }
        public class DescribeIpDdosThresholdResponseBodyThreshold : TeaModel {
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }
            [NameInMap("DdosType")]
            [Validation(Required=false)]
            public string DdosType { get; set; }
            [NameInMap("ElasticBps")]
            [Validation(Required=false)]
            public int? ElasticBps { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("IsAuto")]
            [Validation(Required=false)]
            public bool? IsAuto { get; set; }
            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public int? MaxBps { get; set; }
            [NameInMap("MaxPps")]
            [Validation(Required=false)]
            public int? MaxPps { get; set; }
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }
        };

    }

}
