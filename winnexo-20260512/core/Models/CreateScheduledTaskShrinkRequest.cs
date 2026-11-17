// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateScheduledTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group to which the task belongs, such as cg_101. If this parameter is passed, a group space task is created, and the caller must be a valid group member. If this parameter is empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The description of the to-do card type.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string DescriptionShrink { get; set; }

        /// <summary>
        /// <para>The name of the current effective digital employee. This parameter is empty if it is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pcitc-magent&quot;]</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether public access is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOpen")]
        [Validation(Required=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>The large language model used by the assistant. The default value is empty, which indicates that DingTalk automatically selects the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>输出会话模式，默认 NEW_CONVERSATION</para>
        /// 
        /// <b>Example:</b>
        /// <para>NEW_CONVERSATION</para>
        /// </summary>
        [NameInMap("outputMode")]
        [Validation(Required=false)]
        public string OutputMode { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public string SegmentsShrink { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("taskDetail")]
        [Validation(Required=false)]
        public string TaskDetailShrink { get; set; }

        /// <summary>
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The trigger configuration of the scheduled task. The triggerMode parameter supports manual (manual trigger) and scheduled (scheduled trigger). If scheduled is used, the cron parameter must be specified. The timezone and language parameters are injected by the server, and the client does not need to pass them. The pushConfig parameter is the list of task push channels. If the list is empty or no channel is enabled, no push is performed.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfigShrink { get; set; }

        /// <summary>
        /// <para>The visibility scope of the group task. Valid values: PRIVATE (visible only to the creator and group owner), COLLABORATIVE (visible to specified collaboration members), and PUBLIC (visible to all group members). If this parameter is not passed for a group task, the default value is PRIVATE. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The list of user IDs of collaboration members. This parameter takes effect only when visibility is set to COLLABORATIVE and is ignored for other values. A maximum of 1,000 user IDs can be specified. You do not need to pass the IDs of the task creator and group creator because they are covered by the authentication layer. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1002&quot;]</para>
        /// </summary>
        [NameInMap("visibleMemberUserIds")]
        [Validation(Required=false)]
        public string VisibleMemberUserIdsShrink { get; set; }

    }

}
