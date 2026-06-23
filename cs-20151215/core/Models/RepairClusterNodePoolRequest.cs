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
        /// <para>[This field is deprecated] Specifies whether to allow instance restart.</para>
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
        /// <para>The repair operations to perform. If not specified, all repair operations are performed by default. In most scenarios, you do not need to specify this parameter.</para>
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
            /// <item><description>restart.kubelet: restart kubelet.</description></item>
            /// <item><description>restart.docker: restart Docker.</description></item>
            /// <item><description>restart.containerd: restart Containerd.</description></item>
            /// <item><description>restart.ntp: restart ntpd or chronyd.</description></item>
            /// <item><description>remove.containerdContainerInSandbox: delete a specified sandbox container under Containerd.</description></item>
            /// <item><description>remove.dockerContainerInSandbox: delete a specified sandbox container under Docker.</description></item>
            /// <item><description>remove.containerdContainer: delete a specified container under Containerd.</description></item>
            /// <item><description>remove.dockerContainer: delete a specified container under Docker.</description></item>
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
