// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the anti-ransomware policy.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;IsDefault&quot;:1,&quot;Include&quot;:[],&quot;Source&quot;:[],&quot;Schedule&quot;:&quot;I|1648061040|PT24H&quot;,&quot;Retention&quot;:7,&quot;SpeedLimiter&quot;:&quot;&quot;,&quot;ExcludeSystemPath&quot;:true,&quot;Exclude&quot;:[&quot;/bin/&quot;,&quot;/usr/bin/&quot;,&quot;/sbin/&quot;,&quot;/boot/&quot;,&quot;/proc/&quot;,&quot;/sys/&quot;,&quot;/srv/&quot;,&quot;/lib/&quot;,&quot;/selinux/&quot;,&quot;/usr/sbin/&quot;,&quot;/run/&quot;,&quot;/lib32/&quot;,&quot;/lib64/&quot;,&quot;/lost+found/&quot;,&quot;/var/lib/kubelet/&quot;,&quot;/var/lib/ntp/proc&quot;,&quot;/var/lib/container&quot;,&quot;Windows&quot;,&quot;Python27&quot;,&quot;Program Files (x86)&quot;,&quot;Program Files&quot;,&quot;Boot&quot;,&quot;$RECYCLE.BIN&quot;,&quot;System Volume Information&quot;,&quot;Users\Administrator\NTUSER.DAT*&quot;,&quot;ProgramData&quot;,&quot;pagefile.sys&quot;,&quot;Users\Default\NTUSER.DAT*&quot;,&quot;Users\Administrator\ntuser.*&quot;],&quot;UseVss&quot;:true}&quot;</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string PolicyShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the server that is not deployed on Alibaba Cloud.</para>
        /// <remarks>
        /// <para> We recommend that you specify the ID of the supported region that is the nearest to the location of the server. You can call the <a href="~~DescribeSupportRegion~~">DescribeSupportRegion</a> operation to query the supported regions of the anti-ransomware feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ch-hangzhou</para>
        /// </summary>
        [NameInMap("PolicyRegionId")]
        [Validation(Required=false)]
        public string PolicyRegionId { get; set; }

        /// <summary>
        /// <para>The version of the anti-ransomware policy. Set the value to <b>2.0.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers that you want to protect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;, &quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
