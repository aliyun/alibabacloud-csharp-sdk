// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the workflow instance.</para>
        /// </summary>
        [NameInMap("WorkflowInstance")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyWorkflowInstance WorkflowInstance { get; set; }
        public class GetWorkflowInstanceResponseBodyWorkflowInstance : TeaModel {
            /// <summary>
            /// <para>The data timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The account ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The environment of the workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Prod</para>
            /// </description></item>
            /// <item><description><para>Dev</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The time when the instance finished running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            /// <summary>
            /// <para>The ID of the workflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The account ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The name of the workflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkInstance1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The account ID of the workflow owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The time when the instance started to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <para>The status of the workflow instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NotRun: The instance is not run.</para>
            /// </description></item>
            /// <item><description><para>Running: The instance is running.</para>
            /// </description></item>
            /// <item><description><para>WaitTime: The instance is waiting for the scheduling time to arrive.</para>
            /// </description></item>
            /// <item><description><para>CheckingCondition: Branch conditions are being checked for the instance.</para>
            /// </description></item>
            /// <item><description><para>WaitResource: The instance is waiting for resources.</para>
            /// </description></item>
            /// <item><description><para>Failure: The instance fails to be run.</para>
            /// </description></item>
            /// <item><description><para>Success: The instance is successfully run.</para>
            /// </description></item>
            /// <item><description><para>Checking: Data quality is being checked for the instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetWorkflowInstanceResponseBodyWorkflowInstanceTags> Tags { get; set; }
            public class GetWorkflowInstanceResponseBodyWorkflowInstanceTags : TeaModel {
                /// <summary>
                /// <para>The key of a tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of a tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the workflow instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: Scheduled execution</para>
            /// </description></item>
            /// <item><description><para>Manual: Manually triggered node</para>
            /// </description></item>
            /// <item><description><para>SmokeTest: Testing</para>
            /// </description></item>
            /// <item><description><para>SupplementData: Data backfill</para>
            /// </description></item>
            /// <item><description><para>ManualWorkflow: Manually triggered workflow</para>
            /// </description></item>
            /// <item><description><para>TriggerWorkflow: Triggered Workflow</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The unified pipeline instance ID. For all pipeline instances triggered under the same data timestamp in a single trigger, this field value is identical.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("UnifiedWorkflowInstanceId")]
            [Validation(Required=false)]
            public long? UnifiedWorkflowInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the workflow to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

            /// <summary>
            /// <para>The workflow parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>周期工作流：
            /// key1=value1 key2=value2
            /// 手动业务流程：
            /// {&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
            /// </summary>
            [NameInMap("WorkflowParameters")]
            [Validation(Required=false)]
            public string WorkflowParameters { get; set; }

            /// <summary>
            /// <para>The task instance ID corresponding to the workflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkflowTaskInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowTaskInstanceId { get; set; }

        }

    }

}
