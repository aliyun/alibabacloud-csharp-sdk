// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique code of the client. This code uniquely identifies a task. This parameter is used to create a task asynchronously and implement the idempotence of the task. If you do not specify this parameter when you create the task, the system automatically generates a unique code. The unique code is uniquely associated with the task ID. If you specify this parameter when you update or delete the task, the value of this parameter must be the unique code that is used to create the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>The information about the associated data source.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public UpdateTaskRequestDataSource DataSource { get; set; }
        public class UpdateTaskRequestDataSource : TeaModel {
            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<UpdateTaskRequestDependencies> Dependencies { get; set; }
        public class UpdateTaskRequestDependencies : TeaModel {
            /// <summary>
            /// <para>The dependency type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CrossCycleDependsOnChildren: Depends on level-1 downstream nodes across cycles</description></item>
            /// <item><description>CrossCycleDependsOnSelf: Depends on itself across cycles.</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: Depends on other nodes across cycles.</description></item>
            /// <item><description>Normal: Depends on nodes in the same cycle.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The output identifier of the upstream task. (This parameter is returned only if <c>Normal</c> is set and the node input is configured.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The ID of the upstream task. (This parameter is returned only if <c>Normal</c> or <c>CrossCycleDependsOnOtherNode</c> is set and the node input is not configured.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("UpstreamTaskId")]
            [Validation(Required=false)]
            public long? UpstreamTaskId { get; set; }

        }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
        /// <list type="bullet">
        /// <item><description>Prod</description></item>
        /// <item><description>Dev</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The input information.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public UpdateTaskRequestInputs Inputs { get; set; }
        public class UpdateTaskRequestInputs : TeaModel {
            /// <summary>
            /// <para>The variables.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<UpdateTaskRequestInputsVariables> Variables { get; set; }
            public class UpdateTaskRequestInputsVariables : TeaModel {
                /// <summary>
                /// <para>The name of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Constant: constant.</description></item>
                /// <item><description>PassThrough: node output.</description></item>
                /// <item><description>System: variable.</description></item>
                /// <item><description>NodeOutput: script output.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Constant</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance generation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T+1: the next day</description></item>
        /// <item><description>Immediately</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL node</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public UpdateTaskRequestOutputs Outputs { get; set; }
        public class UpdateTaskRequestOutputs : TeaModel {
            /// <summary>
            /// <para>The task outputs.</para>
            /// </summary>
            [NameInMap("TaskOutputs")]
            [Validation(Required=false)]
            public List<UpdateTaskRequestOutputsTaskOutputs> TaskOutputs { get; set; }
            public class UpdateTaskRequestOutputsTaskOutputs : TeaModel {
                /// <summary>
                /// <para>The identifier of the output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

            }

            /// <summary>
            /// <para>The variables.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<UpdateTaskRequestOutputsVariables> Variables { get; set; }
            public class UpdateTaskRequestOutputsVariables : TeaModel {
                /// <summary>
                /// <para>The name of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Constant: constant.</description></item>
                /// <item><description>PassThrough: node output.</description></item>
                /// <item><description>System: variable.</description></item>
                /// <item><description>NodeOutput: script output.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Constant</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The account ID of the task owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The rerun interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RerunInterval")]
        [Validation(Required=false)]
        public int? RerunInterval { get; set; }

        /// <summary>
        /// <para>The rerun mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllDenied: The task cannot be rerun.</description></item>
        /// <item><description>FailureAllowed: The task can be rerun only after it fails.</description></item>
        /// <item><description>AllAllowed: The task can always be rerun.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllAllowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The number of times that the task is rerun. This parameter takes effect only if the RerunMode parameter is set to AllAllowed or FailureAllowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RerunTimes")]
        [Validation(Required=false)]
        public int? RerunTimes { get; set; }

        /// <summary>
        /// <para>Runtime environment configurations, such as resource group information.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public UpdateTaskRequestRuntimeResource RuntimeResource { get; set; }
        public class UpdateTaskRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The default number of compute units (CUs) configured for task running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>The image ID used in the task runtime configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The identifier of the scheduling resource group used in the task runtime configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The run script information.</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public UpdateTaskRequestScript Script { get; set; }
        public class UpdateTaskRequestScript : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo &quot;helloWorld&quot;</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            [Obsolete]
            public string Content { get; set; }

            /// <summary>
            /// <para>The script parameter list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>para1=$bizdate</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

        }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateTaskRequestTags> Tags { get; set; }
        public class UpdateTaskRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of a tag.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>The timeout period of task running. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The triggering method.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateTaskRequestTrigger Trigger { get; set; }
        public class UpdateTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The Cron expression. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The expiration time of periodic triggering. Takes effect only when type is set to Scheduler. The value of this parameter is in the<c>yyyy-mm-dd hh:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the Type parameter is set to Scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pause</description></item>
            /// <item><description>Skip</description></item>
            /// <item><description>Normal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Recurrence")]
            [Validation(Required=false)]
            public string Recurrence { get; set; }

            /// <summary>
            /// <para>The time when periodic triggering takes effect. This parameter takes effect only if the Type parameter is set to Scheduler. The value of this parameter is in the<c>yyyy-mm-dd hh:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The triggering type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduler: periodically triggered</description></item>
            /// <item><description>Manual</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduler</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
