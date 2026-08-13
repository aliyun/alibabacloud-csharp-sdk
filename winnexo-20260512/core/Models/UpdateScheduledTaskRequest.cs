// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateScheduledTaskRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public List<UpdateScheduledTaskRequestDescription> Description { get; set; }
        public class UpdateScheduledTaskRequestDescription : TeaModel {
            /// <summary>
            /// <para>文本内容，type=text 时必填</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>功能开关，type=web_search 时可选</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>对象 ID，type=mention 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>对象类型如 customer，type=mention 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>技能编码，type=skill 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>元素类型：text|web_search|mention|skill</para>
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
        /// <para>数字员工名称列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>是否公开访问</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOpen")]
        [Validation(Required=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>执行模型档位；不传则不更新</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("segments")]
        [Validation(Required=false)]
        public List<UpdateScheduledTaskRequestSegments> Segments { get; set; }
        public class UpdateScheduledTaskRequestSegments : TeaModel {
            /// <summary>
            /// <para>文本内容，type=text 时必填</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>功能开关，type=web_search 时可选</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>对象 ID，type=mention 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>对象类型如 customer，type=mention 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>技能编码，type=skill 时有值</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>元素类型：text|web_search|mention|skill</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("taskDetail")]
        [Validation(Required=false)]
        public UpdateScheduledTaskRequestTaskDetail TaskDetail { get; set; }
        public class UpdateScheduledTaskRequestTaskDetail : TeaModel {
            [NameInMap("relatedObjects")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedObjects> RelatedObjects { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedObjects : TeaModel {
                /// <summary>
                /// <para>提及类型，如 objects</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("mentionType")]
                [Validation(Required=false)]
                public string MentionType { get; set; }

                /// <summary>
                /// <para>文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例名称.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>对象 ID（@指定时有值）</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleObjectId</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>对象类型，如 customer、company</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            [NameInMap("relatedSemantics")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedSemantics> RelatedSemantics { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedSemantics : TeaModel {
                /// <summary>
                /// <para>语义属性（JSON 字符串），用于语义检索时过滤</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;level&quot;: &quot;VIP&quot;}</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>语义实体名，如客户/机会</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("entity")]
                [Validation(Required=false)]
                public string Entity { get; set; }

            }

            [NameInMap("relatedSkills")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTaskDetailRelatedSkills> RelatedSkills { get; set; }
            public class UpdateScheduledTaskRequestTaskDetailRelatedSkills : TeaModel {
                /// <summary>
                /// <para>技能展示名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例名称.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>技能代码</para>
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
            /// <para>LLM 润色后的任务理解描述</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("taskUnderstand")]
            [Validation(Required=false)]
            public string TaskUnderstand { get; set; }

        }

        /// <summary>
        /// <para>任务 ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public UpdateScheduledTaskRequestTriggerConfig TriggerConfig { get; set; }
        public class UpdateScheduledTaskRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>Cron 表达式，trigger_mode=scheduled 时必填，如 &quot;00 09 * * *&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>语言如 zh-CN|en-US，由服务端自动注入</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>任务推送频道列表；为空或无启用频道时不推送</para>
            /// </summary>
            [NameInMap("pushConfig")]
            [Validation(Required=false)]
            public List<UpdateScheduledTaskRequestTriggerConfigPushConfig> PushConfig { get; set; }
            public class UpdateScheduledTaskRequestTriggerConfigPushConfig : TeaModel {
                /// <summary>
                /// <para>推送渠道</para>
                /// 
                /// <b>Example:</b>
                /// <para>DINGTALK</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>推送内容范围，默认 all_replies</para>
                /// 
                /// <b>Example:</b>
                /// <para>all_replies</para>
                /// </summary>
                [NameInMap("contentScope")]
                [Validation(Required=false)]
                public string ContentScope { get; set; }

                /// <summary>
                /// <para>推送方式，默认 channel_bot</para>
                /// 
                /// <b>Example:</b>
                /// <para>channel_bot</para>
                /// </summary>
                [NameInMap("deliveryMethod")]
                [Validation(Required=false)]
                public string DeliveryMethod { get; set; }

                /// <summary>
                /// <para>是否推送该频道，默认关闭</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>产出文件推送格式，默认 file</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("fileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>发送机器人所属数字员工，必传且不可为空</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("operatingObjectName")]
                [Validation(Required=false)]
                public string OperatingObjectName { get; set; }

                /// <summary>
                /// <para>接收人，当前仅支持 self</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

            }

            /// <summary>
            /// <para>时区如 Asia/Shanghai，由服务端自动注入</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>触发模式：manual|scheduled</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

    }

}
