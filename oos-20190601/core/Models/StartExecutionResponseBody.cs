// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class StartExecutionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the execution.</para>
        /// </summary>
        [NameInMap("Execution")]
        [Validation(Required=false)]
        public StartExecutionResponseBodyExecution Execution { get; set; }
        public class StartExecutionResponseBodyExecution : TeaModel {
            /// <summary>
            /// <para>The number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>The information about in-progress tasks.</para>
            /// </summary>
            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<StartExecutionResponseBodyExecutionCurrentTasks> CurrentTasks { get; set; }
            public class StartExecutionResponseBodyExecutionCurrentTasks : TeaModel {
                /// <summary>
                /// <para>The action of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::TimerTrigger</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// <para>The execution ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exec-dsadasdawq</para>
                /// </summary>
                [NameInMap("TaskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTask</para>
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
            /// <para>The time when the execution stopped.</para>
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
            /// <para>root(13092080xx12344)</para>
            /// </summary>
            [NameInMap("ExecutedBy")]
            [Validation(Required=false)]
            public string ExecutedBy { get; set; }

            /// <summary>
            /// <para>The GUID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-xxxyyy</para>
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution is a parent execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }

            /// <summary>
            /// <para>The loop mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automatic</para>
            /// </summary>
            [NameInMap("LoopMode")]
            [Validation(Required=false)]
            public string LoopMode { get; set; }

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
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The ID of the parent execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-xxxx</para>
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
            /// <para>The security check mode.</para>
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
            /// <para>The status of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status information of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The tags of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;:&quot;v2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-1bd341007f</para>
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
            /// <para>The time when the execution was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
