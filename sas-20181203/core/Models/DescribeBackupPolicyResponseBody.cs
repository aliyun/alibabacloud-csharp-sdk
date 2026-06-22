// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the policy.</para>
        /// </summary>
        [NameInMap("BackupPolicyDetail")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDetail BackupPolicyDetail { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDetail : TeaModel {
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
            /// <para>The ID of the anti-ransomware backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51880</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testBuckUp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The content of the anti-ransomware protection policy. This parameter is in JSON format. The following fields are included:</para>
            /// <list type="bullet">
            /// <item><description><b>IsDefault</b>: The type of the protection policy. Valid values:<list type="bullet">
            /// <item><description><b>1</b>: recommended policy</description></item>
            /// <item><description><b>0</b>: custom policy</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Include</b>: The file types to protect. If all file types are protected, this parameter is set to [].</description></item>
            /// <item><description><b>Source</b>: The server folders to protect. If all folders are protected, this parameter is set to [].</description></item>
            /// <item><description><b>ExcludeSystemPath</b>: Specifies whether to exclude specified folders. Set this parameter to <b>true</b> to exclude folders. If no folders need to be excluded, you do not need to configure this parameter.</description></item>
            /// <item><description><b>Exclude</b>: The specified protection folder addresses. If no specific protection folder addresses are configured, this parameter is set to [].</description></item>
            /// <item><description><b>Schedule</b>: Settings for the execution time and interval of the data backup task. Specify an off-peak hour that is not on the hour. Examples:<list type="bullet">
            /// <item><description>Example 1: I|1583216092|P21D indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy executes at an interval of 3 weeks.</description></item>
            /// <item><description>Example 2: I|1583216092|PT24H indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy executes at an interval of 24 hours.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Retention</b>: Settings for the retention period of backup data, in days. 7 indicates 1 week, 365 indicates 1 year, and -1 indicates permanent retention.</description></item>
            /// <item><description><b>SpeedLimiter</b>: Settings for the backup network bandwidth throttling. For example, 0:24:30720 indicates that the backup network bandwidth throttling is 30 MB/s from 00:00 to 24:00.</description></item>
            /// <item><description><b>UseVss</b>: Specifies whether to enable the Volume Shadow Copy Service (VSS) feature for Windows. Valid values:<list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: not enabled</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The VSS feature is available only for Windows systems. After this feature is enabled, it effectively reduces the issue of individual file backup failures caused by process occupation. Enable this feature. After this feature is enabled, file backup for exFAT and FAT32 disk formats is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;Exclude&quot;: [
            ///             &quot;/bin/&quot;,
            ///             &quot;/usr/bin/&quot;,
            ///             &quot;/sbin/&quot;,
            ///             &quot;/boot/&quot;,
            ///             &quot;/proc/&quot;,
            ///             &quot;/sys/&quot;,
            ///             &quot;/srv/&quot;,
            ///             &quot;/lib/&quot;,
            ///             &quot;/selinux/&quot;,
            ///             &quot;/usr/sbin/&quot;,
            ///             &quot;/run/&quot;,
            ///             &quot;/lib32/&quot;,
            ///             &quot;/lib64/&quot;,
            ///             &quot;/lost+found/&quot;,
            ///             &quot;/var/lib/kubelet/&quot;,
            ///             &quot;/var/lib/ntp/proc&quot;,
            ///             &quot;/var/lib/container&quot;,
            ///             &quot;Windows\\&quot;,
            ///             &quot;Python27\\&quot;,
            ///             &quot;Program Files (x86)\\&quot;,
            ///             &quot;Program Files\\&quot;,
            ///             &quot;Boot\\&quot;,
            ///             &quot;$RECYCLE.BIN&quot;,
            ///             &quot;System Volume Information\\&quot;,
            ///             &quot;Users\\Administrator\\NTUSER.DAT*&quot;,
            ///             &quot;ProgramData\\&quot;,
            ///             &quot;pagefile.sys&quot;,
            ///             &quot;Users\\Default\\NTUSER.DAT*&quot;,
            ///             &quot;Users\\Administrator\\ntuser.*&quot;
            ///       ],
            ///       &quot;ExcludeSystemPath&quot;: true,
            ///       &quot;Include&quot;: [],
            ///       &quot;IsDefault&quot;: 1,
            ///       &quot;Retention&quot;: 7,
            ///       &quot;Schedule&quot;: &quot;I|1630689360|PT24H&quot;,
            ///       &quot;Source&quot;: [],
            ///       &quot;SpeedLimiter&quot;: &quot;&quot;,
            ///       &quot;UseVss&quot;: true
            /// }</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The version of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1.0.0</b></description></item>
            /// <item><description><b>2.0.0</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>The region ID of the backup service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enabled</b>: The policy is manually enabled.</para>
            /// </description></item>
            /// <item><description><para><b>disabled</b>: The policy is manually disabled. After the policy is disabled, running backup tasks are stopped.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: The policy is disabled by the system because the anti-ransomware capacity is exceeded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>closed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUIDs of the servers for which the backup policy is enabled.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
