// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateScheduledTaskRequest : TeaModel {
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
            /// <para>Specifies whether the throttling rule is enabled. A value of true indicates enabled, and a value of false indicates disabled.</para>
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
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object ID. Pass the project task ID.</para>
            /// <list type="bullet">
            /// <item><description><para>For internal enterprise applications, use the taskId obtained by calling the <a href="https://open.dingtalk.com/document/orgapp-server/create-a-project-task">Create a project task</a> operation.</para>
            /// </description></item>
            /// <item><description><para>For third-party enterprise applications, use the taskId obtained by calling the <a href="https://open.dingtalk.com/document/isvapp-server/create-a-project-task">Create a project task</a> operation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type. Fixed value: task, indicating a project task.</para>
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
            /// <para>The HTTP API type. Valid values: Http (standard HTTP API), Rest (RESTful API), WebSocket (WebSocket API), HttpIngress (HTTP API accessed through Ingress), LLM (large language model API), and Agent (Agent proxy API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the current effective digital employee. This parameter is empty if not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
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
            /// <para>Specifies whether to enable this feature.</para>
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
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item, which can be a <b>feedId</b> or a micro-application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The customer type to save.</para>
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
            /// <para>The billing type. Only fixed is supported.</para>
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
            /// <para>The related objects.</para>
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
                /// <para>SampleName.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The object ID. Pass the project task ID.</para>
                /// <list type="bullet">
                /// <item><description><para>For internal enterprise applications, use the taskId obtained by calling the <a href="https://open.dingtalk.com/document/orgapp-server/create-a-project-task">Create a project task</a> operation.</para>
                /// </description></item>
                /// <item><description><para>For third-party enterprise applications, use the taskId obtained by calling the <a href="https://open.dingtalk.com/document/isvapp-server/create-a-project-task">Create a project task</a> operation.</para>
                /// </description></item>
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
                /// <item><description>crm_customer: enterprise customer.</description></item>
                /// <item><description>crm_customer_personal: individual customer.</description></item>
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
            /// <para>The related semantics.</para>
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
            /// <para>The related skills.</para>
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
                /// <para>string_value</para>
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
        public CreateScheduledTaskRequestTriggerConfig TriggerConfig { get; set; }
        public class CreateScheduledTaskRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>The periodic training information in cron syntax (Minutes Hours DayofMonth Month DayofWeek). An empty value indicates that periodic training is not performed (default). In DayofWeek, 0 indicates Sunday.</para>
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
            /// <item><description>zh_CN: Chinese (default)</description></item>
            /// <item><description>en_US: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The list of task push channels. No push is performed if the list is empty or no channel is enabled.</para>
            /// </summary>
            [NameInMap("pushConfig")]
            [Validation(Required=false)]
            public List<CreateScheduledTaskRequestTriggerConfigPushConfig> PushConfig { get; set; }
            public class CreateScheduledTaskRequestTriggerConfigPushConfig : TeaModel {
                /// <summary>
                /// <para>The notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>hdm_alarm_sms</b>: SMS.</description></item>
                /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
                /// <item><description><b>hdm_alarm_sms_and_email</b>: SMS and email.</description></item>
                /// <item><description><b>hdm_alarm_sms,dingtalk</b>: SMS and DingTalk chatbot.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DINGTALK</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>The push content scope. Default value: all_replies.</para>
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
                /// <para>The file format. Valid values: Excel and CSV.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("fileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>The digital employee name (operating object name, optional).</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("operatingObjectName")]
                [Validation(Required=false)]
                public string OperatingObjectName { get; set; }

                /// <summary>
                /// <para>The file receiver type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: One-on-one chat.</para>
                /// </description></item>
                /// <item><description><para>1: Group chat.</para>
                /// </description></item>
                /// <item><description><para>2: DingTalk Drive.</para>
                /// </description></item>
                /// <item><description><para>3: Document.</para>
                /// </description></item>
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
            /// <para>The trigger mode.</para>
            /// <para>  1: Manual trigger</para>
            /// <para>  2: Scheduled trigger </para>
            /// <para>  3: Code commit trigger</para>
            /// <para>  5: Pipeline trigger</para>
            /// <para>  6: WEBHOOK trigger</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

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
        public List<string> VisibleMemberUserIds { get; set; }

    }

}
