// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates whether a token for the next query is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The details of the cloud phone matrix.</para>
        /// </summary>
        [NameInMap("NodeModel")]
        [Validation(Required=false)]
        public List<DescribeCloudPhoneNodesResponseBodyNodeModel> NodeModel { get; set; }
        public class DescribeCloudPhoneNodesResponseBodyNodeModel : TeaModel {
            /// <summary>
            /// <para>The ID of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-7xvrl7axet2qg6yia******</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The status of the bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Initialized.</description></item>
            /// <item><description>1: Normal.</description></item>
            /// <item><description>2: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BandwidthPackageStatus")]
            [Validation(Required=false)]
            public string BandwidthPackageStatus { get; set; }

            /// <summary>
            /// <para>The bandwidth type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp_ecd</para>
            /// </summary>
            [NameInMap("BandwidthPackageType")]
            [Validation(Required=false)]
            public string BandwidthPackageType { get; set; }

            /// <summary>
            /// <para>The array of tag information.</para>
            /// </summary>
            [NameInMap("BizTags")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodesResponseBodyNodeModelBizTags> BizTags { get; set; }
            public class DescribeCloudPhoneNodesResponseBodyNodeModelBizTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>keyname</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>valuename</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The order source. A value of CLOUDPHONE indicates an AI cloud phone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUDPHONE</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-13 02:03:14</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-09 02:00:34</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-13 02:03:14</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac.max</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-5mwr9azebliva****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The network-related information.</para>
            /// </summary>
            [NameInMap("NetworkInfos")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodesResponseBodyNodeModelNetworkInfos> NetworkInfos { get; set; }
            public class DescribeCloudPhoneNodesResponseBodyNodeModelNetworkInfos : TeaModel {
                /// <summary>
                /// <para>The instance ID of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbwp-hn3tj409amvamz8mf****</para>
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// <para>The bandwidth type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbwp_ecd</para>
                /// </summary>
                [NameInMap("BandwidthPackageType")]
                [Validation(Required=false)]
                public string BandwidthPackageType { get; set; }

                /// <summary>
                /// <para>The network ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-avcuocx9805oq****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>network_pro_ecd</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-j6cjgev6fv3ftw4f0****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The network type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_pro_ecd</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The ID of the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpn-ehs0yoedq8ntm****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The name of the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_name</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The ID of the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmag-bp19i1yxu60r7twy****</para>
            /// </summary>
            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The number of instances provisioned under the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("PhoneCount")]
            [Validation(Required=false)]
            public int? PhoneCount { get; set; }

            /// <summary>
            /// <para>The dedicated internal storage information.</para>
            /// </summary>
            [NameInMap("PhoneDataInfo")]
            [Validation(Required=false)]
            public DescribeCloudPhoneNodesResponseBodyNodeModelPhoneDataInfo PhoneDataInfo { get; set; }
            public class DescribeCloudPhoneNodesResponseBodyNodeModelPhoneDataInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the dedicated internal storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pd-dhusabisshj****</para>
                /// </summary>
                [NameInMap("PhoneDataId")]
                [Validation(Required=false)]
                public string PhoneDataId { get; set; }

                /// <summary>
                /// <para>The storage capacity of the dedicated internal storage. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PhoneDataVolume")]
                [Validation(Required=false)]
                public int? PhoneDataVolume { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The height of the resolution. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <para>The width of the resolution. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <para>The specifications of the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpm.gx7.10xlarge</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The size of the shared internal storage. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ShareDataVolume")]
            [Validation(Required=false)]
            public int? ShareDataVolume { get; set; }

            /// <summary>
            /// <para>The status of the cloud phone matrix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The size of the swap space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SwapSize")]
            [Validation(Required=false)]
            public int? SwapSize { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodesResponseBodyNodeModelTags> Tags { get; set; }
            public class DescribeCloudPhoneNodesResponseBodyNodeModelTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>phone</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zeekryyc1q3sm72l****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F07A1DA1-E1EB-5CCA-8EED-12F85D32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
