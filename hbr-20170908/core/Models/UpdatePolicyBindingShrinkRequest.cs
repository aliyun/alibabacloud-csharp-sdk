// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdatePolicyBindingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The advanced options.</para>
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public string AdvancedOptionsShrink { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1************dtv</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy is suspended for the data source.</para>
        /// <list type="bullet">
        /// <item><description>true: Suspended.</description></item>
        /// <item><description>false: Not suspended.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>, <b>File</b>, <b>NAS</b>, <b>COMMON_NAS</b>, or <b>COMMON_FILE_SYSTEM</b>. Specifies the file types to back up. All files of these types are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>, <b>File</b>, <b>NAS</b>, <b>COMMON_NAS</b>, or <b>COMMON_FILE_SYSTEM</b>. Specifies the file types to back up. All files of these types are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>The description of the policy binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000<b><b><b><b><b><b>5xx-i-2ze</b></b></b></b></b></b>nw4</para>
        /// </summary>
        [NameInMap("PolicyBindingDescription")]
        [Validation(Required=false)]
        public string PolicyBindingDescription { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************ky9</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The meaning varies depending on the SourceType value:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: The prefix to back up. If not specified, the entire root directory of the bucket is backed up. Only a single prefix is supported. To back up /backup, set this parameter to /backup.</description></item>
        /// <item><description><b>ECS_FILE</b>: The file directories to back up. If not specified, all directories are backed up. Multiple directories are supported. To back up files in /a and /b, set this parameter to [&quot;/a&quot;, &quot;/b&quot;].</description></item>
        /// <item><description><b>File</b>: The file directories to back up. If not specified, all directories are backed up. Multiple directories are supported. To back up files in /a and /b, set this parameter to [&quot;/a&quot;, &quot;/b&quot;].</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: Required. The source paths to back up. Multiple paths are supported. To back up /a and /b, set this parameter to [&quot;/a&quot;, &quot;/b&quot;]. To back up the root path, set this parameter to [&quot;/&quot;].</description></item>
        /// <item><description><b>COMMON_NAS</b>: Required. The source path to back up. Only a single path is supported. To back up /a, set this parameter to [&quot;/a&quot;]. To back up the root path, set this parameter to [&quot;/&quot;].</description></item>
        /// <item><description><b>OTS</b>: The list of data tables to back up. If not specified, all data tables are backed up. Multiple data tables are supported. To back up data tables a and b, set this parameter to [&quot;a&quot;, &quot;b&quot;].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>backup/</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: ECS instance backup.</description></item>
        /// <item><description><b>OSS</b>: OSS backup.</description></item>
        /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
        /// <item><description><b>COMMON_NAS</b>: On-premises NAS backup.</description></item>
        /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition.</description></item>
        /// <item><description><b>File</b>: On-premises file backup.</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup.</description></item>
        /// <item><description><b>OTS</b>: Tablestore backup.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDM_ECS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b> or <b>File</b>. Specifies the backup traffic control. The format is <c>{start}{end}{bandwidth}</c>. Multiple traffic control configurations are separated by delimiters, and the time ranges cannot overlap.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: The start hour.</description></item>
        /// <item><description><b>end</b>: The end hour.</description></item>
        /// <item><description><b>bandwidth</b>: The rate limit, in KB/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

    }

}
