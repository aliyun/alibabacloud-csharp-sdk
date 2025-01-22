// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Workflow")]
        [Validation(Required=false)]
        public GetWorkflowResponseBodyWorkflow Workflow { get; set; }
        public class GetWorkflowResponseBodyWorkflow : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientUniqueCode")]
            [Validation(Required=false)]
            public string ClientUniqueCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowDependencies> Dependencies { get; set; }
            public class GetWorkflowResponseBodyWorkflowDependencies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("UpstreamOutput")]
                [Validation(Required=false)]
                public string UpstreamOutput { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("UpstreamTaskId")]
                [Validation(Required=false)]
                public long? UpstreamTaskId { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710239005403</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public GetWorkflowResponseBodyWorkflowOutputs Outputs { get; set; }
            public class GetWorkflowResponseBodyWorkflowOutputs : TeaModel {
                [NameInMap("TaskOutputs")]
                [Validation(Required=false)]
                public List<GetWorkflowResponseBodyWorkflowOutputsTaskOutputs> TaskOutputs { get; set; }
                public class GetWorkflowResponseBodyWorkflowOutputsTaskOutputs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pre.odps_sql_demo_0</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>para1=$bizdate para2=$[yyyymmdd]</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowTags> Tags { get; set; }
            public class GetWorkflowResponseBodyWorkflowTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetWorkflowResponseBodyWorkflowTasks> Tasks { get; set; }
            public class GetWorkflowResponseBodyWorkflowTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
                /// </summary>
                [NameInMap("ClientUniqueCode")]
                [Validation(Required=false)]
                public string ClientUniqueCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public GetWorkflowResponseBodyWorkflowTasksDataSource DataSource { get; set; }
                public class GetWorkflowResponseBodyWorkflowTasksDataSource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql_test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RerunInterval")]
                [Validation(Required=false)]
                public int? RerunInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AllAllowed</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RerunTimes")]
                [Validation(Required=false)]
                public int? RerunTimes { get; set; }

                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public GetWorkflowResponseBodyWorkflowTasksRuntimeResource RuntimeResource { get; set; }
                public class GetWorkflowResponseBodyWorkflowTasksRuntimeResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public string Cu { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-xxxxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("TriggerRecurrence")]
                [Validation(Required=false)]
                public string TriggerRecurrence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public GetWorkflowResponseBodyWorkflowTrigger Trigger { get; set; }
            public class GetWorkflowResponseBodyWorkflowTrigger : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>00 00 00 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1970-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1970-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Scheduler</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
