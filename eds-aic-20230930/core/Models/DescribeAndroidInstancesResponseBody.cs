// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud phone instances.</para>
        /// </summary>
        [NameInMap("InstanceModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesResponseBodyInstanceModel> InstanceModel { get; set; }
        public class DescribeAndroidInstancesResponseBodyInstanceModel : TeaModel {
            /// <summary>
            /// <para>The ID of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag-ayyhomlal7po****</para>
            /// </summary>
            [NameInMap("AndroidInstanceGroupId")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AndroidInstanceGroupName</para>
            /// </summary>
            [NameInMap("AndroidInstanceGroupName")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-8at8h6ejkadjh****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            /// <summary>
            /// <para>The state of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AndroidInstanceStatus")]
            [Validation(Required=false)]
            public string AndroidInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-i7yv6tkn7kh8dv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the physical instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-9ey6io0q58rcd****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("AppManagePolicy")]
            [Validation(Required=false)]
            public DescribeAndroidInstancesResponseBodyInstanceModelAppManagePolicy AppManagePolicy { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelAppManagePolicy : TeaModel {
                [NameInMap("AppManagePolicyId")]
                [Validation(Required=false)]
                public string AppManagePolicyId { get; set; }

                [NameInMap("AppManagePolicyName")]
                [Validation(Required=false)]
                public string AppManagePolicyName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user to whom the instance is assigned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public string AuthorizedUserId { get; set; }

            /// <summary>
            /// <para>The ID of the bound user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
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
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelDisks> Disks { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelDisks : TeaModel {
                /// <summary>
                /// <para>The disk size. Unit: GB.</para>
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

            [NameInMap("DisplayConfig")]
            [Validation(Required=false)]
            public DescribeAndroidInstancesResponseBodyInstanceModelDisplayConfig DisplayConfig { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelDisplayConfig : TeaModel {
                [NameInMap("Dpi")]
                [Validation(Required=false)]
                public int? Dpi { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                [NameInMap("LockResolution")]
                [Validation(Required=false)]
                public string LockResolution { get; set; }

                [NameInMap("ResolutionHeight")]
                [Validation(Required=false)]
                public int? ResolutionHeight { get; set; }

                [NameInMap("ResolutionWidth")]
                [Validation(Required=false)]
                public int? ResolutionWidth { get; set; }

            }

            /// <summary>
            /// <para>The cause of the instance data backup failure or restoration failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FilePathNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the subscription instance group expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-15T02:03:33Z</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The time when the instance was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3.867</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp.basic.small</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the key pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kp-5hh431emkpucs****</para>
            /// </summary>
            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The IP address of the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.22.48</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIpv6Address")]
            [Validation(Required=false)]
            public string NetworkInterfaceIpv6Address { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen+dir-211620****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The ID of the persistent session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-0btrd5zj8epo****</para>
            /// </summary>
            [NameInMap("PersistentAppInstanceId")]
            [Validation(Required=false)]
            public string PersistentAppInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-0bszojpu0seql****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.32.1.41</para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PublicIpv6Address")]
            [Validation(Required=false)]
            public string PublicIpv6Address { get; set; }

            [NameInMap("QosRuleId")]
            [Validation(Required=false)]
            public string QosRuleId { get; set; }

            /// <summary>
            /// <para>The progress of instance data backup or restoration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
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
            /// <para>local</para>
            /// </summary>
            [NameInMap("RenderingType")]
            [Validation(Required=false)]
            public string RenderingType { get; set; }

            /// <summary>
            /// <para>The session status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disConnect: The session is disconnected.</description></item>
            /// <item><description>connect: The session is connected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelTags> Tags { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kmma/xxE9WtwL/ADvZ****</para>
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
