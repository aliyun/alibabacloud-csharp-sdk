// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container. This parameter is used as a filter condition to query nodes in a specified container. If you do not specify this parameter, leave it empty. This parameter is independent of the ResourceGroupId parameter.</para>
        /// <remarks>
        /// <para>Notice: Before SDK version 8.0.0, this field is of the Long type. In SDK version 8.0.0 and later, this field is of the String type. <b>This change does not affect the normal use of the SDK, and the parameter is still returned based on the type defined in the SDK</b>. However, if you upgrade the SDK across version 8.0.0, the type change may cause project compilation failures. In this case, you must manually correct the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The name of the node. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the requested data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scheduling type. This parameter is used as a filter condition. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Normal: The node runs as expected.</para>
        /// </description></item>
        /// <item><description><para>Pause: The node is paused, and the execution of its downstream nodes is blocked.</para>
        /// </description></item>
        /// <item><description><para>Skip: The node is set to dry run. The system directly returns a success response with an execution duration of 0 seconds. This does not block the execution of downstream nodes or consume resources.</para>
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
        /// <para>The rerun mode. If you do not specify this parameter, leave it empty. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Allowed: The node can be rerun regardless of whether it is successfully run or fails to run.</para>
        /// </description></item>
        /// <item><description><para>FailureAllowed: The node can be rerun only after it fails to run.</para>
        /// </description></item>
        /// <item><description><para>Denied: The node cannot be rerun regardless of whether it is successfully run or fails to run.</para>
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
        /// <para>The scenario to which the node belongs. This parameter is used as a filter condition. If you do not specify this parameter, leave it empty. In Data Studio, this parameter corresponds to the partitions in the left-side directory tree. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>DataworksProject: project directory.</para>
        /// </description></item>
        /// <item><description><para>DataworksManualWorkflow: manual workflow. </para>
        /// </description></item>
        /// <item><description><para>DataworksManualTask: manual task.</para>
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
