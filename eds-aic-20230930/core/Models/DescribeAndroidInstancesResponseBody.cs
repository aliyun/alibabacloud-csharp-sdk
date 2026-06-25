// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance information.</para>
        /// </summary>
        [NameInMap("InstanceModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesResponseBodyInstanceModel> InstanceModel { get; set; }
        public class DescribeAndroidInstancesResponseBodyInstanceModel : TeaModel {
            /// <summary>
            /// <para>The ID of the instance group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag-ayyhomlal7po****</para>
            /// </summary>
            [NameInMap("AndroidInstanceGroupId")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The instance group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AndroidInstanceGroupName</para>
            /// </summary>
            [NameInMap("AndroidInstanceGroupName")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-8at8h6ejkadjh****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AndroidInstanceStatus")]
            [Validation(Required=false)]
            public string AndroidInstanceStatus { get; set; }

            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-i7yv6tkn7kh8dv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The physical instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-9ey6io0q58rcd****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The application management policy information. This corresponds to the blacklists and whitelists management of application management policies in the console.</para>
            /// </summary>
            [NameInMap("AppManagePolicy")]
            [Validation(Required=false)]
            public DescribeAndroidInstancesResponseBodyInstanceModelAppManagePolicy AppManagePolicy { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelAppManagePolicy : TeaModel {
                /// <summary>
                /// <para>The application management policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amp-dgiavcvibfdds****</para>
                /// </summary>
                [NameInMap("AppManagePolicyId")]
                [Validation(Required=false)]
                public string AppManagePolicyId { get; set; }

                /// <summary>
                /// <para>The name of the application management policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Application group 1</para>
                /// </summary>
                [NameInMap("AppManagePolicyName")]
                [Validation(Required=false)]
                public string AppManagePolicyName { get; set; }

            }

            /// <summary>
            /// <para>The assigned user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public string AuthorizedUserId { get; set; }

            /// <summary>
            /// <para>The bandwidth package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-0q6ixs7vpxcizp***</para>
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
            /// <para>The bound user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            [NameInMap("BizImageType")]
            [Validation(Required=false)]
            public string BizImageType { get; set; }

            /// <summary>
            /// <para>The tag array.</para>
            /// </summary>
            [NameInMap("BizTags")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelBizTags> BizTags { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelBizTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>releaseFlag</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The billing type of the instance.</para>
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
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The disk information.</para>
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
            /// <para>The display settings.</para>
            /// </summary>
            [NameInMap("DisplayConfig")]
            [Validation(Required=false)]
            public DescribeAndroidInstancesResponseBodyInstanceModelDisplayConfig DisplayConfig { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelDisplayConfig : TeaModel {
                /// <summary>
                /// <para>DPI。</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("Dpi")]
                [Validation(Required=false)]
                public int? Dpi { get; set; }

                /// <summary>
                /// <para>The frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                /// <summary>
                /// <para>Indicates whether the resolution is locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("LockResolution")]
                [Validation(Required=false)]
                public string LockResolution { get; set; }

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

            }

            /// <summary>
            /// <para>The downstream bandwidth throttling. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("DownBandwidthLimit")]
            [Validation(Required=false)]
            public int? DownBandwidthLimit { get; set; }

            /// <summary>
            /// <para>The error reason for instance data backup failure or recovery failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FilePathNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-15T02:03:33Z</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-075cllfeuazh0****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3.867</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp.basic.small</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InternetStatus")]
            [Validation(Required=false)]
            public string InternetStatus { get; set; }

            /// <summary>
            /// <para>The key pair ID.</para>
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
            /// <para>The IP address of the network interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.22.48</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIpv6Address")]
            [Validation(Required=false)]
            public string NetworkInterfaceIpv6Address { get; set; }

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
            /// <para>The network ID. This corresponds to the network selected during creation in the console (basic shared network or advanced shared network).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen+dir-211620****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The persistent session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-0btrd5zj8epo****</para>
            /// </summary>
            [NameInMap("PersistentAppInstanceId")]
            [Validation(Required=false)]
            public string PersistentAppInstanceId { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The independent device storage information of the cloud phone matrix edition instance.
            /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available..</para>
            /// </summary>
            [NameInMap("PhoneDataInfo")]
            [Validation(Required=false)]
            public DescribeAndroidInstancesResponseBodyInstanceModelPhoneDataInfo PhoneDataInfo { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelPhoneDataInfo : TeaModel {
                /// <summary>
                /// <para>The independent device storage ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pd-sbcudgidbhb****</para>
                /// </summary>
                [NameInMap("PhoneDataId")]
                [Validation(Required=false)]
                public string PhoneDataId { get; set; }

                /// <summary>
                /// <para>The capacity of the independent device storage. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PhoneDataVolume")]
                [Validation(Required=false)]
                public int? PhoneDataVolume { get; set; }

            }

            /// <summary>
            /// <para>The policy group ID.</para>
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
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PublicIpv6Address")]
            [Validation(Required=false)]
            public string PublicIpv6Address { get; set; }

            /// <summary>
            /// <para>The public network rate limiting rule ID (applies only to premium bandwidth).</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-5605u0gelk200****</para>
            /// </summary>
            [NameInMap("QosRuleId")]
            [Validation(Required=false)]
            public string QosRuleId { get; set; }

            /// <summary>
            /// <para>The progress of instance data backup or recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

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
            /// <para>The rendering type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local</para>
            /// </summary>
            [NameInMap("RenderingType")]
            [Validation(Required=false)]
            public string RenderingType { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The matrix status.
            /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available..</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ServerStatus")]
            [Validation(Required=false)]
            public string ServerStatus { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The cloud phone matrix specification.
            /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available..</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpm.gx7.10xlarge</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The session connection status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The streaming mode of instances in the cloud phone matrix.
            /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available..</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamMode")]
            [Validation(Required=false)]
            public int? StreamMode { get; set; }

            /// <summary>
            /// <para>The Android system version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Android 11</para>
            /// </summary>
            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelTags> Tags { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The upstream bandwidth throttling. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UpBandwidthLimit")]
            [Validation(Required=false)]
            public int? UpBandwidthLimit { get; set; }

            /// <summary>
            /// <para>The vSwitch ID in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zepmau2hsbhos42****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that indicates the position to which the current call has read. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kmma/xxE9WtwL/ADvZ****</para>
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
