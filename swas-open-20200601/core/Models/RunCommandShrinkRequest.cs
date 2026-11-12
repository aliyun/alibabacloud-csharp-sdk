// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class RunCommandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The command content. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Set <c>EnableParameter=true</c> to enable the custom parameter feature in the command content:</description></item>
        /// <item><description>Define custom parameters by enclosing them in <c>{{}}</c>. Spaces and line breaks before and after the parameter name within <c>{{}}</c> are ignored.</description></item>
        /// <item><description>The number of custom parameters cannot exceed 20.</description></item>
        /// <item><description>Custom parameter names can contain only letters (a-z, A-Z), digits (0-9), hyphens (-), and underscores (_). Other characters are not supported. Parameter names are case-insensitive.</description></item>
        /// <item><description>A single custom parameter name cannot exceed 64 bytes.</description></item>
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
        /// <para>Specifies whether the command contains custom parameters.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// <para>The instance ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ace0706b2ac4454d984295a94213****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the command execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The key-value pairs of custom parameters to pass in when the command contains custom parameters. For example, if the command content is <c>echo {{name}}</c>, you can use the <c>Parameters</c> parameter to pass in the key-value pair <c>{&quot;name&quot;:&quot;Jack&quot;}</c>. The custom parameter automatically replaces the variable value <c>name</c>, and the actual command that runs is <c>echo Jack</c>.</para>
        /// <para>The number of custom parameters ranges from 0 to 20. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Keys cannot be empty strings and can contain up to 64 characters.</description></item>
        /// <item><description>Values can be empty strings.</description></item>
        /// <item><description>The set of custom parameter names must be a subset of the parameter set defined when the command was created. For parameters that are not passed in, you can use empty strings as substitutes.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that this parameter is unset to disable custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Jack&quot;, &quot;accessKey&quot;:&quot;LTAI****************&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to query the latest region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period for the command to run on the server instance. Unit: seconds.</para>
        /// <para>When a command execution task times out, Command Assistant forcefully terminates the task process. Valid values: 10 to 86400 (24 hours).</para>
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
        /// <item><description>RunBatScript: Bat commands for Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell commands for Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell commands for Linux instances.</description></item>
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
        /// <para>The password name of the user that runs the command on a Windows instance.</para>
        /// <para>If you want to run a command as a non-default user (System) on a Windows instance, you must specify both WorkingUser and this parameter. To reduce the risk of password leaks, store the plaintext password in the parameter repository of CloudOps Orchestration Service and pass in only the password name here.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// <para>The custom execution path of the command. Default paths:</para>
        /// <list type="bullet">
        /// <item><description>Linux instances: The default execution path is the /root directory of the root user.</description></item>
        /// <item><description>Windows instances: The default execution path is the C:\Windows\system32 directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/root</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// <para>The user that you want to use to run the command on the simple application server instance. We recommend that you use a regular user to run commands to reduce security risks.
        /// Default values:</para>
        /// <list type="bullet">
        /// <item><description><para>root: On Linux instances, commands are run as the root user by default.</para>
        /// </description></item>
        /// <item><description><para>system: On Windows instances, commands are run as the system user by default.</para>
        /// </description></item>
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
