// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// The Base64-encoded content of the command.
        /// 
        /// *   The parameter value must be Base64-encoded and cannot exceed 18 KB in size.
        /// 
        /// *   Custom parameters can be added to the command. To enable the custom parameter feature, you must set `EnableParameter` to true.
        /// 
        ///     *   Custom parameters are defined in the `{{}}` format. Within `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        ///     *   The number of custom parameters cannot exceed 20.
        ///     *   A custom parameter name can contain only letters, digits, underscores (\_), and hyphens (-). The name is case-insensitive.
        ///     *   Each custom parameter name cannot exceed 64 bytes in length.
        /// 
        /// *   You can specify built-in environment parameters as custom parameters. Then, when you run the command, these parameters are automatically specified by Cloud Assistant. You can specify the following built-in environment parameters:
        /// 
        ///     *   `{{ACS::RegionId}}`: the region ID.
        /// 
        ///     *   `{{ACS::AccountId}}`: the instance ID.
        /// 
        ///     *   `{{ACS::InstanceId}}`: the ID of the instance. When the command is run on multiple instances, if you want to specify `{{ACS::InstanceId}}` as a built-in environment variable, make sure that the version of the Cloud Assistant client is not earlier than the following ones:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::InstanceName}}`: the instance name. If you want to run the command on multiple instances and specify `{{ACS::InstanceName}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following ones:
        /// 
        ///         *   Linux: 2.2.3.344
        ///         *   Windows: 2.1.3.344
        /// 
        ///     *   `{{ACS::InvokeId}}`: the task ID. If you want to specify `{{ACS::InvokeId}}` as a built-in environment variable, make sure that the version of the Cloud Assistant client is not earlier than the following one:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// 
        ///     *   `{{ACS::CommandId}}`: the ID of the command. When you call the [RunCommand](~~141751~~) operation, if you want to specify `{{ACS::CommandId}}` as a built-in environment parameter, make sure that the version of the Cloud Assistant client is not earlier than the following ones:
        /// 
        ///         *   Linux: 2.2.3.309
        ///         *   Windows: 2.1.3.309
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// The encoding mode of the command content (CommandContent). Valid values:
        /// 
        /// *   PlainText: The command content is not encoded.
        /// *   Base64: The command content is Base64-encoded.
        /// 
        /// Default value: Base64.
        /// 
        /// > If the specified value of this parameter is invalid, Base64 is used by default.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The description of the command. The description supports all character sets and can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to use custom parameters in the command.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("EnableParameter")]
        [Validation(Required=false)]
        public bool? EnableParameter { get; set; }

        /// <summary>
        /// The name of the command. The name supports all character sets and can be up to 128 characters in length.
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
        /// The ID of the region in which to create the command. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the command.
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
        /// The tags to add to the command.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommandRequestTag> Tag { get; set; }
        public class CreateCommandRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Valid values of N: 1 to 20. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// It can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// he maximum timeout period for the command execution on the instance. Unit: seconds. When a command that you created cannot be run, the command times out. When a command execution times out, Cloud Assistant Agent forcefully terminates the command process by canceling the PID. 
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The command type. Valid values:
        /// 
        /// *   RunBatScript: batch commands. These commands are applicable to Windows instances.
        /// *   RunPowerShellScript: PowerShell commands. These commands are applicable to Windows instances.
        /// *   RunShellScript: shell commands. These commands are applicable to Linux instances.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The working directory of the command on the instance.
        /// 
        /// Default value:
        /// 
        /// *   For Linux instances, the default value is the home directory of the root user, which is the `/root` directory.
        /// *   For Windows instances, the default value is the directory where the Cloud Assistant client process resides. Example: `C:\Windows\System32\`.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
