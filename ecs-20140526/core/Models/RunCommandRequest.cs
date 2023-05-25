// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunCommandRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to retain the command after it is run. Valid values:
        /// 
        /// *   true: The command is retained. You can call the InvokeCommand operation to run the command again. The retained command counts against the quota of Cloud Assistant commands.
        /// *   false: The command is not retained. The command is automatically deleted after it is run and does not count against the quota of Cloud Assistant commands.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// The value of tag N of the command. You can specify 1 to 20 tag keys for the command. The tag value can be an empty string.
        /// 
        /// It can be up to 128 characters in length and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Runs a shell, PowerShell, or batch command on one or more Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Specifies whether to run the command on a schedule. Valid values:
        /// 
        /// *   true: runs the command on the schedule specified by `Frequency`. The results of each execution of a command do not affect the subsequent executions of the command.
        /// *   false: runs the command only once.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The content of the command. The command content can be plaintext or Base64-encoded. Take note of the following items:
        /// 
        /// *   If you want to retain the command, make sure that the Base64-encoded command content does not exceed 18 KB in size. If you do not want to retain the command, make sure that the Base64-encoded command content does not exceed 24 KB in size. You can set `KeepCommand` to specify whether to retain the command.
        /// 
        /// *   If the command content is Base64-encoded, set `ContentEncoding` to Base64.
        /// 
        /// *   When `EnableParameter` is set to true, the custom parameter feature is enabled and you can configure custom parameters based on the following rules:
        /// 
        ///     *   Define custom parameters in the `{{}}` format. Within `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        ///     *   The number of custom parameters cannot exceed 20.
        ///     *   A custom parameter name can contain only letters, digits, underscores (\_), and hyphens (-). The name is case-insensitive.
        ///     *   Each custom parameter name cannot exceed 64 bytes in length.
        /// 
        /// *   You can specify built-in environment parameters as custom parameters. Then, when you run the command, the parameters are automatically specified by Cloud Assistant. You can specify the following built-in environment parameters:
        /// 
        ///     *   `{{ACS::RegionId}}`: the ID of the region.
        /// 
        ///     *   `{{ACS::AccountId}}`: the UID of the Alibaba Cloud account.
        /// 
        ///     *   `{{ACS::InstanceId}}`: the ID of the instance. If you want to run the command on multiple instances and specify `{{ACS::InstanceId}}` as a built-in environment parameter, make sure that your Cloud Assistant is of the following versions or later:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::InstanceName}}`: the name of the instance. If you want to run the command on multiple instances and specify `{{ACS::InstanceName}}` as a built-in environment parameter, make sure that your Cloud Assistant is of the following versions or later:
        /// 
        ///         *   Linux: 2.2.3.344
        ///         *   Windows: 2.1.3.344
        /// 
        ///     *   `{{ACS::InvokeId}}`: the ID of the command task. If you want to specify `{{ACS::InvokeId}}` as a built-in environment variable, make sure that your Cloud Assistant is of the following versions or later:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::CommandId}}`: the ID of the command. If you want to specify `{{ACS::CommandId}}` as a built-in environment parameter, make sure that your Cloud Assistant is of the following versions or later:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the command executions. When you set this parameter, take note of the following items:
        /// 
        /// *   The instances specified by the InstanceId.N parameter must belong to the specified resource group.
        /// *   You can set this parameter to call the [DescribeInvocations](~~64840~~) or [DescribeInvocationResults](~~64845~~) operation to query execution results in the specified resource group.
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// The name of the command. The name supports all character sets and can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The name of the password to use to run the command on Windows instances.
        /// 
        /// If you do not want to use the default System user to run the command on Windows instances, you must specify both the WindowsPasswordName and `Username` parameters. The password is hosted in the parameter repository of Operation Orchestration Service (OOS) by using an encryption parameter to mitigate the risk of password leaks. Only the name of the encryption parameter that corresponds to the password is passed in by using the WindowsPasswordName parameter. For more information, see [Encrypt parameters](~~186828~~) and [Configure a regular user to run Cloud Assistant commands](~~203771~~).
        /// 
        /// >  If you use the root username for Linux instances or the System username for Windows instances to run the command, you do not need to specify the WindowsPasswordName parameter.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The ID of instance N on which to run the command. Valid values of N: 1 to 50.
        /// 
        /// If one of the specified instances does not meet the conditions for running the command, the call fails. To ensure that the call is successful, specify only the IDs of instances that meet the conditions.
        /// </summary>
        [NameInMap("KeepCommand")]
        [Validation(Required=false)]
        public bool? KeepCommand { get; set; }

        /// <summary>
        /// The ID of the command.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The working directory of the command on the instance.
        /// 
        /// Default values:
        /// 
        /// *   For Linux instances, the default value is `/root`, which is the home directory of the administrator (the root user).
        /// *   For Windows instances, the default value is the directory where the Cloud Assistant client process resides. Example: `C:\Windows\System32`.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// The language type of the command. Valid values:
        /// 
        /// *   RunBatScript: batch command, applicable to Windows instances
        /// *   RunPowerShellScript: PowerShell command, applicable to Windows instances
        /// *   RunShellScript: shell command, applicable to Linux instances
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// root
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// The tags to add to the command.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The description of the command. The description supports all character sets and can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunCommandRequestTag> Tag { get; set; }
        public class RunCommandRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the command. You can specify 1 to 20 tag keys for the command. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have the specified tag are displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all specified tags are displayed in the response. To query more than 1,000 resources that have the specified tags, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tags to add to the command.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The key-value pairs of custom parameters to pass in when the command includes custom parameters. For example, assume that the command content is `echo {{name}}`. You can use the `Parameter` parameter to pass in the `{"name":"Jack"}` key-value pair. The `name` key of the custom parameter is automatically replaced by the paired Jack value to generate a new command. As a result, the `echo Jack` command is actually run.
        /// 
        /// Number of custom parameters: 0 to 10. Take note of the following items:
        /// 
        /// *   The key cannot be an empty string. It can be up to 64 characters in length.
        /// *   The value can be an empty string.
        /// *   If you want to retain the command, make sure that the size of the Base64-encoded command content (including custom parameters and original command content) does not exceed 18 KB. If you do not want to retain the command, make sure that the size of the Base64-encoded command content does not exceed 24 KB. You can set `KeepCommand` to specify whether to retain the command.
        /// *   The custom parameter names specified in the value of Parameters must all be included in the custom parameter names specified when you created the command. You can use empty strings to represent the parameters that are not passed in.
        /// 
        /// This parameter is empty by default. You can leave this parameter empty to disable the custom parameter feature.
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        /// <summary>
        /// The timeout period for the command execution. Unit: seconds.
        /// 
        /// A timeout occurs when a command cannot be completed because the process gets stuck, the modules are missing, or the Cloud Assistant client is not installed on the instance. When an execution times out, the command process is forcefully terminated.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The region ID of the command. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies whether to enable the the custom parameter feature.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The ID of instance N on which to run the command. Valid values of N: 1 to 50.
        /// 
        /// If one of the specified instances does not meet the conditions for running the command, the call fails. To ensure that the call is successful, specify only the IDs of instances that meet the conditions.
        /// </summary>
        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

        /// <summary>
        /// The ID of the command task.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
