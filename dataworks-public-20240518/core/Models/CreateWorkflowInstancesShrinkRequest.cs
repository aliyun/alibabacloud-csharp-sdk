// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to run the instance immediately after it is created. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStartEnabled")]
        [Validation(Required=false)]
        public bool? AutoStartEnabled { get; set; }

        /// <summary>
        /// <para>The reason for creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create for test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The runtime configurations.</para>
        /// </summary>
        [NameInMap("DefaultRunProperties")]
        [Validation(Required=false)]
        public string DefaultRunPropertiesShrink { get; set; }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production.</description></item>
        /// <item><description>Dev: development.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The data backfill period settings.</para>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public string PeriodsShrink { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tag creation policy.</para>
        /// <list type="bullet">
        /// <item><description>Append: Append mode. Inherits existing tags from the manual business process and appends new tags.</description></item>
        /// <item><description>Overwrite: Overwrite mode. Does not inherit existing tags from the manual business process and directly creates tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Append</para>
        /// </summary>
        [NameInMap("TagCreationPolicy")]
        [Validation(Required=false)]
        public string TagCreationPolicy { get; set; }

        /// <summary>
        /// <para>The list of task tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The task parameters. You can use this parameter to set parameters for specific tasks. The value is in JSON format. The key is the task ID. For the format of the value, refer to the task script parameters (Task.Script.Parameter in the response of the GetTask operation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;1001&quot;: &quot;key1=val2 key2=val2&quot;, 
        ///   &quot;1002&quot;: &quot;key1=val2 key2=val2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParameters")]
        [Validation(Required=false)]
        public string TaskParameters { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SupplementData: data backfill. The methods for specifying RootTaskIds and IncludeTaskIds vary based on the data backfill pattern. For more information, see the parameter description of DefaultRunProperties.Mode.</description></item>
        /// <item><description>ManualWorkflow: manual workflow. You must set WorkflowId to the ID of the manual workflow. RootTaskIds is optional. If you do not specify RootTaskIds, the default root node list of the manual workflow is used.</description></item>
        /// <item><description>Manual: manual task. You only need to specify RootTaskIds, which is the list of manual tasks to be run.</description></item>
        /// <item><description>SmokeTest: smoke test. You only need to specify RootTaskIds, which is the list of test tasks to be run.</description></item>
        /// <item><description>TriggerWorkflow: trigger-based workflow. You must set WorkflowId to the ID of the trigger-based workflow. IncludeTaskIds is optional. If you do not specify IncludeTaskIds, the entire workflow is run.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SupplementData</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the task belongs. The WorkflowId of a periodic task is always 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The workflow parameters. This parameter takes effect only when a specific workflow is specified (WorkflowId != 1). For a periodic workflow or a trigger-based workflow, the format is key=value, and the priority is lower than that of task parameters. For a manual workflow, the format is JSON, and the priority is higher than that of task parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;key=value&quot; format:
        /// key1=value1 key2=value2
        /// JSON format:
        /// {&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("WorkflowParameters")]
        [Validation(Required=false)]
        public string WorkflowParameters { get; set; }

    }

}
