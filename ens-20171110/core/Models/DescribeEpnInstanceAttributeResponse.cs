// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstanceAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("EPNInstanceId")]
        [Validation(Required=true)]
        public string EPNInstanceId { get; set; }

        [NameInMap("EPNInstanceName")]
        [Validation(Required=true)]
        public string EPNInstanceName { get; set; }

        [NameInMap("NetworkingModel")]
        [Validation(Required=true)]
        public string NetworkingModel { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=true)]
        public List<DescribeEpnInstanceAttributeResponseVSwitches> VSwitches { get; set; }
        public class DescribeEpnInstanceAttributeResponseVSwitches : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=true)]
            public string VSwitchId { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=true)]
            public string EnsRegionId { get; set; }

            [NameInMap("CidrBlock")]
            [Validation(Required=true)]
            public string CidrBlock { get; set; }

            [NameInMap("VSwitchName")]
            [Validation(Required=true)]
            public string VSwitchName { get; set; }

        }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<DescribeEpnInstanceAttributeResponseInstances> Instances { get; set; }
        public class DescribeEpnInstanceAttributeResponseInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=true)]
            public string PublicIpAddress { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=true)]
            public string EnsRegionId { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=true)]
            public string Isp { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=true)]
            public string InstanceName { get; set; }

            [NameInMap("PrivateIpAddress")]
            [Validation(Required=true)]
            public string PrivateIpAddress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

        [NameInMap("ConfVersions")]
        [Validation(Required=true)]
        public List<DescribeEpnInstanceAttributeResponseConfVersions> ConfVersions { get; set; }
        public class DescribeEpnInstanceAttributeResponseConfVersions : TeaModel {
            [NameInMap("EnsRegionId")]
            [Validation(Required=true)]
            public string EnsRegionId { get; set; }

            [NameInMap("ConfVersion")]
            [Validation(Required=true)]
            public string ConfVersion { get; set; }

        }

    }

}
