// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The client unique code of the node, which uniquely identifies a node. This code is used for asynchronous operations and idempotence. If you do not specify this parameter during creation, the system automatically generates one. The code is uniquely bound to the resource ID. When updating or deleting a resource, if you specify this parameter, it must be the same as the client unique code specified during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>The associated data source information.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public UpdateTaskAsyncRequestDataSource DataSource { get; set; }
        public class UpdateTaskAsyncRequestDataSource : TeaModel {
            /// <summary>
            /// <para>The data source name.</para>
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
        public List<UpdateTaskAsyncRequestDependencies> Dependencies { get; set; }
        public class UpdateTaskAsyncRequestDependencies : TeaModel {
            /// <summary>
            /// <para>The dependency type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CrossCycleDependsOnChildren: cross-cycle dependency on first-level child nodes</description></item>
            /// <item><description>CrossCycleDependsOnSelf: cross-cycle dependency on the current node</description></item>
            /// <item><description>CrossCycleDependsOnOtherNode: cross-cycle dependency on other nodes</description></item>
            /// <item><description>Normal: same-cycle dependency</description></item>
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
            /// <para>The output identifier of the upstream node. This field is returned when the dependency type is same-cycle dependency and input content is set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre.odps_sql_demo_0</para>
            /// </summary>
            [NameInMap("UpstreamOutput")]
            [Validation(Required=false)]
            public string UpstreamOutput { get; set; }

            /// <summary>
            /// <para>The ID of the upstream node. This field is returned when the dependency type is cross-cycle dependency on other nodes or same-cycle dependency without input content set. It is not returned in other cases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("UpstreamTaskId")]
            [Validation(Required=false)]
            public long? UpstreamTaskId { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production</description></item>
        /// <item><description>Dev: development</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The input information.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public UpdateTaskAsyncRequestInputs Inputs { get; set; }
        public class UpdateTaskAsyncRequestInputs : TeaModel {
            /// <summary>
            /// <para>The list of variable definitions.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<UpdateTaskAsyncRequestInputsVariables> Variables { get; set; }
            public class UpdateTaskAsyncRequestInputsVariables : TeaModel {
                /// <summary>
                /// <para>The variable name.</para>
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
                /// <item><description>Constant: constant</description></item>
                /// <item><description>PassThrough: parameter node output</description></item>
                /// <item><description>System: variable</description></item>
                /// <item><description>NodeOutput: script output</description></item>
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
                /// <para>The variable value.</para>
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
        /// <item><description>T+1: Generates instances the next day.</description></item>
        /// <item><description>Immediately: Generates instances immediately. Note: Only periodic instances whose scheduled time is at least 10 minutes after the node publish time are generated. During the full instance generation period (22:00 to 24:00), real-time instance generation is not available. You can submit and publish nodes, but new nodes do not automatically generate instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public UpdateTaskAsyncRequestOutputs Outputs { get; set; }
        public class UpdateTaskAsyncRequestOutputs : TeaModel {
            /// <summary>
            /// <para>The list of node output definitions.</para>
            /// </summary>
            [NameInMap("TaskOutputs")]
            [Validation(Required=false)]
            public List<UpdateTaskAsyncRequestOutputsTaskOutputs> TaskOutputs { get; set; }
            public class UpdateTaskAsyncRequestOutputsTaskOutputs : TeaModel {
                /// <summary>
                /// <para>The output identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre.odps_sql_demo_0</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

            }

            /// <summary>
            /// <para>The list of variable definitions.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<UpdateTaskAsyncRequestOutputsVariables> Variables { get; set; }
            public class UpdateTaskAsyncRequestOutputsVariables : TeaModel {
                /// <summary>
                /// <para>The variable name.</para>
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
                /// <item><description>Constant: constant</description></item>
                /// <item><description>PassThrough: parameter node output</description></item>
                /// <item><description>System: variable</description></item>
                /// <item><description>NodeOutput: script output</description></item>
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
                /// <para>The variable value.</para>
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
        /// <para>The account ID of the node owner. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and hover over the profile picture in the upper-right corner of the top navigation bar to view the account ID. If this parameter is left empty, the Alibaba Cloud account ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The retry time interval, in milliseconds. The value cannot exceed 1800000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("RerunInterval")]
        [Validation(Required=false)]
        public int? RerunInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether the node can be rerun. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllDenied: Cannot be rerun regardless of success or failure.</description></item>
        /// <item><description>FailureAllowed: Can be rerun only upon failure.</description></item>
        /// <item><description>AllAllowed: Can be rerun regardless of success or failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllAllowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The number of retries. This parameter takes effect when the node is configured to allow reruns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RerunTimes")]
        [Validation(Required=false)]
        public int? RerunTimes { get; set; }

        /// <summary>
        /// <para>The runtime environment configuration, such as schedule resource group information.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public UpdateTaskAsyncRequestRuntimeResource RuntimeResource { get; set; }
        public class UpdateTaskAsyncRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The CU consumption configured for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>The image ID configured for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The identifier of the schedule resource group configured for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63900680</para>
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
        public UpdateTaskAsyncRequestScript Script { get; set; }
        public class UpdateTaskAsyncRequestScript : TeaModel {
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
            /// <para>The list of script parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>para1=$bizdate</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

        }

        /// <summary>
        /// <para>The list of data asset tags to bind.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateTaskAsyncRequestTags> Tags { get; set; }
        public class UpdateTaskAsyncRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout setting for scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The trigger method of the node.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateTaskAsyncRequestTrigger Trigger { get; set; }
        public class UpdateTaskAsyncRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The cron expression. This parameter takes effect when type is set to Scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The epoch type. This parameter takes effect when Type is set to Scheduler and the cron expression specifies timed scheduling within a specific hour. Default value: Daily. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: daily scheduling</description></item>
            /// <item><description>NotDaily: hourly scheduling</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The time when the periodic trigger expires. This parameter takes effect when type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The run mode when the trigger fires. This parameter takes effect when type is set to Scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pause: paused</description></item>
            /// <item><description>Skip: dry run</description></item>
            /// <item><description>Normal: normal execution</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Recurrence")]
            [Validation(Required=false)]
            public string Recurrence { get; set; }

            /// <summary>
            /// <para>The effective period of the epoch trigger. This parameter takes effect when type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduler: periodic scheduling trigger</description></item>
            /// <item><description>Manual: manual trigger</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BySchedule</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
