// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTaskResponseBody : TeaModel {
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
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

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
            /// <para>The information about the associated data source.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskDataSource DataSource { get; set; }
            public class GetTaskResponseBodyTaskDataSource : TeaModel {
                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_test</para>
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
            public List<GetTaskResponseBodyTaskDependencies> Dependencies { get; set; }
            public class GetTaskResponseBodyTaskDependencies : TeaModel {
                /// <summary>
                /// <para>The dependency type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency on the level-1 descendant nodes of a node</description></item>
                /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency on the current node</description></item>
                /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
                /// <item><description>Normal: same-cycle dependency</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>上游任务的输出标识符。（<c>同周期依赖</c>返回此字段）</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <para>上游任务的Id。（<c>跨周期依赖其他节点</c>依赖返回此字段，其他跨周期依赖类型不返回）</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UpstreamTaskId")]
                [Validation(Required=false)]
                public string UpstreamTaskId { get; set; }

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

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The input information.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskInputs Inputs { get; set; }
            public class GetTaskResponseBodyTaskInputs : TeaModel {
                /// <summary>
                /// <para>The variables.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<GetTaskResponseBodyTaskInputsVariables> Variables { get; set; }
                public class GetTaskResponseBodyTaskInputsVariables : TeaModel {
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
                    /// <para>The type.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: constant</description></item>
                    /// <item><description>PassThrough: parameter pass-through</description></item>
                    /// <item><description>System: variable</description></item>
                    /// <item><description>NodeOutput: script output</description></item>
                    /// </list>
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
                    /// <para>Value1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>实例生成模式。</para>
            /// <para>T+1（第二天生成）</para>
            /// <para>Immediately（立即生成）</para>
            /// 
            /// <b>Example:</b>
            /// <para>T+1</para>
            /// </summary>
            [NameInMap("InstanceMode")]
            [Validation(Required=false)]
            public string InstanceMode { get; set; }

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
            /// <para>The name of the task.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskOutputs Outputs { get; set; }
            public class GetTaskResponseBodyTaskOutputs : TeaModel {
                /// <summary>
                /// <para>The task outputs.</para>
                /// </summary>
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<GetTaskResponseBodyTaskOutputsTaskOutputs> TaskOutputs { get; set; }
                public class GetTaskResponseBodyTaskOutputsTaskOutputs : TeaModel {
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
                public List<GetTaskResponseBodyTaskOutputsVariables> Variables { get; set; }
                public class GetTaskResponseBodyTaskOutputsVariables : TeaModel {
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
                    /// <para>The type.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Constant: constant</description></item>
                    /// <item><description>PassThrough: parameter pass-through</description></item>
                    /// <item><description>System: system variable</description></item>
                    /// <item><description>NodeOutput: script output</description></item>
                    /// </list>
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
            /// <para>The priority of the task. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The environment of the workspace.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod: production environment</description></item>
            /// <item><description>Dev: development environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("ProjectEnv")]
            [Validation(Required=false)]
            [Obsolete]
            public string ProjectEnv { get; set; }

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
            /// <para>The rerun interval. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RerunInterval")]
            [Validation(Required=false)]
            public int? RerunInterval { get; set; }

            /// <summary>
            /// <para>The rerun mode.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: The task cannot be rerun regardless of whether the task is successfully run or fails to run.</description></item>
            /// <item><description>FailureAllowed: The task can be rerun only after it fails to run.</description></item>
            /// <item><description>AllAllowed: The task can be rerun regardless of whether it is successfully run or fails to run.</description></item>
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
            /// <para>The configurations of the runtime environment, such as the resource group information.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskRuntimeResource RuntimeResource { get; set; }
            public class GetTaskResponseBodyTaskRuntimeResource : TeaModel {
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
                /// <para>The ID of the image configured for task running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The ID of the resource group for scheduling configured for task running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The script information.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskScript Script { get; set; }
            public class GetTaskResponseBodyTaskScript : TeaModel {
                /// <summary>
                /// <para>The script content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo &quot;helloWorld&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The script parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>para1=$bizdate</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the subtasks, such as a do-while node.</para>
            /// </summary>
            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskSubTasks SubTasks { get; set; }
            public class GetTaskResponseBodyTaskSubTasks : TeaModel {
                /// <summary>
                /// <para>The subtasks.</para>
                /// </summary>
                [NameInMap("SubTasks")]
                [Validation(Required=false)]
                public List<GetTaskResponseBodyTaskSubTasksSubTasks> SubTasks { get; set; }
                public class GetTaskResponseBodyTaskSubTasksSubTasks : TeaModel {
                    /// <summary>
                    /// <para>The baseline ID.</para>
                    /// </summary>
                    [NameInMap("BaselineId")]
                    [Validation(Required=false)]
                    public long? BaselineId { get; set; }

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
                    /// <para>The information about the associated data source.</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public GetTaskResponseBodyTaskSubTasksSubTasksDataSource DataSource { get; set; }
                    public class GetTaskResponseBodyTaskSubTasksSubTasksDataSource : TeaModel {
                        /// <summary>
                        /// <para>The name of the data source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mysql_test</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

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

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The task ID.</para>
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
                    /// <para>The name of the task.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

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
                    /// <para>The priority of the task. Valid values: 1 to 8. A larger value indicates a higher priority. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>The environment of the workspace.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Prod: production environment</description></item>
                    /// <item><description>Dev: development environment</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prod</para>
                    /// </summary>
                    [NameInMap("ProjectEnv")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string ProjectEnv { get; set; }

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
                    /// <para>The rerun interval. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>180</para>
                    /// </summary>
                    [NameInMap("RerunInterval")]
                    [Validation(Required=false)]
                    public int? RerunInterval { get; set; }

                    /// <summary>
                    /// <para>The rerun mode.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AllDenied: The task cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
                    /// <item><description>FailureAllowed: The task can be rerun only after it fails to run.</description></item>
                    /// <item><description>AllAllowed: The task can be rerun regardless of whether it is successfully run or fails to run.</description></item>
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
                    /// <para>The runtime environment configuration of the task, such as the resource group.</para>
                    /// </summary>
                    [NameInMap("RuntimeResource")]
                    [Validation(Required=false)]
                    public GetTaskResponseBodyTaskSubTasksSubTasksRuntimeResource RuntimeResource { get; set; }
                    public class GetTaskResponseBodyTaskSubTasksSubTasksRuntimeResource : TeaModel {
                        /// <summary>
                        /// <para>The default number of CUs configured for task running.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.25</para>
                        /// </summary>
                        [NameInMap("Cu")]
                        [Validation(Required=false)]
                        public string Cu { get; set; }

                        /// <summary>
                        /// <para>The ID of the image configured for task running.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-xxxxxx</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource group for scheduling configured for task running.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                        /// </summary>
                        [NameInMap("ResourceGroupId")]
                        [Validation(Required=false)]
                        public string ResourceGroupId { get; set; }

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
                    /// <para>The method to trigger task scheduling.</para>
                    /// </summary>
                    [NameInMap("Trigger")]
                    [Validation(Required=false)]
                    public GetTaskResponseBodyTaskSubTasksSubTasksTrigger Trigger { get; set; }
                    public class GetTaskResponseBodyTaskSubTasksSubTasksTrigger : TeaModel {
                        /// <summary>
                        /// <para>The CRON expression of the task. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00 00 00 * * ?</para>
                        /// </summary>
                        [NameInMap("Cron")]
                        [Validation(Required=false)]
                        public string Cron { get; set; }

                        /// <summary>
                        /// <para>The end time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9999-01-01 00:00:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                        /// <para>Valid values:</para>
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
                        /// <para>The start time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1970-01-01 00:00:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The trigger type.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Scheduler: scheduling cycle-based trigger</description></item>
                        /// <item><description>Manual: manual trigger</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Scheduler</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ODPS_SQL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the workflow to which the task belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("WorkflowId")]
                    [Validation(Required=false)]
                    public long? WorkflowId { get; set; }

                }

                /// <summary>
                /// <para>The type of the subtask.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DoWhile: do-while node</description></item>
                /// <item><description>Combined: node group</description></item>
                /// <item><description>ForEach: for-each node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Combined</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskTags> Tags { get; set; }
            public class GetTaskResponseBodyTaskTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <para>The method to trigger task scheduling.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskTrigger Trigger { get; set; }
            public class GetTaskResponseBodyTaskTrigger : TeaModel {
                /// <summary>
                /// <para>The CRON expression of the task. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 00 00 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The end time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                /// <para>Valid values:</para>
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
                /// <para>The start time of the time range during which the task is periodically scheduled. This parameter takes effect only if the Type parameter is set to Scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1970-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The trigger type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: scheduling cycle-based trigger</description></item>
                /// <item><description>Manual: manual trigger</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

        }

    }

}
