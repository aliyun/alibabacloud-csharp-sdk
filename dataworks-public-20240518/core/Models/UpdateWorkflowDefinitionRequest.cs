// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateWorkflowDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>652567824470354XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The FlowSpec field information about the workflow. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;kind&quot;: &quot;CycleWorkflow&quot;,
        ///     &quot;version&quot;: &quot;1.1.0&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;name&quot;: &quot;OpenAPI Test Workflow Demo&quot;,
        ///         &quot;type&quot;: &quot;CycleWorkflow&quot;,
        ///         &quot;id&quot;: &quot;652567824470354XXXX&quot;,
        ///         &quot;workflows&quot;: [
        ///             {
        ///                 &quot;id&quot;: &quot;652567824470354XXXX&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/Workflow_Test/OpenAPI_Test_Workflow_Demo&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;WORKFLOW&quot;
        ///                     }
        ///                 },
        ///                 &quot;trigger&quot;: {
        ///                     &quot;type&quot;: &quot;Scheduler&quot;,
        ///                     &quot;cron&quot;: &quot;00 02 00 * * ?&quot;,
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
        ///                 &quot;name&quot;: &quot;OpenAPI Test Workflow Demo&quot;,
        ///                 &quot;inputs&quot;: {},
        ///                 &quot;outputs&quot;: {
        ///                     &quot;nodeOutputs&quot;: [
        ///                         {
        ///                             &quot;data&quot;: &quot;workflow_output&quot;,
        ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;,
        ///                             &quot;refTableName&quot;: &quot;OpenAPI_Test_Workflow_Demo&quot;
        ///                         }
        ///                     ]
        ///                 },
        ///                 &quot;nodes&quot;: [],
        ///                 &quot;dependencies&quot;: []
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
