// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// The content of the command. Take note of the following items:
        /// 
        /// *   When `EnableParameter` is set to true, the custom parameter feature is enabled and you can configure custom parameters based on the following rules:
        /// *   Define custom parameters in the {{}} format. Within `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        /// *   The number of custom parameters cannot be greater than 20.
        /// *   A custom parameter name can contain only letters, digits, underscores (\_), and hyphens (-). The name is case-insensitive.
        /// *   Each custom parameter name cannot exceed 64 bytes in length.
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// Specifies whether to include custom parameters in the command.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the command.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The custom parameters in the key-value pair format that are to be passed in when the command includes custom parameters. For example, if the command content is `echo {{name}}`, you can set the `Parameters` parameter to the `{"name":"Jack"}` key-value pair. The `name` key of the custom parameter is automatically replaced with the paired Jack value to generate a new command. As a result, the `echo Jack` command is actually run.
        /// 
        /// Number of custom parameters ranges from 0 to 20. Take note of the following items:
        /// 
        /// *   The key cannot be an empty string and can be up to 64 characters in length.
        /// *   The value can be an empty string.
        /// *   After custom parameters and original command content are encoded in Base64, the command cannot exceed 16 KB in size.
        /// *   The value of Parameters must be included in the custom parameters specified when you created the command. You can use empty strings to represent the parameters that are not passed in.
        /// 
        /// This parameter is empty by default. You can leave this parameter empty to disable the custom parameter feature.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// The region ID of the simple application server. You can call the [ListRegions](~~189315~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the timeout period of the command on the server.
        /// 
        /// If a task that runs the command times out, Command Assistant forcefully terminates the task process. Valid values: 10 to 86400. Unit: seconds. The period of 86400 seconds is equal to 24 hours.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The language type of the command. Valid values:
        /// 
        /// *   RunBatScript: batch commands (applicable to Windows servers).
        /// *   RunPowerShellScript: PowerShell commands (applicable to Windows servers).
        /// *   RunShellScript: shell commands (applicable to Linux servers).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The name of the password to be used to run the command on a Windows server.
        /// 
        /// If you want to use a username other than the default "system" username to run the command on a Windows server, you must specify both the WindowsPasswordName and WorkingUser parameters. The password is hosted in plaintext in the parameter repository of Operation Orchestration Service (OOS) to reduce the risk of password leaks. Only the name of the password is passed in by using the WindowsPasswordName parameter.
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// The execution path of the command. You can specify a value for the parameter. Default execution paths vary based on the operating systems of the servers.
        /// 
        /// *   For Linux servers, the default execution path is the /home directory of the root user.
        /// *   For Windows servers, the default execution path is C:\Windows\system32.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// A user of the server who runs the command. We recommend that you run the command as a regular user to reduce security risks.
        /// 
        /// Default value:
        /// 
        /// *   For Linux servers, the default value is root.
        /// *   For Windows servers, the default value is system.
        /// </summary>
        [NameInMap("WorkingUser")]
        [Validation(Required=false)]
        public string WorkingUser { get; set; }

    }

}
