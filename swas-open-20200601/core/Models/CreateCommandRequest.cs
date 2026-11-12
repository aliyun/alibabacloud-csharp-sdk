// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// <para>The content of the command. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you set the EnableParameter parameter to true, you can use custom parameters in the command content.</description></item>
        /// <item><description>Custom parameters are enclosed in braces ({{}}). Spaces and line breaks before and after the parameter names within the braces are ignored.</description></item>
        /// <item><description>You can specify a maximum of 20 custom parameters.</description></item>
        /// <item><description>A custom parameter name can contain only letters, digits, hyphens (-), and underscores (_). Parameter names are not case-sensitive.</description></item>
        /// <item><description>A custom parameter name cannot exceed 64 bytes in length.</description></item>
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
        /// <para>The description of the command. All characters are supported. The description cannot exceed 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the created command uses custom parameters.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The name of the command. All characters are supported. The name cannot exceed 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to query available regions.</para>
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
        /// <para>The list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommandRequestTag> Tag { get; set; }
        public class CreateCommandRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N that is added to the command. Valid values of N: 1 to 20.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that is added to the command. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 64 characters in length, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout period for running the command on the instance, in seconds.</para>
        /// <para>If the task that runs the command times out, Cloud Assistant forcibly terminates the task process. Valid values: 10 to 86400 (24 hours).</para>
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
        /// <item><description>RunBatScript: bat commands for Windows instances</description></item>
        /// <item><description>RunPowerShellScript: PowerShell commands for Windows instances</description></item>
        /// <item><description>RunShellScript: shell commands for Linux instances</description></item>
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
        /// <para>The directory in which the created command is run on the ECS instance.</para>
        /// <para>Default value: </para>
        /// <list type="bullet">
        /// <item><description>Linux instances: the home directory of the root user, which is /root.  </description></item>
        /// <item><description>Windows instances: the directory where the Cloud Assistant client process is located, such as C:\Windows\System32.</description></item>
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
