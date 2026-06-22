// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries displayed on the current page during paginated queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of backup policies on each page during paginated queries. Default value: 10, which indicates that each page contains 10 backup policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of backup policies in the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The details of protection policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeBackupPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeBackupPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The number of errors reported by the anti-ransomware client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClientErrorCount")]
            [Validation(Required=false)]
            public int? ClientErrorCount { get; set; }

            /// <summary>
            /// <para>The UUID list of clients in the <b>abnormal</b> state.</para>
            /// </summary>
            [NameInMap("ClientErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ClientErrorUuidList { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>running</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>exception</b>: Abnormal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The number of clients in the normal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HealthClientCount")]
            [Validation(Required=false)]
            public int? HealthClientCount { get; set; }

            /// <summary>
            /// <para>The UUID list of clients in the <b>healthy</b> state.</para>
            /// </summary>
            [NameInMap("HealthClientUuidList")]
            [Validation(Required=false)]
            public List<string> HealthClientUuidList { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The latest update time of the anti-ransomware protection policy status, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719488535027</para>
            /// </summary>
            [NameInMap("LastStatusSyncTime")]
            [Validation(Required=false)]
            public long? LastStatusSyncTime { get; set; }

            /// <summary>
            /// <para>The name of the anti-ransomware protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityStrategy-20200303</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The content of the anti-ransomware protection policy. This parameter is in JSON format. The following section describes the fields:</para>
            /// <list type="bullet">
            /// <item><description><b>IsDefault</b>: The type of the protection policy. Valid values:<list type="bullet">
            /// <item><description><b>1</b>: Recommended policy.</description></item>
            /// <item><description><b>0</b>: Custom policy.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Include</b>: The file types to protect. To protect all file types, set this parameter to [].</description></item>
            /// <item><description><b>Source</b>: The server directories to protect. To protect all directories, set this parameter to [].</description></item>
            /// <item><description><b>ExcludeSystemPath</b>: Specifies whether to exclude specified directories. Set this parameter to <b>true</b> to exclude directories. If you do not want to exclude directories, you do not need to set this parameter.</description></item>
            /// <item><description><b>Exclude</b>: The specified protection directory addresses. If no specific protection directory address is set, set this parameter to [].</description></item>
            /// <item><description><b>Schedule</b>: The execution time and interval of the data backup task. We recommend that you specify a non-peak hour at a non-round time. The following provides setting examples:<list type="bullet">
            /// <item><description>Example 1: I|1583216092|P21D indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy is executed at an interval of 3 weeks.</description></item>
            /// <item><description>Example 2: I|1583216092|PT24H indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy is executed at an interval of 24 hours.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Retention</b>: The retention period of the backup data, in days. 7 indicates 1 week, 365 indicates 1 year, and -1 indicates permanent retention.</description></item>
            /// <item><description><b>SpeedLimiter</b>: The backup network bandwidth limit. For example, 0:24:30720 indicates that the backup network bandwidth limit from 0:00 to 24:00 is 30 MByte/s.</description></item>
            /// <item><description><b>UseVss</b>: Specifies whether to enable the VSS (Windows) feature. Valid values:<list type="bullet">
            /// <item><description><b>true</b>: Enable.</description></item>
            /// <item><description><b>false</b>: Disable.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The VSS (Windows) feature is only available for Windows systems. After it is enabled, it can effectively reduce the issue of individual file backup failures caused by process occupation. We recommend that you enable this feature. After this feature is enabled, file backup for exFAT and FAT32 disk formats will not be supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Exclude&quot;:[&quot;/bin/&quot;,&quot;/usr/bin/&quot;,&quot;/sbin/&quot;,&quot;/boot/&quot;,&quot;/proc/&quot;,&quot;/sys/&quot;,&quot;/srv/&quot;,&quot;/lib/&quot;,&quot;/selinux/&quot;,&quot;/usr/sbin/&quot;,&quot;/run/&quot;,&quot;/lib32/&quot;,&quot;/lib64/&quot;,&quot;/lost+found/&quot;,&quot;/var/lib/kubelet/&quot;,&quot;/var/lib/ntp/proc&quot;,&quot;/var/lib/container&quot;,&quot;Windows\\&quot;,&quot;Python27\\&quot;,&quot;Program Files (x86)\\&quot;,&quot;Program Files\\&quot;,&quot;Boot\\&quot;,&quot;$RECYCLE.BIN&quot;,&quot;System Volume Information\\&quot;,&quot;Users\\Administrator\\NTUSER.DAT*&quot;,&quot;ProgramData\\&quot;,&quot;pagefile.sys&quot;,&quot;Users\\Default\\NTUSER.DAT*&quot;,&quot;Users\\Administrator\\ntuser.*&quot;],&quot;ExcludeSystemPath&quot;:true,&quot;Include&quot;:[],&quot;IsDefault&quot;:1,&quot;Retention&quot;:7,&quot;Schedule&quot;:&quot;I|1630689360|PT24H&quot;,&quot;Source&quot;:[],&quot;SpeedLimiter&quot;:&quot;&quot;,&quot;UseVss&quot;:true}</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The region ID of the backup service selected when installing the anti-ransomware client on non-Alibaba Cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch-hangzhou</para>
            /// </summary>
            [NameInMap("PolicyRegionId")]
            [Validation(Required=false)]
            public string PolicyRegionId { get; set; }

            /// <summary>
            /// <para>The version of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1.0.0.</description></item>
            /// <item><description>2.0.0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>The previous status of the anti-ransomware protection policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>enabled</b>: The policy is manually enabled.</para>
            /// </description></item>
            /// <item><description><para><b>disabled</b>: The policy is manually disabled. After the policy is disabled, running backup tasks will stop.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: The anti-ransomware capacity is exceeded, and the system disables the policy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PreStatus")]
            [Validation(Required=false)]
            public string PreStatus { get; set; }

            /// <summary>
            /// <para>The UUID list of servers returned after retrieval by the MachineRemark request parameter.</para>
            /// </summary>
            [NameInMap("RemarkedUuidList")]
            [Validation(Required=false)]
            public List<string> RemarkedUuidList { get; set; }

            /// <summary>
            /// <para>The server type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OUT_CLOUD</b>: Non-Alibaba Cloud server.</description></item>
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud server.</description></item>
            /// <item><description><b>TRIPARTITE</b>: Simple Application Server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OUT_CLOUD</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The number of servers with data backup exceptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ServiceErrorCount")]
            [Validation(Required=false)]
            public int? ServiceErrorCount { get; set; }

            /// <summary>
            /// <para>The UUID list of servers with data backup exceptions.</para>
            /// </summary>
            [NameInMap("ServiceErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ServiceErrorUuidList { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware protection policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>enabled</b>: The policy is manually enabled.</para>
            /// </description></item>
            /// <item><description><para><b>disabled</b>: The policy is manually disabled. After the policy is disabled, running backup tasks will stop.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: The anti-ransomware capacity is exceeded, and the system disables the policy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The upgrade status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotUpgraded</b>: Not upgraded.</description></item>
            /// <item><description><b>Upgrading</b>: Upgrading.</description></item>
            /// <item><description><b>UpgradeFailed</b>: Upgrade failed.</description></item>
            /// <item><description><b>UpgradeSuccess</b>: Upgrade succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Upgrading</para>
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

            /// <summary>
            /// <para>The UUID list of servers protected by the anti-ransomware protection policy.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. It can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
