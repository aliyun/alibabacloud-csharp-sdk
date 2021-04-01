// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceSpecsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=true)]
        public List<DescribeInstanceSpecsResponseInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseInstanceSpecs : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("BaseBandwidth")]
            [Validation(Required=true)]
            public int? BaseBandwidth { get; set; }

            [NameInMap("ElasticBandwidth")]
            [Validation(Required=true)]
            public int? ElasticBandwidth { get; set; }

            [NameInMap("PortLimit")]
            [Validation(Required=true)]
            public int? PortLimit { get; set; }

            [NameInMap("SiteLimit")]
            [Validation(Required=true)]
            public int? SiteLimit { get; set; }

            [NameInMap("DomainLimit")]
            [Validation(Required=true)]
            public int? DomainLimit { get; set; }

            [NameInMap("BandwidthMbps")]
            [Validation(Required=true)]
            public int? BandwidthMbps { get; set; }

            [NameInMap("DefenseCount")]
            [Validation(Required=true)]
            public int? DefenseCount { get; set; }

            [NameInMap("FunctionVersion")]
            [Validation(Required=true)]
            public string FunctionVersion { get; set; }

            [NameInMap("QpsLimit")]
            [Validation(Required=true)]
            public int? QpsLimit { get; set; }

        }

    }

}
