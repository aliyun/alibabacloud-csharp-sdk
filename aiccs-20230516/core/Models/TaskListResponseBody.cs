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

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<TaskListResponseBodyModel> Model { get; set; }
        public class TaskListResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>外呼时间段</para>
            /// 
            /// <b>Example:</b>
            /// <para>“8:00~20:30”</para>
            /// </summary>
            [NameInMap("AllowCallTime")]
            [Validation(Required=false)]
            public string AllowCallTime { get; set; }

            /// <summary>
            /// <para>外呼时间段格式化</para>
            /// 
            /// <b>Example:</b>
            /// <para>“8:00 ~ 20:00”</para>
            /// </summary>
            [NameInMap("AllowCallTimeFormat")]
            [Validation(Required=false)]
            public string AllowCallTimeFormat { get; set; }

            /// <summary>
            /// <para>外呼时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>“1,2,3”</para>
            /// </summary>
            [NameInMap("AllowDayOfWeek")]
            [Validation(Required=false)]
            public string AllowDayOfWeek { get; set; }

            /// <summary>
            /// <para>外呼类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("CallType")]
            [Validation(Required=false)]
            public long? CallType { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-05 12:11:11</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>闪信模板id</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FlashSmsTemplateId")]
            [Validation(Required=false)]
            public long? FlashSmsTemplateId { get; set; }

            /// <summary>
            /// <para>闪信模板名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("FlashSmsTemplateName")]
            [Validation(Required=false)]
            public string FlashSmsTemplateName { get; set; }

            /// <summary>
            /// <para>发送闪信配置，可选0，1；0表示否，1表示是</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlashSmsType")]
            [Validation(Required=false)]
            public long? FlashSmsType { get; set; }

            /// <summary>
            /// <para>最近导入时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-05 12:11:11</para>
            /// </summary>
            [NameInMap("ImportTime")]
            [Validation(Required=false)]
            public string ImportTime { get; set; }

            /// <summary>
            /// <para>意向标签列表</para>
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<TaskListResponseBodyModelIntentTags> IntentTags { get; set; }
            public class TaskListResponseBodyModelIntentTags : TeaModel {
                /// <summary>
                /// <para>意向标签描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// <para>意向标签ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("IntentTag")]
                [Validation(Required=false)]
                public string IntentTag { get; set; }

            }

            /// <summary>
            /// <para>接通重呼次数</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("InvalidReCall")]
            [Validation(Required=false)]
            public long? InvalidReCall { get; set; }

            /// <summary>
            /// <para>最后外呼时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-05 12:11:11</para>
            /// </summary>
            [NameInMap("LastCallTime")]
            [Validation(Required=false)]
            public string LastCallTime { get; set; }

            /// <summary>
            /// <para>最大并发数</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public long? MaxConcurrency { get; set; }

            /// <summary>
            /// <para>个性标签列表</para>
            /// </summary>
            [NameInMap("PersonalityTags")]
            [Validation(Required=false)]
            public List<string> PersonalityTags { get; set; }

            /// <summary>
            /// <para>优先任务</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>任务所需参数</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>自动重呼</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RecallType")]
            [Validation(Required=false)]
            public long? RecallType { get; set; }

            /// <summary>
            /// <para>发送短信</para>
            /// 
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("SendSms")]
            [Validation(Required=false)]
            public long? SendSms { get; set; }

            /// <summary>
            /// <para>短信模板</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("SmsName")]
            [Validation(Required=false)]
            public string SmsName { get; set; }

            /// <summary>
            /// <para>任务状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>79</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>任务ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>任务名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>话术模板Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>话术模板名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EFC6D10-307B-1ECA-A8C6-7CBDF776AAD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
