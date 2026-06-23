// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container. If you specify this parameter, only nodes in the specified container are returned. This parameter is independent of the resource group (ResourceGroupId).</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is of the Long type in SDK versions earlier than 8.0.0 and of the String type in SDK 8.0.0 and later. <b>This change does not affect SDK usage. The parameter is returned in the type defined for your SDK version.</b> The type change may cause compilation errors only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The node name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. To find this ID, log in to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Filters nodes by their scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: The node runs as scheduled.</para>
        /// </description></item>
        /// <item><description><para>Pause: The node is paused and blocks its dependent downstream nodes.</para>
        /// </description></item>
        /// <item><description><para>Skip: The node is skipped, and the system immediately returns a success status with a 0-second execution time. This action does not block downstream nodes or consume resources.</para>
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
        /// <para>The rerun mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Allowed: The node can be rerun regardless of whether it succeeded or failed.</para>
        /// </description></item>
        /// <item><description><para>FailureAllowed: The node can be rerun only if its previous run failed.</para>
        /// </description></item>
        /// <item><description><para>Denied: The node cannot be rerun regardless of whether it succeeded or failed.</para>
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
        /// <para>The context for filtering nodes. In data development, this corresponds to the sections in the directory tree on the left. If you omit this parameter, no filtering is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataworksProject: Nodes in the project directory.</para>
        /// </description></item>
        /// <item><description><para>DataworksManualWorkflow: manual workflow</para>
        /// </description></item>
        /// <item><description><para>DataworksManualTask: manual task</para>
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
