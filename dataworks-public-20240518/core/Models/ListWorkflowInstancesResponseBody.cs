// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListWorkflowInstancesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListWorkflowInstancesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The list of workflow instances.</para>
            /// </summary>
            [NameInMap("WorkflowInstances")]
            [Validation(Required=false)]
            public List<ListWorkflowInstancesResponseBodyPagingInfoWorkflowInstances> WorkflowInstances { get; set; }
            public class ListWorkflowInstancesResponseBodyPagingInfoWorkflowInstances : TeaModel {
                /// <summary>
                /// <para>The business date.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The account ID of the user who created the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The project environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod (Production)</description></item>
                /// <item><description>Dev (Development)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The completion time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public long? FinishedTime { get; set; }

                /// <summary>
                /// <para>The unique identifier of the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The account ID of the user who updated the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WorkflowInstance1</para>
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
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("StartedTime")]
                [Validation(Required=false)]
                public long? StartedTime { get; set; }

                /// <summary>
                /// <para>The running status of the workflow instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NotRun: Not run.</description></item>
                /// <item><description>Running: Running.</description></item>
                /// <item><description>WaitTime: Waiting for the trigger time.</description></item>
                /// <item><description>CheckingCondition: Checking branch conditions.</description></item>
                /// <item><description>WaitResource: Waiting for resources.</description></item>
                /// <item><description>Failure: Failed.</description></item>
                /// <item><description>Success: Successful.</description></item>
                /// <item><description>Checking: Submitted for data quality check.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListWorkflowInstancesResponseBodyPagingInfoWorkflowInstancesTags> Tags { get; set; }
                public class ListWorkflowInstancesResponseBodyPagingInfoWorkflowInstancesTags : TeaModel {
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
                /// <para>The type of the workflow instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: Periodic scheduling.</description></item>
                /// <item><description>Manual: Manual task.</description></item>
                /// <item><description>SmokeTest: Smoke test.</description></item>
                /// <item><description>SupplementData: Data backfill.</description></item>
                /// <item><description>ManualWorkflow: Manual workflow.</description></item>
                /// <item><description>TriggerWorkflow: Triggered workflow.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unified workflow instance ID. The value of this field is the same for all workflow instances within a specific business date under a single trigger.</para>
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
                /// <para>Periodic workflow:
                /// key1=value1 key2=value2
                /// Manual workflow:
                /// {&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
                /// </summary>
                [NameInMap("WorkflowParameters")]
                [Validation(Required=false)]
                public string WorkflowParameters { get; set; }

                /// <summary>
                /// <para>The ID of the task instance corresponding to the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("WorkflowTaskInstanceId")]
                [Validation(Required=false)]
                public long? WorkflowTaskInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
