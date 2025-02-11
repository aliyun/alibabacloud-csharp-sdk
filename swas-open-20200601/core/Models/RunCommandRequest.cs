// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The content of the command. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>EnableParameter</c> to true, the custom parameter feature is enabled in the command content and you can configure custom parameters based on the following rules:</description></item>
        /// <item><description>Define custom parameters in the {{}} format. Within <c>{{}}</c>, the spaces and line feeds before and after the parameter names are ignored.</description></item>
        /// <item><description>The number of custom parameters cannot be greater than 20.</description></item>
        /// <item><description>A custom parameter name can contain only letters, digits, underscores (_), and hyphens (-). The name is case-insensitive.</description></item>
        /// <item><description>Each custom parameter name cannot exceed 64 bytes in length.</description></item>
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
        /// <para>Specifies whether to enable the custom parameter feature.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ace0706b2ac4454d984295a94213****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the command.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom parameters in the key-value pair format that are to be passed in when the command includes custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can use <c>Parameters</c> to pass in the <c>{&quot;name&quot;:&quot;Jack&quot;}</c> key-value pair. The <c>name</c> key of the custom parameter is automatically replaced with the paired Jack value to generate a new command. As a result, the <c>echo Jack</c> command is executed.</para>
        /// <para>Number of custom parameters ranges from 0 to 20. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The key cannot be an empty string. It can be up to 64 characters in length.</description></item>
        /// <item><description>The value can be an empty string.</description></item>
        /// <item><description>After custom parameters and original command content are encoded in Base64, the command cannot exceed 16 KB in size.</description></item>
        /// <item><description>The custom parameter names that are specified by Parameters must be included in the custom parameter names that you specified when you created the command. You can use empty strings to represent the parameters that are not passed in.</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates to disable the custom parameter feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAIdyvdIqaRY****&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application server. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period of the command on the server.</para>
        /// <para>If a command execution task times out, Command Assistant forcibly terminates the task process. Valid values: 10 to 86400. Unit: seconds. The period of 86400 seconds is equal to 24 hours.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The language type of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: batch commands (applicable to Windows servers).</description></item>
        /// <item><description>RunPowerShellScript: PowerShell commands (applicable to Windows servers).</description></item>
        /// <item><description>RunShellScript: shell commands (applicable to Linux servers).</description></item>
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
        /// <para>The name of the password used to run the command on a Windows simple application server.</para>
        /// <para>If you want to use a username other than the default &quot;system&quot; username to run the command on a Windows server, you must specify both the WindowsPasswordName and WorkingUser parameters. The password is hosted in plaintext in the parameter repository of CloudOps Orchestration Service (OOS) to mitigate the risk of password leaks. Only the name of the password is passed in by using WindowsPasswordName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The execution path of the command. Custom paths are supported. Default execution paths vary based on the operating systems of the servers.</para>
        /// <list type="bullet">
        /// <item><description>For Linux servers, the default path is /root of the root user.</description></item>
        /// <item><description>For Windows servers, the default path is C:\Windows\system32.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/home/</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// <para>A user of the server who runs the command. We recommend that you run the command as a regular user to reduce security risks. Default values:</para>
        /// <list type="bullet">
        /// <item><description>For Linux servers, the default value is root.</description></item>
        /// <item><description>For Windows servers, the default value is system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("WorkingUser")]
        [Validation(Required=false)]
        public string WorkingUser { get; set; }

    }

}
