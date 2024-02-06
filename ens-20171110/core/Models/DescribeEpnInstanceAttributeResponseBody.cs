// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The information about the EPN configurations.
        /// </summary>
        [NameInMap("ConfVersions")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyConfVersions> ConfVersions { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyConfVersions : TeaModel {
            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("ConfVersion")]
            [Validation(Required=false)]
            public string ConfVersion { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

        }

        /// <summary>
        /// The ID of the EPN instance.
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// The name of the EPN instance.
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// The information about the instance.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyInstances> Instances { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyInstances : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ISP. Valid values:
            /// 
            /// *   cmcc: China Mobile
            /// *   unicom: China Unicom
            /// *   telecom: China Telecom
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   Running
            /// *   Stopped
            /// *   Expired
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The networking mode. Valid values:
        /// 
        /// *   SpeedUp: intelligent acceleration network (Internet)
        /// *   Connection: internal network
        /// *   SpeedUpAndConnection: intelligent acceleration network and internal network
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the vSwitch.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyVSwitches> VSwitches { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyVSwitches : TeaModel {
            /// <summary>
            /// The CIDR block.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The name of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

        }

    }

}
