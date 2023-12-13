// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandRequest : TeaModel {
        /// <summary>
        /// The commands to run in the container. You can specify up to 20 commands. Each command can be up to 256 characters in length.\
        /// The strings must be in the JSON format. Example: `["/bin/sh", "-c", "ls -a"]`.
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// The ID of the elastic container instance.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The name of the container.
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
        /// Specifies whether to run the command immediately and return the result. Default value: false.\
        /// If you set this parameter to true, set the value of TTY to false.
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// Specifies whether to enable interaction. Default value: false.\
        /// If the command is a /bin/bash command, set the value to true.
        /// </summary>
        [NameInMap("TTY")]
        [Validation(Required=false)]
        public bool? TTY { get; set; }

    }

}
