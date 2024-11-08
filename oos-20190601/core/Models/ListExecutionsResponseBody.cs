// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task executions.</para>
        /// </summary>
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public List<ListExecutionsResponseBodyExecutions> Executions { get; set; }
        public class ListExecutionsResponseBodyExecutions : TeaModel {
            /// <summary>
            /// <para>The type of the execution template. Valid values: Other, TimerTrigger, EventTrigger, and AlarmTrigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Other</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The number of tasks that are counted by execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Failed&quot;: 0,&quot;Success&quot;: 1,&quot;Total&quot;: 2}</para>
            /// </summary>
            [NameInMap("Counters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Counters { get; set; }

            /// <summary>
            /// <para>The time when the execution was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The information about the tasks that are running.</para>
            /// </summary>
            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<ListExecutionsResponseBodyExecutionsCurrentTasks> CurrentTasks { get; set; }
            public class ListExecutionsResponseBodyExecutionsCurrentTasks : TeaModel {
                /// <summary>
                /// <para>The execution template of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs::Template</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// <para>The ID of the task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-exec-44d32b45d2a49899#1</para>
                /// </summary>
                [NameInMap("TaskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>installSLSILogtail</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The description of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test execution.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the execution stops running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The account ID of the user who started the execution of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1309252800</para>
            /// </summary>
            [NameInMap("ExecutedBy")]
            [Validation(Required=false)]
            public string ExecutedBy { get; set; }

            /// <summary>
            /// <para>The unique ID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-44d32b45d2a449e</para>
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution contains child executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }

            /// <summary>
            /// <para>The time when the template was last successfully triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-27T09:29:18Z</para>
            /// </summary>
            [NameInMap("LastSuccessfulTriggerTime")]
            [Validation(Required=false)]
            public string LastSuccessfulTriggerTime { get; set; }

            /// <summary>
            /// <para>The outputs of last trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;InstanceId&quot;: &quot;i-xxx&quot;
            /// }</para>
            /// </summary>
            [NameInMap("LastTriggerOutputs")]
            [Validation(Required=false)]
            public string LastTriggerOutputs { get; set; }

            /// <summary>
            /// <para>The status of the execution after the template was last triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("LastTriggerStatus")]
            [Validation(Required=false)]
            public string LastTriggerStatus { get; set; }

            /// <summary>
            /// <para>The status message of last trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("LastTriggerStatusMessage")]
            [Validation(Required=false)]
            public string LastTriggerStatusMessage { get; set; }

            /// <summary>
            /// <para>The time when the template was last successfully triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-27T09:29:18Z</para>
            /// </summary>
            [NameInMap("LastTriggerTime")]
            [Validation(Required=false)]
            public string LastTriggerTime { get; set; }

            /// <summary>
            /// <para>The execution mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automatic</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The output of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;InstanceId&quot;:&quot;i-xxx&quot; }</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The input parameters of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Status&quot;:&quot;Running&quot; }</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            /// <summary>
            /// <para>The ID of the parent execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-xxx</para>
            /// </summary>
            [NameInMap("ParentExecutionId")]
            [Validation(Required=false)]
            public string ParentExecutionId { get; set; }

            /// <summary>
            /// <para>The role that started the execution of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOSServiceRole</para>
            /// </summary>
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ 			&quot;Success&quot;: 1 		}</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The security check mode. Valid values: Skip, and ConfirmEveryHighRiskAction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Skip</para>
            /// </summary>
            [NameInMap("SafetyCheck")]
            [Validation(Required=false)]
            public string SafetyCheck { get; set; }

            /// <summary>
            /// <para>The time when the execution was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The status of the execution. Valid values: Started, Queued, Running, Waiting, Success, Failed, and Cancelled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The reason for which the status occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The tags of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The target resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{&quot;ResourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Filters&quot;: [{&quot;ResourceIds&quot;: [&quot;i-bp14z07dg3464980x72o&quot;], &quot;RegionId&quot;: &quot;cn-hangzhou&quot;, &quot;Type&quot;: &quot;ResourceIds&quot;}]}&quot;</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public string Targets { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyTemplate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The version number of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The time when the execution was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The Waiting state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("WaitingStatus")]
            [Validation(Required=false)]
            public string WaitingStatus { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A074-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
