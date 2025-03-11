// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03E12FE3-1638-483E-A9B6-1A9120SER56T</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates the information about the virtual private cloud (VPC) in which the instance is deployed.</para>
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
                /// <para>Indicates the ID of the region in which the instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc_id</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>Indicates the name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc_name</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// <para>Indicates information about the vSwitch to which the instance is connected.</para>
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
                        /// <para>Indicates the ID of the zone in which the instance is deployed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-a</para>
                        /// </summary>
                        [NameInMap("AzoneId")]
                        [Validation(Required=false)]
                        public string AzoneId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether you can change the network type of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("DrdsSupported")]
                        [Validation(Required=false)]
                        public bool? DrdsSupported { get; set; }

                        /// <summary>
                        /// <para>Indicates the ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc_id</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>Indicates the ID of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vswitch_id</para>
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        /// <summary>
                        /// <para>Indicates the name of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vswitch_name</para>
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
