// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetWorkflowDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2BDD628-8A21-5BD1-B930-1A2D5989XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the workflow.</para>
        /// </summary>
        [NameInMap("WorkflowDefinition")]
        [Validation(Required=false)]
        public GetWorkflowDefinitionResponseBodyWorkflowDefinition WorkflowDefinition { get; set; }
        public class GetWorkflowDefinitionResponseBodyWorkflowDefinition : TeaModel {
            /// <summary>
            /// <para>The time when the workflow was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1708481905000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>463497880880954XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time when the workflow was last modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1708481905000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI test workflow Demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110755000425XXXX</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the workflow belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>307XXX</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The FlowSpec field information about the workflow. For more information, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow/">FlowSpec</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;metadata&quot;: {
            ///         &quot;tenantId&quot;: &quot;52425742456XXXX&quot;,
            ///         &quot;projectId&quot;: &quot;307XXXX&quot;,
            ///         &quot;uuid&quot;: &quot;463497880880954XXXX&quot;
            ///     },
            ///     &quot;kind&quot;: &quot;CycleWorkflow&quot;,
            ///     &quot;version&quot;: &quot;1.1.0&quot;,
            ///     &quot;spec&quot;: {
            ///         &quot;name&quot;: &quot;OpenAPI_Test_Workflow_Demo&quot;,
            ///         &quot;id&quot;: &quot;463497880880954XXXX&quot;,
            ///         &quot;type&quot;: &quot;CycleWorkflow&quot;,
            ///         &quot;owner&quot;: &quot;110755000425XXXX&quot;,
            ///         &quot;workflows&quot;: [
            ///             {
            ///                 &quot;script&quot;: {
            ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/Workflow_Test/OpenAPI_Test_Workflow_Demo&quot;,
            ///                     &quot;runtime&quot;: {
            ///                         &quot;command&quot;: &quot;WORKFLOW&quot;
            ///                     },
            ///                     &quot;id&quot;: &quot;698002781368644XXXX&quot;
            ///                 },
            ///                 &quot;id&quot;: &quot;463497880880954XXXX&quot;,
            ///                 &quot;trigger&quot;: {
            ///                     &quot;type&quot;: &quot;Scheduler&quot;,
            ///                     &quot;id&quot;: &quot;652567824470354XXXX&quot;,
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
            ///                 &quot;name&quot;: &quot;OpenAPI_Test_Workflow_Demo&quot;,
            ///                 &quot;owner&quot;: &quot;110755000425XXXX&quot;,
            ///                 &quot;metadata&quot;: {
            ///                     &quot;owner&quot;: &quot;110755000425XXXX&quot;,
            ///                     &quot;ownerName&quot;: &quot;<a href="mailto:XXXX@test.XXXX.com">XXXX@test.XXXX.com</a>&quot;,
            ///                     &quot;tenantId&quot;: &quot;52425742456XXXX&quot;,
            ///                     &quot;project&quot;: {
            ///                         &quot;mode&quot;: &quot;STANDARD&quot;,
            ///                         &quot;projectId&quot;: &quot;307303&quot;,
            ///                         &quot;projectIdentifier&quot;: &quot;lwttest_standard&quot;,
            ///                         &quot;projectName&quot;: &quot;XXXX&quot;,
            ///                         &quot;projectOwnerId&quot;: &quot;110755000425XXXX&quot;,
            ///                         &quot;simple&quot;: false,
            ///                         &quot;tenantId&quot;: &quot;52425742456XXXX&quot;
            ///                     },
            ///                     &quot;projectId&quot;: &quot;307XXXX&quot;
            ///                 },
            ///                 &quot;inputs&quot;: {},
            ///                 &quot;outputs&quot;: {
            ///                     &quot;nodeOutputs&quot;: [
            ///                         {
            ///                             &quot;data&quot;: &quot;463497880880954XXXX&quot;,
            ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;,
            ///                             &quot;refTableName&quot;: &quot;OpenAPI_Test_Workflow_Demo&quot;,
            ///                             &quot;isDefault&quot;: true
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

            /// <summary>
            /// <para>The ID of the workflow on the scheduling side after publishing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>700006657495</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

        }

    }

}
