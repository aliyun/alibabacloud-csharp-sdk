// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchUpdateTasksRequest : TeaModel {
        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<BatchUpdateTasksRequestTasks> Tasks { get; set; }
        public class BatchUpdateTasksRequestTasks : TeaModel {
            /// <summary>
            /// <para>The associated data source information.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public BatchUpdateTasksRequestTasksDataSource DataSource { get; set; }
            public class BatchUpdateTasksRequestTasksDataSource : TeaModel {
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
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod: Production.</description></item>
            /// <item><description>Dev: Development.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL node</para>
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
            /// <para>The retry time interval, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RerunInterval")]
            [Validation(Required=false)]
            public int? RerunInterval { get; set; }

            /// <summary>
            /// <para>Specifies whether the task can be rerun. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllDenied: The task cannot be rerun after either success or failure.</description></item>
            /// <item><description>FailureAllowed: The task can be rerun only after failure.</description></item>
            /// <item><description>AllAllowed: The task can be rerun after either success or failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllAllowed</para>
            /// </summary>
            [NameInMap("RerunMode")]
            [Validation(Required=false)]
            public string RerunMode { get; set; }

            /// <summary>
            /// <para>The number of retries. This parameter takes effect only when the task is configured to allow reruns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RerunTimes")]
            [Validation(Required=false)]
            public int? RerunTimes { get; set; }

            /// <summary>
            /// <para>The runtime environment configurations, such as the resource group information.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public BatchUpdateTasksRequestTasksRuntimeResource RuntimeResource { get; set; }
            public class BatchUpdateTasksRequestTasksRuntimeResource : TeaModel {
                /// <summary>
                /// <para>The number of compute units (CUs) consumed by the task run configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The ID of the image configured for task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The identifier of the scheduling resource group configured for task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The list of task tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<BatchUpdateTasksRequestTasksTags> Tags { get; set; }
            public class BatchUpdateTasksRequestTasksTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// <para>This parameter is required.</para>
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
            /// <para>The timeout period for task execution, in seconds. The value must be greater than 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The task trigger type.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public BatchUpdateTasksRequestTasksTrigger Trigger { get; set; }
            public class BatchUpdateTasksRequestTasksTrigger : TeaModel {
                /// <summary>
                /// <para>The cron expression. This parameter takes effect only when Type is set to Scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 00 00 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The expiration time of the periodic trigger. This parameter takes effect only when Type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The run mode when the task is triggered. This parameter takes effect only when Type is set to Scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pause: Paused.</description></item>
                /// <item><description>Skip: Dry run.</description></item>
                /// <item><description>Normal: Normal execution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Recurrence")]
                [Validation(Required=false)]
                public string Recurrence { get; set; }

                /// <summary>
                /// <para>The start time for periodic triggers. This parameter takes effect only when Type is set to Scheduler. Format: <c>yyyy-mm-dd hh:mm:ss</c>.</para>
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
                /// <item><description>Scheduler: Triggered by a scheduling cycle.</description></item>
                /// <item><description>Manual: Manually triggered.</description></item>
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

}
