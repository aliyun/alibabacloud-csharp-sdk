// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandRequest : TeaModel {
        /// <summary>
        /// <para>The commands to run in the container. You can specify up to 20 commands. Each command can be up to 256 characters in length.\
        /// The strings must be in the JSON format. Example: <c>[&quot;/bin/sh&quot;, &quot;-c&quot;, &quot;ls -a&quot;]</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/bin/sh&quot;, &quot;-c&quot;, &quot;ls -a&quot;]</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The ID of the elastic container instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-2zebxkiifulhl****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
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
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>Specifies whether to read the commands from standard input (stdin). Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stdin")]
        [Validation(Required=false)]
        public bool? Stdin { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run the command and synchronously return the result. Default value: false.\
        /// If this parameter is set to true, TTY must be set to false. Command cannot be set to <c>/bin/bash</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable interaction. Default value: false.\
        /// If the Command parameter is set to <c>/bin/bash</c>, set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TTY")]
        [Validation(Required=false)]
        public bool? TTY { get; set; }

    }

}
