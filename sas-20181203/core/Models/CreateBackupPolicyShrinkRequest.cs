// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the policy to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ServerBackUpPolicy01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>IsDefault</b>: The type of the policy to create. Valid values:<list type="bullet">
        /// <item><description><b>1</b>: Recommended policy.</description></item>
        /// <item><description><b>0</b>: Custom policy.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Include</b>: The file types to protect. To protect all file types, set this parameter to [].</description></item>
        /// <item><description><b>Source</b>: The server folders to protect. To protect all folders, set this parameter to [].</description></item>
        /// <item><description><b>ExcludeSystemPath</b>: Specifies whether to exclude specified folders. Set this parameter to <b>true</b> to exclude folders. If you do not want to exclude folders, you do not need to set this parameter.</description></item>
        /// <item><description><b>Exclude</b>: The folders to exclude from protection. If you do not want to exclude any folders, set this parameter to [].</description></item>
        /// <item><description><b>Schedule</b>: The start time and interval for the data backup task. Specify an off-peak hour that is not on the hour. Examples:<list type="bullet">
        /// <item><description>Example 1: I|1583216092|P21D indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy execution interval is 3 weeks.</description></item>
        /// <item><description>Example 2: I|1583216092|PT24H indicates that the data backup starts at 2020-03-03 14:14:52 and the backup policy execution interval is 24 hours.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Retention</b>: The retention period of backup data, in days. A value of 7 indicates 1 week, 365 indicates 1 year, and -1 indicates permanent retention.</description></item>
        /// <item><description><b>SpeedLimiter</b>: The network bandwidth throttling for backup. For example, 0:24:30720 indicates that the backup network bandwidth limit is 30 MB/s from 00:00 to 24:00.</description></item>
        /// <item><description><b>UseVss</b>: Specifies whether to enable the Volume Shadow Copy Service (VSS) feature for Windows. Valid values:<list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The VSS feature applies only to Windows systems. After this feature is enabled, the issue of individual file backup failures caused by process occupation is effectively reduced. Enable this feature. After this feature is enabled, file backup for exFAT and FAT32 disk formats is not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;IsDefault&quot;:1,&quot;Include&quot;:[],&quot;Source&quot;:[],&quot;Schedule&quot;:&quot;I|1648061040|PT24H&quot;,&quot;Retention&quot;:7,&quot;SpeedLimiter&quot;:&quot;&quot;,&quot;ExcludeSystemPath&quot;:true,&quot;Exclude&quot;:[&quot;/bin/&quot;,&quot;/usr/bin/&quot;,&quot;/sbin/&quot;,&quot;/boot/&quot;,&quot;/proc/&quot;,&quot;/sys/&quot;,&quot;/srv/&quot;,&quot;/lib/&quot;,&quot;/selinux/&quot;,&quot;/usr/sbin/&quot;,&quot;/run/&quot;,&quot;/lib32/&quot;,&quot;/lib64/&quot;,&quot;/lost+found/&quot;,&quot;/var/lib/kubelet/&quot;,&quot;/var/lib/ntp/proc&quot;,&quot;/var/lib/container&quot;,&quot;Windows&quot;,&quot;Python27&quot;,&quot;Program Files (x86)&quot;,&quot;Program Files&quot;,&quot;Boot&quot;,&quot;$RECYCLE.BIN&quot;,&quot;System Volume Information&quot;,&quot;Users\Administrator\NTUSER.DAT*&quot;,&quot;ProgramData&quot;,&quot;pagefile.sys&quot;,&quot;Users\Default\NTUSER.DAT*&quot;,&quot;Users\Administrator\ntuser.*&quot;],&quot;UseVss&quot;:true}&quot;</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string PolicyShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the non-Alibaba Cloud server.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSupportRegion~~">DescribeSupportRegion</a> operation to query the regions supported by the anti-ransomware feature, and then select the supported region closest to your non-Alibaba Cloud server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ch-hangzhou</para>
        /// </summary>
        [NameInMap("PolicyRegionId")]
        [Validation(Required=false)]
        public string PolicyRegionId { get; set; }

        /// <summary>
        /// <para>The version of the policy. Set the value to <b>2.0.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The method used to cover assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_MACHINE</b>: All assets.<remarks>
        /// <para>To cover all assets of this type, set this parameter to <b>ALL_MACHINE</b>. In this case, <b>UuidList</b> is invalid. Only one policy that covers all assets can exist for each server type.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_MACHINE</para>
        /// </summary>
        [NameInMap("SelectType")]
        [Validation(Required=false)]
        public string SelectType { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to protect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;, &quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
