// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public List<UpdateScheduledTaskRequestDescription> Description { get; set; }
        public class UpdateScheduledTaskRequestDescription : TeaModel {
            /// <summary>
            /// <para>The text content. This parameter is required when type is set to text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether the feature is enabled. This parameter is optional when type is set to web_search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object ID. This parameter has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The skill code. This parameter has a value when type is set to skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>The element type. Valid values: text, web_search, mention, and skill.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of digital employee names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test&quot;]</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

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
        /// <para>The execution model tier. If this parameter is not specified, the model tier is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output conversation mode. If this parameter is omitted, the current configuration is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAME_CONVERSATION</para>
        /// </summary>
        [NameInMap("outputMode")]
        [Validation(Required=false)]
        public string OutputMode { get; set; }

        /// <summary>
        /// <para>The segments.</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public List<UpdateScheduledTaskRequestSegments> Segments { get; set; }
        public class UpdateScheduledTaskRequestSegments : TeaModel {
            /// <summary>
            /// <para>The text content. This parameter is required when type is set to text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether the feature is enabled. This parameter is optional when type is set to web_search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object ID. This parameter has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The skill code. This parameter has a value when type is set to skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>The element type. Valid values: text, web_search, mention, and skill.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("taskDetail")]
        [Validation(Required=false)]
        public UpdateScheduledTaskRequestTaskDetail TaskDetail { get; set; }
        public class UpdateScheduledTaskRequestTaskDetail : TeaModel {
            /// <summary>
            /// <para>The related objects.</para>
            /// </summary>
            [NameInMap("relatedObjects")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedObjects> RelatedObjects { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedObjects : TeaModel {
                /// <summary>
                /// <para>The mention type, such as objects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("mentionType")]
                [Validation(Required=false)]
                public string MentionType { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SampleName.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The object ID. This parameter has a value when the object is specified by using the @ symbol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleObjectId</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The object type, such as customer or company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            /// <summary>
            /// <para>The related semantics.</para>
            /// </summary>
            [NameInMap("relatedSemantics")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedSemantics> RelatedSemantics { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedSemantics : TeaModel {
                /// <summary>
                /// <para>The semantic attributes in JSON string format. This parameter is used for filtering during semantic retrieval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;level&quot;: &quot;VIP&quot;}</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>The semantic entity name, such as customer or opportunity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("entity")]
                [Validation(Required=false)]
                public string Entity { get; set; }

            }

            /// <summary>
            /// <para>The related skills.</para>
            /// </summary>
            [NameInMap("relatedSkills")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedSkills> RelatedSkills { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedSkills : TeaModel {
                /// <summary>
                /// <para>The display name of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SampleName.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("skillCode")]
                [Validation(Required=false)]
                public string SkillCode { get; set; }

                /// <summary>
                /// <para>sourceIds</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;sourceIds&quot;]</para>
                /// </summary>
                [NameInMap("sourceIds")]
                [Validation(Required=false)]
                public List<string> SourceIds { get; set; }

            }

            /// <summary>
            /// <para>The task understanding description refined by the large language model (LLM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("taskUnderstand")]
            [Validation(Required=false)]
            public string TaskUnderstand { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The trigger configuration. The configuration varies based on the trigger type.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public UpdateScheduledTaskRequestTriggerConfig TriggerConfig { get; set; }
        public class UpdateScheduledTaskRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression. This parameter is required when trigger_mode is set to scheduled. Example: 00 09 * * *.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The language, such as zh-CN or en-US. This parameter is automatically injected by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The list of task push channels. If the list is empty or no channel is enabled, no push notification is sent.</para>
            /// </summary>
            [NameInMap("pushConfig")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTriggerConfigPushConfig> PushConfig { get; set; }
            public class UpdateScheduledTaskRequestTriggerConfigPushConfig : TeaModel {
                /// <summary>
                /// <para>The push channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DINGTALK</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>The scope of the push content. Default value: all_replies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all_replies</para>
                /// </summary>
                [NameInMap("contentScope")]
                [Validation(Required=false)]
                public string ContentScope { get; set; }

                /// <summary>
                /// <para>The delivery method. Default value: channel_bot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>channel_bot</para>
                /// </summary>
                [NameInMap("deliveryMethod")]
                [Validation(Required=false)]
                public string DeliveryMethod { get; set; }

                /// <summary>
                /// <para>Specifies whether to push notifications to the channel. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The push format for output files. Default value: file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("fileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>The digital employee to which the sending bot belongs. This parameter is required and cannot be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("operatingObjectName")]
                [Validation(Required=false)]
                public string OperatingObjectName { get; set; }

                /// <summary>
                /// <para>The recipient. Only self is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

            }

            /// <summary>
            /// <para>The time zone, such as Asia/Shanghai. This parameter is automatically injected by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The trigger mode. Valid values: manual and scheduled.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        /// <summary>
        /// <para>The visibility scope adjustment for group tasks. Valid values: PRIVATE (visible only to the creator and group owner), COLLABORATIVE (visible to specified collaborators), and PUBLIC (visible to all group members). If this parameter is not specified, the visibility scope is not updated. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COLLABORATIVE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The full replacement list of collaborators. This parameter takes effect only when visibility is set to COLLABORATIVE. When the visibility is changed from COLLABORATIVE to another value, the list is cleared. A maximum of 1,000 members are supported. If this parameter is not specified, the members are not updated. You do not need to specify the task creator and group creator because they are covered by the authentication layer. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10001&quot;]</para>
        /// </summary>
        [NameInMap("visibleMemberUserIds")]
        [Validation(Required=false)]
        public List<string> VisibleMemberUserIds { get; set; }

    }

}
