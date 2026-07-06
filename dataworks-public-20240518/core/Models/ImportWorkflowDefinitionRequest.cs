// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ImportWorkflowDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API invoke.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The FlowSpec information that describes the workflow. For the specification details, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow/">FlowSpec</a>.</para>
        /// <remarks>
        /// <para>How do I quickly obtain a FlowSpec template?</para>
        /// <list type="bullet">
        /// <item><description>Open a workflow in DataStudio, and then click <b>Show Spec</b> in the upper-right corner to obtain the FlowSpec description of the current workflow. You can use this FlowSpec description to quickly build a template that meets your requirements.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: This operation supports creating a workflow and its internal nodes at the same time. Pay attention to the IDs specified in the FlowSpec. If an ID already exists, the operation becomes an update. The operation becomes a create only when no ID is specified or the ID does not exist.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;version&quot;: &quot;1.1.0&quot;,
        ///     &quot;kind&quot;: &quot;CycleWorkflow&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;name&quot;: &quot;Asynchronous_Workflow_Creation_Test&quot;,
        ///         &quot;id&quot;: &quot;632647691239009XXXX&quot;,
        ///         &quot;type&quot;: &quot;CycleWorkflow&quot;,
        ///         &quot;workflows&quot;: [
        ///             {
        ///                 &quot;script&quot;: {
        ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/Workflow_Test/Asynchronous_Workflow_Creation_Test&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;WORKFLOW&quot;
        ///                     }
        ///                 },
        ///                 &quot;id&quot;: &quot;632647691239009XXXX&quot;,
        ///                 &quot;trigger&quot;: {
        ///                     &quot;type&quot;: &quot;Scheduler&quot;,
        ///                     &quot;cron&quot;: &quot;00 03 00 * * ?&quot;,
        ///                     &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
        ///                     &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
        ///                     &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
        ///                     &quot;delaySeconds&quot;: 0
        ///                 },
        ///                 &quot;strategy&quot;: {
        ///                     &quot;timeout&quot;: 0,
        ///                     &quot;instanceMode&quot;: &quot;T+1&quot;,
        ///                     &quot;rerunMode&quot;: &quot;Allowed&quot;,
        ///                     &quot;rerunTimes&quot;: 3,
        ///                     &quot;rerunInterval&quot;: 180000,
        ///                     &quot;failureStrategy&quot;: &quot;Break&quot;
        ///                 },
        ///                 &quot;name&quot;: &quot;Asynchronous_Workflow_Creation_Test&quot;,
        ///                 &quot;inputs&quot;: {},
        ///                 &quot;outputs&quot;: {
        ///                     &quot;nodeOutputs&quot;: [
        ///                         {
        ///                             &quot;data&quot;: &quot;632647691239009XXXX&quot;,
        ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///                             &quot;refTableName&quot;: &quot;Asynchronous_Workflow_Creation_Test&quot;
        ///                         }
        ///                     ]
        ///                 },
        ///                 &quot;nodes&quot;: [
        ///                     {
        ///                         &quot;recurrence&quot;: &quot;Normal&quot;,
        ///                         &quot;id&quot;: &quot;742981001612325XXXX&quot;,
        ///                         &quot;timeout&quot;: 0,
        ///                         &quot;instanceMode&quot;: &quot;T+1&quot;,
        ///                         &quot;rerunMode&quot;: &quot;Allowed&quot;,
        ///                         &quot;rerunTimes&quot;: 3,
        ///                         &quot;rerunInterval&quot;: 180000,
        ///                         &quot;script&quot;: {
        ///                             &quot;path&quot;: &quot;XX/OpenAPI_Test/Workflow_Test/Asynchronous_Workflow_Creation_Test/111&quot;,
        ///                             &quot;runtime&quot;: {
        ///                                 &quot;command&quot;: &quot;ODPS_SQL&quot;
        ///                             },
        ///                             &quot;content&quot;: &quot;select now();\n&quot;
        ///                         },
        ///                         &quot;trigger&quot;: {
        ///                             &quot;type&quot;: &quot;Scheduler&quot;,
        ///                             &quot;cron&quot;: &quot;00 24 00 * * ?&quot;,
        ///                             &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
        ///                             &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
        ///                             &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
        ///                             &quot;delaySeconds&quot;: 0
        ///                         },
        ///                         &quot;name&quot;: &quot;111&quot;,
        ///                         &quot;inputs&quot;: {},
        ///                         &quot;outputs&quot;: {
        ///                             &quot;nodeOutputs&quot;: [
        ///                                 {
        ///                                     &quot;data&quot;: &quot;742981001612325XXXX&quot;,
        ///                                     &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///                                     &quot;refTableName&quot;: &quot;111&quot;
        ///                                 }
        ///                             ]
        ///                         }
        ///                     },
        ///                     {
        ///                         &quot;recurrence&quot;: &quot;Normal&quot;,
        ///                         &quot;id&quot;: &quot;595182137303408XXXX&quot;,
        ///                         &quot;timeout&quot;: 0,
        ///                         &quot;instanceMode&quot;: &quot;T+1&quot;,
        ///                         &quot;rerunMode&quot;: &quot;Allowed&quot;,
        ///                         &quot;rerunTimes&quot;: 3,
        ///                         &quot;rerunInterval&quot;: 180000,
        ///                         &quot;script&quot;: {
        ///                             &quot;path&quot;: &quot;XX/OpenAPI_Test/Workflow_Test/Asynchronous_Workflow_Creation_Test/222&quot;,
        ///                             &quot;runtime&quot;: {
        ///                                 &quot;command&quot;: &quot;ODPS_SQL&quot;
        ///                             },
        ///                             &quot;content&quot;: &quot;select now();\n select 1;&quot;
        ///                         },
        ///                         &quot;trigger&quot;: {
        ///                             &quot;type&quot;: &quot;Scheduler&quot;,
        ///                             &quot;cron&quot;: &quot;00 00 00 * * ?&quot;,
        ///                             &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
        ///                             &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
        ///                             &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
        ///                             &quot;delaySeconds&quot;: 0
        ///                         },
        ///                         &quot;name&quot;: &quot;222&quot;,
        ///                         &quot;inputs&quot;: {},
        ///                         &quot;outputs&quot;: {
        ///                             &quot;nodeOutputs&quot;: [
        ///                                 {
        ///                                     &quot;data&quot;: &quot;595182137303408XXXX&quot;,
        ///                                     &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///                                     &quot;refTableName&quot;: &quot;222&quot;<br>                                }
        ///                             ]
        ///                         }
        ///                     }
        ///                 ],
        ///                 &quot;dependencies&quot;: [
        ///                     {
        ///                         &quot;nodeId&quot;: &quot;595182137303408XXXX&quot;,
        ///                         &quot;depends&quot;: [
        ///                             {
        ///                                 &quot;type&quot;: &quot;Normal&quot;,
        ///                                 &quot;output&quot;: &quot;742981001612325XXXX&quot;,
        ///                                 &quot;refTableName&quot;: &quot;111&quot;
        ///                             }
        ///                         ]
        ///                     }
        ///                 ]
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
