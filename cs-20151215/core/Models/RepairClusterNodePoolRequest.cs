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
        /// <para>Specifies whether to enable automatic instance restart.</para>
        /// <para>**</para>
        /// <para><b>Warning</b> This parameter is deprecated. Any configured values will be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The list of nodes. If not specified, all nodes in the node pool are selected.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The list of repair operations to execute. If not specified, all repair operations are executed. Typically, you do not need to specify this parameter.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<RepairClusterNodePoolRequestOperations> Operations { get; set; }
        public class RepairClusterNodePoolRequestOperations : TeaModel {
            /// <summary>
            /// <para>The parameters of a repair operation.</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The ID of a repair operation.</para>
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
