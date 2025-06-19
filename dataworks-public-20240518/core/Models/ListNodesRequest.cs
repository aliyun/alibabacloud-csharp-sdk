// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The container ID, which is a filter condition. If you do not want to use this condition for filtering, you do not need to configure this parameter. The container ID that you specify is unrelated to the resource group ID indicated by the ResourceGroupId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public long? ContainerId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scheduling type, which is a filter condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: The nodes are scheduled as expected.</description></item>
        /// <item><description>Pause: The nodes are paused, and the running of their descendant nodes is blocked.</description></item>
        /// <item><description>Skip: The nodes are dry run. The system does not actually run the nodes, but directly returns a success response. The running duration of the nodes is 0 seconds. In addition, the nodes do not occupy resources or block the running of their descendant nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The rerun property, which is a filter condition. If you do not want to use this condition for filtering, you do not need to configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Allowed: The nodes can be rerun regardless of whether they are successfully run or fail to run.</description></item>
        /// <item><description>FailureAllowed: The nodes can be rerun only after they fail to run.</description></item>
        /// <item><description>Denied: The nodes cannot be rerun regardless of whether they are successfully run or fail to run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The location of the nodes in the left-side navigation pane of the Data Studio page, which is a filter condition. If you do not want to use this condition for filtering, you do not need to configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DataworksProject</description></item>
        /// <item><description>DataworksManualWorkflow</description></item>
        /// <item><description>DataworksManualTask</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DATAWORKS_PROJECT</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
