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
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of anti-ransomware policies returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The details of the anti-ransomware policy.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeBackupPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeBackupPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The number of the servers on which the anti-ransomware agent is in an abnormal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClientErrorCount")]
            [Validation(Required=false)]
            public int? ClientErrorCount { get; set; }

            /// <summary>
            /// <para>The UUIDs of the servers on which the anti-ransomware agent is in an <b>abnormal</b> state.</para>
            /// </summary>
            [NameInMap("ClientErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ClientErrorUuidList { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: normal</description></item>
            /// <item><description><b>exception</b>: abnormal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The number of the servers on which the anti-ransomware agent is in a normal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HealthClientCount")]
            [Validation(Required=false)]
            public int? HealthClientCount { get; set; }

            /// <summary>
            /// <para>The UUIDs of the servers on which the anti-ransomware agent is in a <b>normal</b> state.</para>
            /// </summary>
            [NameInMap("HealthClientUuidList")]
            [Validation(Required=false)]
            public List<string> HealthClientUuidList { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time when the anti-ransomware policy was last updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719488535027</para>
            /// </summary>
            [NameInMap("LastStatusSyncTime")]
            [Validation(Required=false)]
            public long? LastStatusSyncTime { get; set; }

            /// <summary>
            /// <para>The name of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityStrategy-20200303</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configurations of the anti-ransomware policy. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IsDefault</b>: the type of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: recommended policy</description></item>
            /// <item><description><b>0</b>: custom policy</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Include</b>: the format of the files that are protected. If the value of this field is [], all formats of files are protected.</para>
            /// </description></item>
            /// <item><description><para><b>Source</b>: the directory that is protected. If the value of this field is [], all directories are protected.</para>
            /// </description></item>
            /// <item><description><para><b>ExcludeSystemPath</b>: indicates whether a specified directory is excluded from the anti-ransomware policy. If the value of this field is <b>true</b>, a directory is excluded. If this field is left empty, no directories are excluded.</para>
            /// </description></item>
            /// <item><description><para><b>Exclude</b>: the directory that is excluded from the anti-ransomware policy. If the value of this field is [], no directories are excluded.</para>
            /// </description></item>
            /// <item><description><para><b>Schedule</b>: the start time and interval of a data backup task. We recommend that you specify a start time that begins during off-peak hours but does not start on the hour. Examples:</para>
            /// <list type="bullet">
            /// <item><description>If the value of this field is I|1583216092|P21D, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of three weeks.</description></item>
            /// <item><description>If the value of this field is I|1583216092|PT24H, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of 24 hours.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Retention</b>: the period during which backup data is retained. Unit: days. If the value of this field is 7, backup data is retained for a week. If the value of this field is 365, backup data is retained for a year. If the value of this field is -1, backup data is permanently retained.</para>
            /// </description></item>
            /// <item><description><para><b>SpeedLimiter</b>: the limit on the network bandwidth for data backup tasks. If the value of this field is 0:24:30720, the maximum bandwidth for a data backup task is 30 MB/s from 00:00 to 24:00.</para>
            /// </description></item>
            /// <item><description><para><b>UseVss</b>: indicates whether the VSS feature is enabled. The feature is available only for Windows servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> The VSS feature is available only if you create the anti-ransomware policy for Windows servers. After you enable the feature, the number of backup failures due to running processes is significantly reduced. We recommend that you enable the VSS feature. After you enable the feature, the data of disks that are in the exFAT and FAT32 formats cannot be backed up.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Exclude&quot;:[&quot;/bin/&quot;,&quot;/usr/bin/&quot;,&quot;/sbin/&quot;,&quot;/boot/&quot;,&quot;/proc/&quot;,&quot;/sys/&quot;,&quot;/srv/&quot;,&quot;/lib/&quot;,&quot;/selinux/&quot;,&quot;/usr/sbin/&quot;,&quot;/run/&quot;,&quot;/lib32/&quot;,&quot;/lib64/&quot;,&quot;/lost+found/&quot;,&quot;/var/lib/kubelet/&quot;,&quot;/var/lib/ntp/proc&quot;,&quot;/var/lib/container&quot;,&quot;Windows\\&quot;,&quot;Python27\\&quot;,&quot;Program Files (x86)\\&quot;,&quot;Program Files\\&quot;,&quot;Boot\\&quot;,&quot;$RECYCLE.BIN&quot;,&quot;System Volume Information\\&quot;,&quot;Users\\Administrator\\NTUSER.DAT*&quot;,&quot;ProgramData\\&quot;,&quot;pagefile.sys&quot;,&quot;Users\\Default\\NTUSER.DAT*&quot;,&quot;Users\\Administrator\\ntuser.*&quot;],&quot;ExcludeSystemPath&quot;:true,&quot;Include&quot;:[],&quot;IsDefault&quot;:1,&quot;Retention&quot;:7,&quot;Schedule&quot;:&quot;I|1630689360|PT24H&quot;,&quot;Source&quot;:[],&quot;SpeedLimiter&quot;:&quot;&quot;,&quot;UseVss&quot;:true}</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The ID of the region that you specified for data backup when you installed the anti-ransomware agent for the server not deployed on Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch-hangzhou</para>
            /// </summary>
            [NameInMap("PolicyRegionId")]
            [Validation(Required=false)]
            public string PolicyRegionId { get; set; }

            /// <summary>
            /// <para>The version of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1.0.0</description></item>
            /// <item><description>2.0.0</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>The previous status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: The anti-ransomware policy is manually enabled.</description></item>
            /// <item><description><b>disabled</b>: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.</description></item>
            /// <item><description><b>closed</b>: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PreStatus")]
            [Validation(Required=false)]
            public string PreStatus { get; set; }

            /// <summary>
            /// <para>The UUIDs that are returned based on the value of the MachineRemark request parameter.</para>
            /// </summary>
            [NameInMap("RemarkedUuidList")]
            [Validation(Required=false)]
            public List<string> RemarkedUuidList { get; set; }

            /// <summary>
            /// <para>The type of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OUT_CLOUD</b>: server not deployed on Alibaba Cloud</description></item>
            /// <item><description><b>ALIYUN</b>: Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>TRIPARTITE</b>: simple application server</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OUT_CLOUD</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The number of servers on which data backup is exceptional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ServiceErrorCount")]
            [Validation(Required=false)]
            public int? ServiceErrorCount { get; set; }

            /// <summary>
            /// <para>The UUIDs of the servers on which data backup is exceptional.</para>
            /// </summary>
            [NameInMap("ServiceErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ServiceErrorUuidList { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: The anti-ransomware policy is manually enabled.</description></item>
            /// <item><description><b>disabled</b>: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.</description></item>
            /// <item><description><b>closed</b>: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The upgrade status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotUpgraded</b></description></item>
            /// <item><description><b>Upgrading</b></description></item>
            /// <item><description><b>UpgradeFailed</b></description></item>
            /// <item><description><b>UpgradeSuccess</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Upgrading</para>
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

            /// <summary>
            /// <para>The UUIDs of the servers to which the anti-ransomware policy is applied.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
