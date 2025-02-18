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
        /// <para>The scene of the node. This parameter determines the location (the DataStudio pane or the Manual pane) of the node. You can set this parameter to DataworksManualWorkflow only if the ContainerId parameter is configured and the container specified by ContainerId is a manually triggered workflow.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DataworksProject</description></item>
        /// <item><description>DataworksManualWorkflow</description></item>
        /// <item><description>DataworksManualTask</description></item>
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
