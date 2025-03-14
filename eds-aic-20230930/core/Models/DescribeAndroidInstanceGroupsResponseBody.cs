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
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-48xr63m4dybjk****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARM</para>
            /// </summary>
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            /// <summary>
            /// <para>Number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AvailableInstanceAmount")]
            [Validation(Required=false)]
            public int? AvailableInstanceAmount { get; set; }

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
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks> Disks { get; set; }
            public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks : TeaModel {
                /// <summary>
                /// <para>The size of the disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The type of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("EnableIpv6")]
            [Validation(Required=false)]
            public bool? EnableIpv6 { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The time when the instance group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the subscription instance group expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-06-29 07:25:31</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The time when the instance group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-06zyt9m93zwax****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The list of installed applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;TikTok&quot;,&quot;WeChat&quot;</para>
            /// </summary>
            [NameInMap("InstalledAppList")]
            [Validation(Required=false)]
            public string InstalledAppList { get; set; }

            /// <summary>
            /// <para>The ID of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag-h67a2cs0zprfdh****</para>
            /// </summary>
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>defaultInstanceGroup</para>
            /// </summary>
            [NameInMap("InstanceGroupName")]
            [Validation(Required=false)]
            public string InstanceGroupName { get; set; }

            /// <summary>
            /// <para>The specifications of the instance group.</para>
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
            /// <para>The status of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceGroupStatus")]
            [Validation(Required=false)]
            public string InstanceGroupStatus { get; set; }

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
            /// <para>The number of instances in the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NumberOfInstances")]
            [Validation(Required=false)]
            public string NumberOfInstances { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-030598****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-c6n38xucps8kl****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The rendering type.</para>
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
            /// <para>The version of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Android 12</para>
            /// </summary>
            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-t4n0yqs009ho024wt****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uONHqPtDLM2U8s****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F07A1DA1-E1EB-5CCA-8EED-12F85D32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
