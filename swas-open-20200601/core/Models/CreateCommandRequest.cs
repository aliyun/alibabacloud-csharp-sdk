// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateCommandRequest : TeaModel {
        /// <summary>
        /// The command content. When you specify this parameter, take note of the following items:
        /// 
        /// *   When `EnableParameter` is set to true, the custom parameter feature is enabled, and you can configure custom parameters in the command based on the following rules:
        /// *   Define custom parameters in the {{}} format. Within `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        /// *   You can specify up to 20 custom parameters.
        /// *   The name of a custom parameter can contain only letters, digits, underscores (_), and hyphens (-). The name is case-insensitive.
        /// *   The name of a custom parameter cannot exceed 64 bytes in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags that you want to add to the command. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommandRequestTag> Tag { get; set; }
        public class CreateCommandRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N that you want to add to the command. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that you want to add to the command. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The timeout period for the command execution on the instance.
        /// 
        /// If a command execution task times out, Command Assistant forcefully terminates the task process. Valid values: 10 to 86400. Unit: seconds. The period of 86400 seconds is equal to 24 hours.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The language type of the command. Valid values:
        /// 
        /// *   RunBatScript: batch command, applicable to Windows instances
        /// *   RunPowerShellScript: PowerShell command, applicable to Windows instances
        /// *   RunShellScript: shell command, applicable to Linux instances
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The working directory of the command on the ECS instance.
        /// 
        /// Default values:
        /// 
        /// *   For a Linux instance, the default value is the home directory of the root user, which is the `/root` directory.
        /// *   For a Windows instance, the default value is the directory where the Cloud Assistant client process resides. Example: `C:\\Windows\\System32`.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
