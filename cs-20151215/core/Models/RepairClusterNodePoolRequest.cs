// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RepairClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to restart the instance of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The list of nodes. If you do not specify nodes, all nodes in the node pool are selected.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The repair operation to be performed. If not specified, all repair operations will be executed by default. Generally, there is no need to specify this in most scenarios.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<RepairClusterNodePoolRequestOperations> Operations { get; set; }
        public class RepairClusterNodePoolRequestOperations : TeaModel {
            /// <summary>
            /// <para>List of repair operation parameters.</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>Repair operation ID.</para>
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
