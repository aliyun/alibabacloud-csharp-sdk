// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specify this parameter if you want to create the node inside a container. This parameter represents the unique identifier of the container, which can be a workflow or a container node.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the path field defined in FlowSpec is ignored.</para>
        /// </remarks>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a7ef0634-20ec-4a7c-a214-54020f91XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

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
        /// <para>Specify this parameter if you want to create the node inside a container. This parameter represents the unique identifier of the container, which can be a workflow or a container node.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the path field defined in FlowSpec is ignored.</para>
        /// </remarks>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATAWORKS_PROJECT</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The FlowSpec information that describes the node. For more information, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow">FlowSpec</a>.</para>
        /// <remarks>
        /// <para> How do I quickly obtain a FlowSpec template?</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Go to Data Studio, open a node, click Version on the right side, find the latest version, and then click Scheduling Settings to obtain the FlowSpec description of the current node. You can use the FlowSpec description in the version to quickly build a template that meets your requirements.</description></item>
        /// </list>
        /// <remarks>
        /// <para> How do I configure the node content?</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Enter the code for the node in the $.spec.nodes[].script.content field.</description></item>
        /// </list>
        /// <remarks>
        /// <para> How do I configure a batch synchronization node?</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Write the script by referring to Step 4 in <a href="https://help.aliyun.com/zh/dataworks/user-guide/configure-a-batch-synchronization-node-by-using-the-code-editor">Configure an offline sync task in the code editor</a>, and then enter the script content in the $.spec.nodes[\*].script.content field. Alternatively, you can create a batch synchronization node in the console and view its version information to obtain the script content.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;version&quot;: &quot;1.1.0&quot;,
        ///   &quot;kind&quot;: &quot;Node&quot;,
        ///   &quot;spec&quot;: {
        ///     &quot;nodes&quot;: [
        ///       {
        ///         &quot;id&quot;: &quot;860438872620113XXXX&quot;,
        ///         &quot;recurrence&quot;: &quot;Normal&quot;,
        ///         &quot;timeout&quot;: 0,
        ///         &quot;instanceMode&quot;: &quot;T+1&quot;,
        ///         &quot;rerunMode&quot;: &quot;Allowed&quot;,
        ///         &quot;rerunTimes&quot;: 3,
        ///         &quot;rerunInterval&quot;: 180000,
        ///         &quot;datasource&quot;: {
        ///           &quot;name&quot;: &quot;ODPS_test&quot;,
        ///           &quot;type&quot;: &quot;ODPS&quot;
        ///         },
        ///         &quot;script&quot;: {
        ///           &quot;path&quot;: &quot;XX/OpenAPI test/odpsSQL test&quot;,
        ///           &quot;runtime&quot;: {
        ///             &quot;command&quot;: &quot;ODPS_SQL&quot;
        ///           },
        ///           &quot;content&quot;: &quot;select now();&quot;
        ///         },
        ///         &quot;trigger&quot;: {
        ///           &quot;type&quot;: &quot;Scheduler&quot;,
        ///           &quot;cron&quot;: &quot;00 00 00 * * ?&quot;,
        ///           &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
        ///           &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
        ///           &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
        ///           &quot;delaySeconds&quot;: 0
        ///         },
        ///         &quot;runtimeResource&quot;: {
        ///           &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;
        ///         },
        ///         &quot;name&quot;: &quot;odpsSQL test&quot;,
        ///         &quot;inputs&quot;: {
        ///           &quot;nodeOutputs&quot;: [
        ///             {
        ///               &quot;data&quot;: &quot;lwttest_standard_root&quot;,
        ///               &quot;artifactType&quot;: &quot;NodeOutput&quot;
        ///             }
        ///           ]
        ///         },
        ///         &quot;outputs&quot;: {
        ///           &quot;nodeOutputs&quot;: [
        ///             {
        ///               &quot;data&quot;: &quot;output_data&quot;,
        ///               &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///               &quot;refTableName&quot;: &quot;odpsSQL test&quot;
        ///             }
        ///           ]
        ///         }
        ///       }
        ///     ],
        ///     &quot;flow&quot;: [
        ///       {
        ///         &quot;nodeId&quot;: &quot;860438872620113XXXX&quot;,
        ///         &quot;depends&quot;: [
        ///           {
        ///             &quot;type&quot;: &quot;Normal&quot;,
        ///             &quot;output&quot;: &quot;project_root&quot;
        ///           }
        ///         ]
        ///       }
        ///     ]
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
