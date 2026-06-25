// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstanceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance group.</para>
        /// </summary>
        [NameInMap("InstanceGroupModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModel> InstanceGroupModel { get; set; }
        public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModel : TeaModel {
            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-48xr63m4dybjk****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The architecture type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARM</para>
            /// </summary>
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            /// <summary>
            /// <para>The number of active instances.</para>
            /// <remarks>
            /// <para>An instance is considered active if its instance status is not &quot;Deleting&quot; or &quot;Deleted&quot;.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvailableInstanceAmount")]
            [Validation(Required=false)]
            public int? AvailableInstanceAmount { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-0q6ixs7vpxciz****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The status of the bandwidth package.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: being created.</description></item>
            /// <item><description>Releasing: being released.</description></item>
            /// <item><description>InUse: in use.</description></item>
            /// <item><description>Failed: failed.</description></item>
            /// <item><description>Expired: expired.</description></item>
            /// <item><description>Available: unbound and being billed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("BandwidthPackageStatus")]
            [Validation(Required=false)]
            public string BandwidthPackageStatus { get; set; }

            /// <summary>
            /// <para>The type of the bandwidth package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp_ecd</para>
            /// </summary>
            [NameInMap("BandwidthPackageType")]
            [Validation(Required=false)]
            public string BandwidthPackageType { get; set; }

            /// <summary>
            /// <para>The public network bandwidth throttling rules for the instance group.</para>
            /// </summary>
            [NameInMap("BindQosRules")]
            [Validation(Required=false)]
            public DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelBindQosRules BindQosRules { get; set; }
            public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelBindQosRules : TeaModel {
                /// <summary>
                /// <para>The public network bandwidth throttling rules bound to the instance.</para>
                /// </summary>
                [NameInMap("InstanceQosRule")]
                [Validation(Required=false)]
                public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelBindQosRulesInstanceQosRule> InstanceQosRule { get; set; }
                public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelBindQosRulesInstanceQosRule : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acp-h3m8b5dusopp5****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the public network bandwidth throttling rule. This rule applies only to premium bandwidth.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qos-3kh93uu0vdbka****</para>
                    /// </summary>
                    [NameInMap("QosRuleId")]
                    [Validation(Required=false)]
                    public string QosRuleId { get; set; }

                }

                /// <summary>
                /// <para>The total number of public network bandwidth throttling rules for the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

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
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The disk information.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks> Disks { get; set; }
            public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks : TeaModel {
                /// <summary>
                /// <para>The disk size, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The disk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIpv6")]
            [Validation(Required=false)]
            public bool? EnableIpv6 { get; set; }

            /// <summary>
            /// <para>The reason for the creation failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternalError</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-06-29 07:25:31</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-06zyt9m93zwax****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25.09.2</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The list of installed applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;抖音&quot;,&quot;淘宝&quot;</para>
            /// </summary>
            [NameInMap("InstalledAppList")]
            [Validation(Required=false)]
            public string InstalledAppList { get; set; }

            /// <summary>
            /// <para>The instance group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag-h67a2cs0zprfdh****</para>
            /// </summary>
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            /// <summary>
            /// <para>The instance group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud phoneA</para>
            /// </summary>
            [NameInMap("InstanceGroupName")]
            [Validation(Required=false)]
            public string InstanceGroupName { get; set; }

            /// <summary>
            /// <para>The instance group specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp.basic.small</para>
            /// </summary>
            [NameInMap("InstanceGroupSpec")]
            [Validation(Required=false)]
            public string InstanceGroupSpec { get; set; }

            /// <summary>
            /// <para>The description of the instance group specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARM-2vCPU4GiB 32GiB</para>
            /// </summary>
            [NameInMap("InstanceGroupSpecDescribe")]
            [Validation(Required=false)]
            public string InstanceGroupSpecDescribe { get; set; }

            /// <summary>
            /// <para>The instance group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceGroupStatus")]
            [Validation(Required=false)]
            public string InstanceGroupStatus { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Ipv6Bandwidth")]
            [Validation(Required=false)]
            public int? Ipv6Bandwidth { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The network type of the instance.</para>
            /// <remarks>
            /// <para>This field is returned only for instance groups with a standard network.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>network_pro_ecd</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The number of instances in the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NumberOfInstances")]
            [Validation(Required=false)]
            public string NumberOfInstances { get; set; }

            /// <summary>
            /// <para>The network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-030598****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-c6n38xucps8kl****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

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
            /// <para>The rendering type of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("RenderingType")]
            [Validation(Required=false)]
            public string RenderingType { get; set; }

            /// <summary>
            /// <para>The height of the resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <para>The width of the resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <para>The sales mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SaleMode")]
            [Validation(Required=false)]
            public string SaleMode { get; set; }

            /// <summary>
            /// <para>The system version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Android 12</para>
            /// </summary>
            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelTags> Tags { get; set; }
            public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelTags : TeaModel {
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
            /// <para>The vSwitch ID in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-t4n0yqs009ho024wt****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that indicates the position where the current call returns. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uONHqPtDLM2U8s****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
