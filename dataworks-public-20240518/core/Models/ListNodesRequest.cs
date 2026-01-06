// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>Leave this parameter empty if not specified. Filter condition: within a specified container. Specify the container ID. This parameter is independent of the resource group ID (ResourceGroupId).</para>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The name of the node. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the data to retrieve, used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of the data to retrieve, used for pagination.</para>
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
        /// <para>Leave this parameter empty if not specified. Filter condition: within a specified container. Specify the container ID. This parameter is independent of the resource group ID (ResourceGroupId).</para>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
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
