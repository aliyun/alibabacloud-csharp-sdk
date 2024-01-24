// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchNetworkResponseBody : TeaModel {
        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates the information about the virtual private cloud (VPC) in which the instance is deployed.
        /// </summary>
        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public DescribeInstanceSwitchNetworkResponseBodyVpcInfos VpcInfos { get; set; }
        public class DescribeInstanceSwitchNetworkResponseBodyVpcInfos : TeaModel {
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public List<DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfo> VpcInfo { get; set; }
            public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfo : TeaModel {
                /// <summary>
                /// Indicates the ID of the region in which the instance is deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Indicates the ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// Indicates the name of the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// Indicates information about the vSwitch to which the instance is connected.
                /// </summary>
                [NameInMap("VswitchInfos")]
                [Validation(Required=false)]
                public DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfos VswitchInfos { get; set; }
                public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfos : TeaModel {
                    [NameInMap("VswitchInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfosVswitchInfo> VswitchInfo { get; set; }
                    public class DescribeInstanceSwitchNetworkResponseBodyVpcInfosVpcInfoVswitchInfosVswitchInfo : TeaModel {
                        /// <summary>
                        /// Indicates the ID of the zone in which the instance is deployed.
                        /// </summary>
                        [NameInMap("AzoneId")]
                        [Validation(Required=false)]
                        public string AzoneId { get; set; }

                        /// <summary>
                        /// Indicates whether you can change the network type of the instance.
                        /// </summary>
                        [NameInMap("DrdsSupported")]
                        [Validation(Required=false)]
                        public bool? DrdsSupported { get; set; }

                        /// <summary>
                        /// Indicates the ID of the VPC.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// Indicates the ID of the vSwitch.
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        /// <summary>
                        /// Indicates the name of the vSwitch.
                        /// </summary>
                        [NameInMap("VswitchName")]
                        [Validation(Required=false)]
                        public string VswitchName { get; set; }

                    }

                }

            }

        }

    }

}
