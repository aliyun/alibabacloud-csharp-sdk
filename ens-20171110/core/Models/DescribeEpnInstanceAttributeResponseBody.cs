// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstanceAttributeResponseBody : TeaModel {
        [NameInMap("ConfVersions")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyConfVersions> ConfVersions { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyConfVersions : TeaModel {
            [NameInMap("ConfVersion")]
            [Validation(Required=false)]
            public string ConfVersion { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

        }

        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyInstances> Instances { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyInstances : TeaModel {
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyVSwitches> VSwitches { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyVSwitches : TeaModel {
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

        }

    }

}
