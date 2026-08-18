// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of a container in which you want to create the node. The container can be a workflow or a container node. Specify this parameter when you need to create the node inside a container.</para>
        /// <remarks>
        /// <para>Notice: If this parameter is specified, the path field defined in FlowSpec becomes invalid.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: This field was of the Long type in SDK versions earlier than 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect normal SDK usage, and the parameter is still returned in the type defined in the SDK</b>. Only when you upgrade across SDK version 8.0.0, the type change may cause project compilation failures, and you need to manually correct the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23451286945488XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API call operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scenario in which the node is created. This parameter determines whether the node is created in the manual node area or the data development area. DATAWORKS_MANUAL_WORKFLOW can be used only when ContainerId is specified and the container is a manual workflow.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAWORKS_PROJECT: project directory.</description></item>
        /// <item><description>DATAWORKS_MANUAL_WORKFLOW: manual workflow.</description></item>
        /// <item><description>DATAWORKS_MANUAL_TASK: manual task.</description></item>
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
        /// <para>The FlowSpec information that describes the node. For more information about the specification, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow">FlowSpec</a>.</para>
        /// <remarks>
        /// <para>How to quickly obtain a FlowSpec template?</para>
        /// <list type="bullet">
        /// <item><description>In DataStudio, open a node, click Versions on the right side, view the latest version, and then view the scheduling configuration. This provides the FlowSpec description for the current node. You can use the FlowSpec description in the version to quickly build a template that meets your requirements.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>How to specify the node content?</para>
        /// <list type="bullet">
        /// <item><description>Specify the node content in the $.spec.nodes[*].script.content field.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>How to configure the content of a batch synchronization node?</para>
        /// <list type="bullet">
        /// <item><description>Write a script by following Step 4 in <a href="https://www.alibabacloud.com/help/en/dataworks/user-guide/configure-a-batch-synchronization-node-by-using-the-code-editor">Configure a batch synchronization node by using the code editor</a>, and specify the content in the $.spec.nodes[*].script.content field. Alternatively, create a batch synchronization node on the page and obtain the script content by viewing the version.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;version&quot;: &quot;1.1.0&quot;,
        ///     &quot;kind&quot;: &quot;Node&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;nodes&quot;: [
        ///             {
        ///                 &quot;recurrence&quot;: &quot;Normal&quot;,
        ///                 &quot;timeout&quot;: 0,
        ///                 &quot;instanceMode&quot;: &quot;T+1&quot;,
        ///                 &quot;rerunMode&quot;: &quot;Allowed&quot;,
        ///                 &quot;rerunTimes&quot;: 3,
        ///                 &quot;rerunInterval&quot;: 180000,
        ///                 &quot;datasource&quot;: {
        ///                     &quot;name&quot;: &quot;odps_test&quot;
        ///                 },
        ///                 &quot;script&quot;: {
        ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/odpsSQL_Test&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;ODPS_SQL&quot;
        ///                     },
        ///                     &quot;content&quot;: &quot;select now();&quot;
        ///                 },
        ///                 &quot;trigger&quot;: {
        ///                     &quot;type&quot;: &quot;Scheduler&quot;,
        ///                     &quot;cron&quot;: &quot;00 00 00 * * ?&quot;,
        ///                     &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
        ///                     &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
        ///                     &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
        ///                     &quot;delaySeconds&quot;: 0
        ///                 },
        ///                 &quot;runtimeResource&quot;: {
        ///                     &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;
        ///                 },
        ///                 &quot;name&quot;: &quot;odpsSQL_Test&quot;,
        ///                 &quot;inputs&quot;: {
        ///                     &quot;nodeOutputs&quot;: [
        ///                         {
        ///                             &quot;data&quot;: &quot;project_root&quot;,
        ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;
        ///                         }
        ///                     ]
        ///                 },
        ///                 &quot;outputs&quot;: {
        ///                     &quot;nodeOutputs&quot;: [
        ///                         {
        ///                             &quot;data&quot;: &quot;output_data&quot;,
        ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///                             &quot;refTableName&quot;: &quot;odpsSQL_Test&quot;
        ///                         }
        ///                     ]
        ///                 }
        ///             }
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
