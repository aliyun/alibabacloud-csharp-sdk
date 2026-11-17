// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListScheduledTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more data is available. Valid values: true (yes) and false (no).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of skill cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListScheduledTasksResponseBodyItems> Items { get; set; }
        public class ListScheduledTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The cause of the exception. This field has a value only when status is abnormal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("abnormalReason")]
            [Validation(Required=false)]
            public string AbnormalReason { get; set; }

            /// <summary>
            /// <para>Indicates whether the current caller can delete the task. This is valid only for the task creator and group owner. For personal tasks, the value is always true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>Indicates whether the course can be edited or deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// <para>Indicates whether the current caller can immediately execute the task. Visible means operable. For abnormal tasks, the value is false. For personal tasks, the value is always true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canExecute")]
            [Validation(Required=false)]
            public bool? CanExecute { get; set; }

            /// <summary>
            /// <para>Indicates whether the current caller can start or stop the task. This is valid only for the task creator and group owner. For abnormal tasks, the value is false. For personal tasks, the value is always true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canToggle")]
            [Validation(Required=false)]
            public bool? CanToggle { get; set; }

            /// <summary>
            /// <para>The ID of the collaboration group to which the task belongs, such as cg_101. If this parameter is specified, a group space task is created, and the caller must be a valid group member. If this parameter is left empty, a personal task is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleCollaborationGroupId</para>
            /// </summary>
            [NameInMap("collaborationGroupId")]
            [Validation(Required=false)]
            public string CollaborationGroupId { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The description of the to-do card type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of digital employee names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;pcitc-magent&quot;]</para>
            /// </summary>
            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public List<string> DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>The cumulative number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("executionCount")]
            [Validation(Required=false)]
            public long? ExecutionCount { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether public access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            /// <summary>
            /// <para>The execution model tier. If this parameter is not specified, the model tier is not updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The task output session mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEW_CONVERSATION</para>
            /// </summary>
            [NameInMap("outputMode")]
            [Validation(Required=false)]
            public string OutputMode { get; set; }

            /// <summary>
            /// <para>The task status. Running is returned immediately after submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleTaskId</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The visibility scope of the group task. Valid values: PRIVATE (visible only to the creator and group owner), COLLABORATIVE (visible to specified collaboration members), and PUBLIC (visible to all group members). Default value for group tasks: PRIVATE. This field is ignored for personal tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            /// <summary>
            /// <para>The list of collaboration members, excluding the task creator and group creator, which are covered by the authentication layer. This field is returned only for group tasks. An empty list is returned for PRIVATE or PUBLIC visibility scopes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1001&quot;]</para>
            /// </summary>
            [NameInMap("visibleMemberUserIds")]
            [Validation(Required=false)]
            public List<string> VisibleMemberUserIds { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763604514518000_531300</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The specified page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
