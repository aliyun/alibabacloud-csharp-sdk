// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// <para>The command content. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>When <c>EnableParameter</c> is set to true, the custom parameter feature is enabled, and you can configure custom parameters in the command based on the following rules:</description></item>
        /// <item><description>Define custom parameters in the {{}} format. Within <c>{{}}</c>, the spaces and line feeds before and after the parameter names are ignored.</description></item>
        /// <item><description>You can specify up to 20 custom parameters.</description></item>
        /// <item><description>The name of a custom parameter can contain only letters, digits, underscores (_), and hyphens (-). The name is case-insensitive.</description></item>
        /// <item><description>The name of a custom parameter cannot exceed 64 bytes in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ifconfig -s</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The description of the command. The description supports all character sets and can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use custom parameters in the command.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The name of the command. The name supports all character sets and can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bti7cf7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the command. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommandRequestTag> Tag { get; set; }
        public class CreateCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N that you want to add to the command. Valid values of N: 1 to 20.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that you want to add to the command. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout period for the command execution on the instance.</para>
        /// <para>If a command execution task times out, Command Assistant forcefully terminates the task process. Valid values: 10 to 86400. Unit: seconds. The period of 86400 seconds is equal to 24 hours.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The language type of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: batch command, applicable to Windows instances</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command, applicable to Windows instances</description></item>
        /// <item><description>RunShellScript: shell command, applicable to Linux instances</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The working directory of the command on the ECS instance.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>For a Linux instance, the default value is the home directory of the root user, which is the <c>/root</c> directory.</description></item>
        /// <item><description>For a Windows instance, the default value is the directory where the Cloud Assistant client process resides. Example: <c>C:\\Windows\\System32</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/root/</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
