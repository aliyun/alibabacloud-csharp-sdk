// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class RefreshNodeGroupNodesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum disruptive action level allowed for the refresh operation. The system independently evaluates the action level required to refresh each drifted property of a node and performs the refresh within the specified action level constraint. If the action level required for a property exceeds the specified level, that property is skipped. Action levels in increasing order of disruption: Refresh &lt; Reboot &lt; Reimage.</para>
        /// <list type="bullet">
        /// <item><description>Refresh (default): only refreshes the configuration in place without restarting or reimaging. Currently applicable only to the RamRoleName property.</description></item>
        /// <item><description>Reboot (not currently supported): allows restarting the node for the configuration to take effect. Supported properties include system cloud disk type and all properties supported by Refresh.</description></item>
        /// <item><description>Reimage (not currently supported): allows reimaging the node for the configuration to take effect. Supported properties include image ID and all properties supported by Reboot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Refresh</para>
        /// </summary>
        [NameInMap("MaxDisruptiveAction")]
        [Validation(Required=false)]
        public string MaxDisruptiveAction { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3525</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The filter scope for node refresh. If not specified, all nodes in the node group are included. <warning>If the instance type is a hypernode, pass the TrayNode ID, not the HyperNodeId.</warning></para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

    }

}
