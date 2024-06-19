// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandRequest : TeaModel {
        /// <summary>
        /// The commands to run in the container. You can specify up to 20 commands. Each command can be up to 256 characters in length.\\
        /// The strings must be in the JSON format. Example: `["/bin/sh", "-c", "ls -a"]`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// The ID of the elastic container instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The name of the container.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
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
        /// Specifies whether to read the commands from standard input (stdin). Default value: true.
        /// </summary>
        [NameInMap("Stdin")]
        [Validation(Required=false)]
        public bool? Stdin { get; set; }

        /// <summary>
        /// Specifies whether to immediately run the command and synchronously return the result. Default value: false.\\
        /// If this parameter is set to true, TTY must be set to false. Command cannot be set to `/bin/bash`.
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// Specifies whether to enable interaction. Default value: false.\\
        /// If the Command parameter is set to `/bin/bash`, set this parameter to true.
        /// </summary>
        [NameInMap("TTY")]
        [Validation(Required=false)]
        public bool? TTY { get; set; }

    }

}
