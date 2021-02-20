// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            [NameInMap("BaseBandwidth")]
            [Validation(Required=false)]
            public int? BaseBandwidth { get; set; }

            [NameInMap("QpsLimit")]
            [Validation(Required=false)]
            public int? QpsLimit { get; set; }

            [NameInMap("BandwidthMbps")]
            [Validation(Required=false)]
            public int? BandwidthMbps { get; set; }

            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            [NameInMap("SiteLimit")]
            [Validation(Required=false)]
            public int? SiteLimit { get; set; }

            [NameInMap("PortLimit")]
            [Validation(Required=false)]
            public int? PortLimit { get; set; }

            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public string FunctionVersion { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("DomainLimit")]
            [Validation(Required=false)]
            public int? DomainLimit { get; set; }

        }

    }

}
