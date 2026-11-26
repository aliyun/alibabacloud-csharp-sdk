// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>平台应用 Token（控制台签发）。传入后将以 opsUserId 或 opsUserCode 指定的用户身份执行</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>AUTO 偏好：none=默认、performance=效果优先、credit=成本优先；创建缺省为 none，固定模型可保存但不生效</para>
        /// 
        /// <b>Example:</b>
        /// <para>performance</para>
        /// </summary>
        [NameInMap("autoPreference")]
        [Validation(Required=false)]
        public string AutoPreference { get; set; }

        /// <summary>
        /// <para>The ID of the associated collaboration group (such as cg_101). If this parameter is passed, a group space task is created, and the caller must be a valid group member. If this parameter is empty, a personal task is created.</para>
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
        public List<CreateScheduledTaskRequestDescription> Description { get; set; }
        public class CreateScheduledTaskRequestDescription : TeaModel {
            /// <summary>
            /// <para>The streaming output message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether the throttling rule is enabled. A value of true indicates that the rule is enabled, and a value of false indicates that the rule is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample name.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object ID. Pass the project task ID.</para>
            /// <list type="bullet">
            /// <item><description>For internal enterprise applications, call the <a href="https://open.dingtalk.com/document/orgapp-server/create-a-project-task">Create a project task</a> API to obtain the taskId.</description></item>
            /// <item><description>For third-party enterprise applications, call the <a href="https://open.dingtalk.com/document/isvapp-server/create-a-project-task">Create a project task</a> API to obtain the taskId.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type. Set the value to task, which indicates a project task.</para>
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
            /// <para>The HTTP API type. Valid values: Http (common HTTP API), Rest (RESTful API), WebSocket (WebSocket API), HttpIngress (HTTP API accessed through Ingress), LLM (large language model API), and Agent (agent API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the currently effective digital employee. This parameter is empty if it is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pcitc-magent&quot;]</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

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
        /// <para>The large model used by the assistant. The default value is empty, which indicates that DingTalk automatically selects the model.</para>
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
        /// <para>Sample name.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>代理用户编码（租户内唯一），仅当应用凭证配置为 source_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>代理用户ID（WINNEXO 平台用户ID），仅当应用凭证配置为 winnexo_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The output conversation mode. Default value: NEW_CONVERSATION.</para>
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
        public List<CreateScheduledTaskRequestSegments> Segments { get; set; }
        public class CreateScheduledTaskRequestSegments : TeaModel {
            /// <summary>
            /// <para>The card callback content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample name.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item. The value can be a <b>feedId</b> or a mini-app ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The saved customer type.</para>
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
            /// <para>The billing type. Currently, only fixed is supported.</para>
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
        public CreateScheduledTaskRequestTaskDetail TaskDetail { get; set; }
        public class CreateScheduledTaskRequestTaskDetail : TeaModel {
            /// <summary>
            /// <para>The associated objects.</para>
            /// </summary>
            [NameInMap("relatedObjects")]
            [Validation(Required=false)]
            public List<CreateScheduledTaskRequestTaskDetailRelatedObjects> RelatedObjects { get; set; }
            public class CreateScheduledTaskRequestTaskDetailRelatedObjects : TeaModel {
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample name.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The object ID. Pass the project task ID.</para>
                /// <list type="bullet">
                /// <item><description>For internal enterprise applications, call the <a href="https://open.dingtalk.com/document/orgapp-server/create-a-project-task">Create a project task</a> API to obtain the taskId.</description></item>
                /// <item><description>For third-party enterprise applications, call the <a href="https://open.dingtalk.com/document/isvapp-server/create-a-project-task">Create a project task</a> API to obtain the taskId.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>exampleObjectId</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The relationship type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>crm_customer: Enterprise customer.</description></item>
                /// <item><description>crm_customer_personal: Individual customer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            /// <summary>
            /// <para>The associated semantics.</para>
            /// </summary>
            [NameInMap("relatedSemantics")]
            [Validation(Required=false)]
            public List<CreateScheduledTaskRequestTaskDetailRelatedSemantics> RelatedSemantics { get; set; }
            public class CreateScheduledTaskRequestTaskDetailRelatedSemantics : TeaModel {
                /// <summary>
                /// <para>The file extension information.</para>
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
            /// <para>The associated skills.</para>
            /// </summary>
            [NameInMap("relatedSkills")]
            [Validation(Required=false)]
            public List<CreateScheduledTaskRequestTaskDetailRelatedSkills> RelatedSkills { get; set; }
            public class CreateScheduledTaskRequestTaskDetailRelatedSkills : TeaModel {
                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample name.pdf</para>
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
                /// <para>[&quot;113424&quot;]</para>
                /// </summary>
                [NameInMap("sourceIds")]
                [Validation(Required=false)]
                public List<string> SourceIds { get; set; }

            }

            /// <summary>
            /// <para>The task understanding description polished by the LLM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("taskUnderstand")]
            [Validation(Required=false)]
            public string TaskUnderstand { get; set; }

        }

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
        /// <para>The trigger configuration of the scheduled task. triggerMode supports manual (manual trigger) and scheduled (scheduled trigger). If scheduled is used, cron must be specified. timezone and language are injected by the server, and the client does not need to pass them. pushConfig is the list of task push channels. If it is empty or no channel is enabled, no push is performed.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public CreateScheduledTaskRequestTriggerConfig TriggerConfig { get; set; }
        public class CreateScheduledTaskRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>The periodic training information. The cron syntax is used (Minutes Hours DayofMonth Month DayofWeek). If this parameter is empty, periodic training is not performed, which is the default value. In DayofWeek, 0 indicates Sunday.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh_CN: Chinese. This is the default value.</description></item>
            /// <item><description>en_US: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The list of task push channels. If this parameter is empty or no channel is enabled, no push is performed.</para>
            /// </summary>
            [NameInMap("pushConfig")]
            [Validation(Required=false)]
            public List<CreateScheduledTaskRequestTriggerConfigPushConfig> PushConfig { get; set; }
            public class CreateScheduledTaskRequestTriggerConfigPushConfig : TeaModel {
                /// <summary>
                /// <para>The notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>hdm_alarm_sms</b>: Text message.</description></item>
                /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
                /// <item><description><b>hdm_alarm_sms_and_email</b>: Text message and email.</description></item>
                /// <item><description><b>hdm_alarm_sms,dingtalk</b>: Text message and DingTalk chatbot.</description></item>
                /// </list>
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
                /// <para>The push method. Default value: channel_bot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>channel_bot</para>
                /// </summary>
                [NameInMap("deliveryMethod")]
                [Validation(Required=false)]
                public string DeliveryMethod { get; set; }

                /// <summary>
                /// <para>Specifies whether the credential is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The file format, such as Excel or CSV.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("fileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>The name of the digital employee (the name of the operating object, optional).</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("operatingObjectName")]
                [Validation(Required=false)]
                public string OperatingObjectName { get; set; }

                /// <summary>
                /// <para>The type of the file receiver. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Private chat.</description></item>
                /// <item><description>1: Group chat.</description></item>
                /// <item><description>2: DingTalk Drive.</description></item>
                /// <item><description>3: Document.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

            }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The trigger mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Manual trigger.</description></item>
            /// <item><description>2: Scheduled trigger.</description></item>
            /// <item><description>3: Code commit trigger.</description></item>
            /// <item><description>5: Pipeline trigger.</description></item>
            /// <item><description>6: WEBHOOK trigger.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

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
        public List<string> VisibleMemberUserIds { get; set; }

    }

}
