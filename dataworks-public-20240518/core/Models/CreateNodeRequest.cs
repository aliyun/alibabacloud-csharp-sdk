// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The container ID. If you want to create a node in a container, you must configure this parameter to specify the container. The container can be a workflow or a node in a container.</para>
        /// <remarks>
        /// <para> If you configure this parameter, the path field defined in FlowSpec becomes invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a7ef0634-20ec-4a7c-a214-54020f91XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public long? ContainerId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scene of the node. This parameter determines the location (the DataStudio pane or the Manual pane) of the node. You can set this parameter to DATAWORKS_MANUAL_WORKFLOW only if the ContainerId parameter is configured and the container specified by ContainerId is a manually triggered workflow.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAWORKS_PROJECT</description></item>
        /// <item><description>DATAWORKS_MANUAL_WORKFLOW</description></item>
        /// <item><description>DATAWORKS_MANUAL_TASK</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATAWORKS_PROJECT</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The FlowSpec field information about the node. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
