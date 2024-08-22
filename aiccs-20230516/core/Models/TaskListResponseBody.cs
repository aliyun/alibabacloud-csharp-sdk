// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskListResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<TaskListResponseBodyModel> Model { get; set; }
        public class TaskListResponseBodyModel : TeaModel {
            /// <summary>
            /// 外呼时间段
            /// </summary>
            [NameInMap("AllowCallTime")]
            [Validation(Required=false)]
            public string AllowCallTime { get; set; }

            /// <summary>
            /// 外呼时间段格式化
            /// </summary>
            [NameInMap("AllowCallTimeFormat")]
            [Validation(Required=false)]
            public string AllowCallTimeFormat { get; set; }

            /// <summary>
            /// 外呼时间
            /// </summary>
            [NameInMap("AllowDayOfWeek")]
            [Validation(Required=false)]
            public string AllowDayOfWeek { get; set; }

            /// <summary>
            /// 外呼类型
            /// </summary>
            [NameInMap("CallType")]
            [Validation(Required=false)]
            public long? CallType { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 闪信模板id
            /// </summary>
            [NameInMap("FlashSmsTemplateId")]
            [Validation(Required=false)]
            public long? FlashSmsTemplateId { get; set; }

            /// <summary>
            /// 闪信模板名称
            /// </summary>
            [NameInMap("FlashSmsTemplateName")]
            [Validation(Required=false)]
            public string FlashSmsTemplateName { get; set; }

            /// <summary>
            /// 发送闪信配置，可选0，1；0表示否，1表示是
            /// </summary>
            [NameInMap("FlashSmsType")]
            [Validation(Required=false)]
            public long? FlashSmsType { get; set; }

            /// <summary>
            /// 最近导入时间
            /// </summary>
            [NameInMap("ImportTime")]
            [Validation(Required=false)]
            public string ImportTime { get; set; }

            /// <summary>
            /// 意向标签列表
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<TaskListResponseBodyModelIntentTags> IntentTags { get; set; }
            public class TaskListResponseBodyModelIntentTags : TeaModel {
                /// <summary>
                /// 意向标签描述
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// 意向标签ID
                /// </summary>
                [NameInMap("IntentTag")]
                [Validation(Required=false)]
                public string IntentTag { get; set; }

            }

            /// <summary>
            /// 接通重呼次数
            /// </summary>
            [NameInMap("InvalidReCall")]
            [Validation(Required=false)]
            public long? InvalidReCall { get; set; }

            /// <summary>
            /// 最后外呼时间
            /// </summary>
            [NameInMap("LastCallTime")]
            [Validation(Required=false)]
            public string LastCallTime { get; set; }

            /// <summary>
            /// 最大并发数
            /// </summary>
            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public long? MaxConcurrency { get; set; }

            /// <summary>
            /// 个性标签列表
            /// </summary>
            [NameInMap("PersonalityTags")]
            [Validation(Required=false)]
            public List<string> PersonalityTags { get; set; }

            /// <summary>
            /// 优先任务
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// 任务所需参数
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// 自动重呼
            /// </summary>
            [NameInMap("RecallType")]
            [Validation(Required=false)]
            public long? RecallType { get; set; }

            /// <summary>
            /// 发送短信
            /// </summary>
            [NameInMap("SendSms")]
            [Validation(Required=false)]
            public long? SendSms { get; set; }

            /// <summary>
            /// 短信模板
            /// </summary>
            [NameInMap("SmsName")]
            [Validation(Required=false)]
            public string SmsName { get; set; }

            /// <summary>
            /// 任务状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 任务ID
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// 任务名称
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// 话术模板Id
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// 话术模板名称
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
