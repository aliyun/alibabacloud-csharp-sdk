// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InvokeShellCommandRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The content of the command. The content must be 2 to 2,048 characters in length.
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// The information of nodes on which the command is run.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<InvokeShellCommandRequestInstance> Instance { get; set; }
        public class InvokeShellCommandRequestInstance : TeaModel {
            /// <summary>
            /// The ID of the Nth node instance on which the command is run.
            /// 
            /// > This parameter specifies the node on which the command is run. If it is not specified, the command will be run on all nodes of the cluster.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// The timeout period. If a command times out, the command process will be terminated. Unit: seconds.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The working directory of the command. Default value: `/root`.
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
