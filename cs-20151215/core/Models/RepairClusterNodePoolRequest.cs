// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RepairClusterNodePoolRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to restart the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The repair operations to be performed. If you do not specify this parameter, all repair operations are performed by default. You do not need to specify this parameter in common scenarios.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<RepairClusterNodePoolRequestOperations> Operations { get; set; }
        public class RepairClusterNodePoolRequestOperations : TeaModel {
            /// <summary>
            /// <para>The list of repair operation parameters.</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The repair operation ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>restart.kubelet: Restarts kubelet.</description></item>
            /// <item><description>restart.docker: Restarts Docker.</description></item>
            /// <item><description>restart.containerd: Restarts Containerd.</description></item>
            /// <item><description>restart.ntp: Restarts ntpd or chronyd.</description></item>
            /// <item><description>remove.containerdContainerInSandbox: Deletes the specified sandbox container in Containerd.</description></item>
            /// <item><description>remove.dockerContainerInSandbox: Deletes the specified sandbox container in Docker.</description></item>
            /// <item><description>remove.containerdContainer: Deletes the specified container in Containerd.</description></item>
            /// <item><description>remove.dockerContainer: Deletes the specified container in Docker.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>remove.containerdContainer</para>
            /// </summary>
            [NameInMap("operation_id")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

        }

    }

}
