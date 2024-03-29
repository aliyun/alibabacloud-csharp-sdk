// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCommandRequest : TeaModel {
        /// <summary>
        /// The command content. The command content can be plaintext or Base64-encoded. Take note of the following items:
        /// 
        /// *   The Base64-encoded command content can be up to 16 KB in size.
        /// 
        /// *   If the command content is Base64-encoded, set `ContentEncoding` to Base64.
        /// 
        /// *   If you set `EnableParameter` to true, the custom parameter feature is enabled and you can specify custom parameters based on the following rules:
        /// 
        ///     *   Specify custom parameters in the `{{}}` format. When parameter names are enclosed in `{{}}`, the spaces and line feeds before and after the parameter names are ignored.
        ///     *   You can specify up to 20 custom parameters.
        ///     *   A custom parameter name can contain only letters, digits, underscores (\_), and hyphens (-). The name is not case-sensitive.
        ///     *   Each custom parameter name cannot exceed 64 bytes in length.
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// The command ID. You can call the [DescribeCommands](~~64843~~) operation to query all available command IDs.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The command description. The description supports all character sets and can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The command name. The name supports all character sets and can be up to 128 characters in length.
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
        /// The region ID of the command. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The maximum timeout period for the command to be run on the instance. Unit: seconds. When a command cannot run within the specified time range, the command times out. Then, the command process is forcibly terminated by canceling the process ID (PID) of the command.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The working directory of the command.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
