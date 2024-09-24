// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the anti-ransomware policy.</para>
        /// </summary>
        [NameInMap("BackupPolicyDetail")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDetail BackupPolicyDetail { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDetail : TeaModel {
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
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51880</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testBuckUp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para><b>IsDefault</b>: the type of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: recommended policy</description></item>
            /// <item><description><b>0</b>: custom policy</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Include</b>: the format of the files that you want to protect. If you want to protect the files in all formats, set this field to [].</para>
            /// </description></item>
            /// <item><description><para><b>Source</b>: the directory that you want to protect. If you want to protect all directories, set this field to [].</para>
            /// </description></item>
            /// <item><description><para><b>ExcludeSystemPath</b>: specifies whether to exclude a specific directory from the anti-ransomware policy. If you want to exclude a directory, set this field to <b>true</b>. If you do not want to exclude a directory, leave this field empty.</para>
            /// </description></item>
            /// <item><description><para><b>Exclude</b>: the directory that you want to exclude from the anti-ransomware policy. If you do not want to exclude a directory, set this field to [].</para>
            /// </description></item>
            /// <item><description><para><b>Schedule</b>: the start time and interval of a data backup task. We recommend that you specify a start time that begins during off-peak hours but does not start on the hour. Examples:</para>
            /// <list type="bullet">
            /// <item><description>If you set this field to I|1583216092|P21D, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of three weeks.</description></item>
            /// <item><description>If you set this field to I|1583216092|PT24H, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of 24 hours.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Retention</b>: the period during which backup data is retained. Unit: days. If you set this field to 7, backup data is retained for a week. If you set this field to 365, backup data is retained for a year. If you set this field to -1, backup data is permanently retained.</para>
            /// </description></item>
            /// <item><description><para><b>SpeedLimiter</b>: the limit on the network bandwidth for data backup tasks. If you set this field to 0:24:30720, the maximum bandwidth for a data backup task is 30 MB/s from 00:00 to 24:00.</para>
            /// </description></item>
            /// <item><description><para><b>UseVss</b>: specifies whether to enable the VSS feature. The feature is available only for Windows servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> The VSS feature is available only if you create the anti-ransomware policy for Windows servers. After you enable the feature, the number of backup failures due to running processes is significantly reduced. We recommend that you enable the VSS feature. After you enable the feature, the data of disks that are in the exFAT and FAT32 formats cannot be backed up.</para>
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
            /// <para>The version of the anti-ransomware policy.</para>
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
            /// <para>The ID of the region in which backup data is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: The anti-ransomware policy is manually enabled.</description></item>
            /// <item><description><b>disabled</b>: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.</description></item>
            /// <item><description><b>closed</b>: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>closed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>An array consisting of the UUIDs of the servers to which the anti-ransomware policy is applied.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
