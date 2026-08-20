// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateScheduledTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group (such as cg_101). If specified, a group space task is created (the caller must be a valid group member). If empty, a personal task is created.</para>
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
        /// <para>The name of the current effective digital employee. This parameter is empty if not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether public access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOpen")]
        [Validation(Required=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>The large model used by the assistant. An empty value indicates that DingTalk automatically selects the model.</para>
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
        /// <para>The ID of the effective tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The trigger configuration. The configuration varies depending on the trigger type. For the specific format, refer to the following data structures:</para>
        /// <list type="bullet">
        /// <item><description>OSS trigger: See <a href="https://help.aliyun.com/document_detail/415697.html">OSSTriggerConfig</a>.</description></item>
        /// <item><description>Simple Log Service trigger: See <a href="https://help.aliyun.com/document_detail/415694.html">LogTriggerConfig</a>.</description></item>
        /// <item><description>Time trigger: See <a href="https://help.aliyun.com/document_detail/415712.html">TimeTriggerConfig</a>.</description></item>
        /// <item><description>HTTP trigger: See <a href="https://help.aliyun.com/document_detail/415685.html">HTTPTriggerConfig</a>.</description></item>
        /// <item><description>Tablestore trigger: You only need to specify the complete <b>SourceArn</b> parameter. No additional configuration is required. Set the value to an empty object {}.</description></item>
        /// <item><description>CDN event trigger: See <a href="https://help.aliyun.com/document_detail/415674.html">CDNEventsTriggerConfig</a>.</description></item>
        /// <item><description>MNS topic trigger: See <a href="https://help.aliyun.com/document_detail/415695.html">MnsTopicTriggerConfig</a>.</description></item>
        /// <item><description>EventBridge trigger: See <a href="https://help.aliyun.com/document_detail/2508622.html">EventBridgeTriggerConfig</a>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfigShrink { get; set; }

        /// <summary>
        /// <para>The visibility scope of the group task. Valid values: PRIVATE (visible only to the creator and group owner), COLLABORATIVE (visible to specified collaborators), and PUBLIC (visible to all group members). Default value for group tasks: PRIVATE. This parameter is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The list of collaborator user IDs. This parameter takes effect only when visibility is set to COLLABORATIVE. It is ignored for other visibility levels. A maximum of 1000 IDs are supported. The task creator and group creator do not need to be included (covered by the authentication layer). This parameter is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("visibleMemberUserIds")]
        [Validation(Required=false)]
        public string VisibleMemberUserIdsShrink { get; set; }

    }

}
