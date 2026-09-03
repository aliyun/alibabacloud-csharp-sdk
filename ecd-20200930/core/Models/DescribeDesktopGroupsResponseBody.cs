// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of shared cloud computers.</para>
        /// </summary>
        [NameInMap("DesktopGroups")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupsResponseBodyDesktopGroups> DesktopGroups { get; set; }
        public class DescribeDesktopGroupsResponseBodyDesktopGroups : TeaModel {
            /// <summary>
            /// <para>The account type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The number of concurrent sessions allowed per cloud computer in a multi-session shared cloud computer group with multiple instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public long? BindAmount { get; set; }

            /// <summary>
            /// <para>This parameter applies only to subscription shared cloud computers and indicates the initial number of cloud computers purchased. Valid values: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The maximum duration that a session can remain in the connected state. The session is automatically disconnected when this duration is reached. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600000</para>
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// <para>The list of cloud computer counts by status.</para>
            /// </summary>
            [NameInMap("CountPerStatus")]
            [Validation(Required=false)]
            public List<DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus> CountPerStatus { get; set; }
            public class DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus : TeaModel {
                /// <summary>
                /// <para>The number of cloud computers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The cloud computer status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The time is displayed in UTC in the ISO 8601 standard format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-17T14:51:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1007214305******</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The user disk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The user disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that have been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>The ID of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-2i8qxpv6t1a03****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The name of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudComputerPool01</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>The cloud computer specification. You can call <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> to query the specification IDs supported by Wuying Cloud Computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.4c4g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The number of authorized users for the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public int? EndUserCount { get; set; }

            /// <summary>
            /// <para>The domain name of Microsoft Entra ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>contoso.onmicrosoft.com</para>
            /// </summary>
            [NameInMap("EntraDomainName")]
            [Validation(Required=false)]
            public string EntraDomainName { get; set; }

            /// <summary>
            /// <para>The environment ID. This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adifa****</para>
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The environment type. This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription shared cloud computer.</para>
            /// <para>The time follows the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The list of expiration times.</para>
            /// </summary>
            [NameInMap("ExpiredTimes")]
            [Validation(Required=false)]
            public List<string> ExpiredTimes { get; set; }

            /// <summary>
            /// <para>The number of GPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// <para>The GPU driver version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// <para>The GPU memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16 GiB</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The maximum idle duration after a user session is established. If no keyboard or mouse operations are performed within this duration, the session is disconnected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90000</para>
            /// </summary>
            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-gq15cq5ydlvwn****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory is an LDAP directory.</para>
            /// </summary>
            [NameInMap("IsLdap")]
            [Validation(Required=false)]
            public bool? IsLdap { get; set; }

            /// <summary>
            /// <para>The retention period after a session is disconnected. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is always retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// <para>The load balancing policy for multi-session shared cloud computers with multiple instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public long? LoadPolicy { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>For pay-as-you-go shared cloud computers, this parameter indicates the maximum number of cloud computers that can be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16384</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>For pay-as-you-go shared cloud computers, this parameter indicates the minimum number of cloud computers that can be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// <para>The name of the office network to which the shared cloud computer belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-467671****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The ID of the office network to which the shared cloud computers belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The account system type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The organization ID of the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-aliyun-wy-org-id</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The cloud computer template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bundle_eds_general_4c8g_s8d5_win2019</para>
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard Office Template</para>
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// <para>The type of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public long? OwnType { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The ID of the policy associated with the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-53iyi2aar0nd6c8qj</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The list of cloud computer policy IDs.</para>
            /// </summary>
            [NameInMap("PolicyGroupIdList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIdList { get; set; }

            /// <summary>
            /// <para>The policy name associated with the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All enabled policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The list of cloud computer policy names.</para>
            /// </summary>
            [NameInMap("PolicyGroupNameList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNameList { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The ID of the QoS rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-5605u0gelk200****</para>
            /// </summary>
            [NameInMap("QosRuleId")]
            [Validation(Required=false)]
            public string QosRuleId { get; set; }

            /// <summary>
            /// <para>The session occupancy threshold used as the auto scaling trigger condition for multi-session shared cloud computers. The session occupancy is calculated by using the following formula:</para>
            /// <para><c>Session occupancy = Number of bound sessions / (Total number of cloud computers × Maximum number of sessions supported by each cloud computer) × 100%</c></para>
            /// <para>When the session occupancy reaches this threshold, new cloud computers are created. When the session occupancy is below this threshold, excess cloud computers are deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// <para>The reset type of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public long? ResetType { get; set; }

            /// <summary>
            /// <para>The convenience user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ug-3f6c8a2b****</para>
            /// </summary>
            [NameInMap("SimpleUserGroupId")]
            [Validation(Required=false)]
            public string SimpleUserGroupId { get; set; }

            /// <summary>
            /// <para>The status of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The idle shutdown duration. When the cloud computer has been idle for this duration, it is automatically shut down. If a user connects after shutdown, the cloud computer automatically starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900000</para>
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// <para>The subnet ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf63bb6*****8gfytm</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>The system cloud disk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The system cloud disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDesktopGroupsResponseBodyDesktopGroupsTags> Tags { get; set; }
            public class DescribeDesktopGroupsResponseBodyDesktopGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desktop_group_name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-dq2mybjr23yw*****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The user group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Group</para>
            /// </summary>
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) path of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("UserOuPath")]
            [Validation(Required=false)]
            public string UserOuPath { get; set; }

            /// <summary>
            /// <para>The version number of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>Indicates whether encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for disk encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e5409ada-xxxx-xxxx-xxxx-89e31e23e993</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
