// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskConversationRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether a next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The collaboration group ID, such as cg_101. If you specify this parameter, the data is returned by group dimension, and the caller must be a valid group member. If you do not specify this parameter, the data is returned by personal dimension, excluding group tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The list of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetScheduledTaskConversationRecordsResponseBodyTasks> Tasks { get; set; }
        public class GetScheduledTaskConversationRecordsResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>Pre-filters by a single task. If you do not specify this parameter, the execution records of all visible tasks are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleCollaborationGroupId</para>
            /// </summary>
            [NameInMap("collaborationGroupId")]
            [Validation(Required=false)]
            public string CollaborationGroupId { get; set; }

            /// <summary>
            /// <para>The list of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("conversations")]
            [Validation(Required=false)]
            public List<GetScheduledTaskConversationRecordsResponseBodyTasksConversations> Conversations { get; set; }
            public class GetScheduledTaskConversationRecordsResponseBodyTasksConversations : TeaModel {
                /// <summary>
                /// <para>The actual group topic ID, which can be associated in queryWorkItemFeed. This ID cannot be used as a Workflow workItemId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleConversationId</para>
                /// </summary>
                [NameInMap("conversationId")]
                [Validation(Required=false)]
                public string ConversationId { get; set; }

                /// <summary>
                /// <para>The name of the schedule location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Daily sales weekly report</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>Indicates whether unread messages exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasUnread")]
                [Validation(Required=false)]
                public bool? HasUnread { get; set; }

                /// <summary>
                /// <para>The ID of the latest execution record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleExecutionId</para>
                /// </summary>
                [NameInMap("latestExecutionId")]
                [Validation(Required=false)]
                public string LatestExecutionId { get; set; }

                /// <summary>
                /// <para>The latest execution status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("latestStatus")]
                [Validation(Required=false)]
                public string LatestStatus { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-16T09:30:00+08:00</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

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
            /// <para>Indicates whether public access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            /// <summary>
            /// <para>The execution model tier. Valid values: flagship (Flagship), standard (Standard), and quick (Lightweight).</para>
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
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleTaskId</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// <remarks>
            /// <para>Default value: UTC+8.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: Manual execution.</description></item>
            /// <item><description>Cron: Scheduled trigger.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>The total number of Logtail pipeline configurations in the current project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
