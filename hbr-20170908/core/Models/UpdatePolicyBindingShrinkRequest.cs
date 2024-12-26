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
        /// <para>The ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1************dtv</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the backup policy for the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables the backup policy for the data source</description></item>
        /// <item><description>false: enables the backup policy for the data source</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the type of files that do not need to be backed up. No files of the specified type are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the type of files to be backed up. All files of the specified type are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;<em>.doc\&quot;,\&quot;</em>.xltm\&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>The description of the association.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000<b><b><b><b><b><b>5xx-i-2ze</b></b></b></b></b></b>nw4</para>
        /// </summary>
        [NameInMap("PolicyBindingDescription")]
        [Validation(Required=false)]
        public string PolicyBindingDescription { get; set; }

        /// <summary>
        /// <para>The ID of the backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************ky9</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the SourceType parameter is set to <b>OSS</b>, set the Source parameter to the prefix of the path to the folder that you want to back up. If you do not specify the Source parameter, the entire bucket (root directory) is backed up.</description></item>
        /// <item><description>If the SourceType parameter is set to <b>ECS_FILE</b> or <b>File</b>, set the Source parameter to the path to the files that you want to back up. If you do not specify the Source parameter, all paths backed up.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>backup/</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: ECS instance backup</description></item>
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
        /// <para>This parameter is required only if you set the <b>SourceType</b> parameter to <b>ECS_FILE</b> or <b>File</b>. This parameter specifies the throttling rules. Format: <c>{start}{end}{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). The time ranges of the throttling rules cannot overlap.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start hour.</description></item>
        /// <item><description><b>end</b>: the end hour.</description></item>
        /// <item><description><b>bandwidth</b>: the bandwidth. Unit: KB/s.</description></item>
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
