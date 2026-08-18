// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>Leave this parameter empty if not specified. The filter condition: within the specified container. Specify the container ID. This parameter is not related to the resource group (ResourceGroupId).</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The node name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Filter condition: scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: The node is executed normally.</para>
        /// </description></item>
        /// <item><description><para>Pause: The node status is set to paused, and downstream nodes that depend on the current node are blocked from execution.</para>
        /// </description></item>
        /// <item><description><para>Skip: The node status is set to dry run. The system directly returns a success result (with an execution duration of 0 seconds), does not block downstream node execution, and does not consume resources.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The rerun property. If not specified, this parameter is left empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Allowed: The node can be rerun regardless of whether it runs successfully or fails.</para>
        /// </description></item>
        /// <item><description><para>FailureAllowed: The node can be rerun only after a failed run, not after a successful run.</para>
        /// </description></item>
        /// <item><description><para>Denied: The node cannot be rerun regardless of whether it runs successfully or fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The scene in which the node resides. Leave this parameter empty if not specified. This parameter corresponds to the partition of the left-side navigation pane in DataStudio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataworksProject: project folder.</para>
        /// </description></item>
        /// <item><description><para>DataworksManualWorkflow: manual workflow.</para>
        /// </description></item>
        /// <item><description><para>DataworksManualTask: manual node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataworksProject</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
