// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class EditTaskRequest : TeaModel {
        /// <summary>
        /// 外呼时间
        /// </summary>
        [NameInMap("CallTimeList")]
        [Validation(Required=false)]
        public List<EditTaskRequestCallTimeList> CallTimeList { get; set; }
        public class EditTaskRequestCallTimeList : TeaModel {
            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public List<string> CallTime { get; set; }

        }

        /// <summary>
        /// 回调地址
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 当发送闪信配置为1时，闪信模板ID必填
        /// </summary>
        [NameInMap("FlashSmsTemplateId")]
        [Validation(Required=false)]
        public long? FlashSmsTemplateId { get; set; }

        /// <summary>
        /// 发送闪信配置,默认为0,0不发送闪信.1发送闪信
        /// </summary>
        [NameInMap("FlashSmsType")]
        [Validation(Required=false)]
        public long? FlashSmsType { get; set; }

        /// <summary>
        /// 并发数
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 播放间隔时长
        /// </summary>
        [NameInMap("PlaySleepVal")]
        [Validation(Required=false)]
        public long? PlaySleepVal { get; set; }

        /// <summary>
        /// 录音播放次数
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        /// <summary>
        /// 重呼配置
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public long? RecallType { get; set; }

        /// <summary>
        /// 录音地址
        /// </summary>
        [NameInMap("RecordPath")]
        [Validation(Required=false)]
        public string RecordPath { get; set; }

        /// <summary>
        /// 重呼次数
        /// </summary>
        [NameInMap("RepeatCount")]
        [Validation(Required=false)]
        public long? RepeatCount { get; set; }

        /// <summary>
        /// 重呼间隔
        /// </summary>
        [NameInMap("RepeatInterval")]
        [Validation(Required=false)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// 重呼条件
        /// </summary>
        [NameInMap("RepeatReason")]
        [Validation(Required=false)]
        public List<long?> RepeatReason { get; set; }

        /// <summary>
        /// 重呼时间
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public List<string> RepeatTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 短信发送规则
        /// </summary>
        [NameInMap("SendSmsPlan")]
        [Validation(Required=false)]
        public List<EditTaskRequestSendSmsPlan> SendSmsPlan { get; set; }
        public class EditTaskRequestSendSmsPlan : TeaModel {
            /// <summary>
            /// 意向标签
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<string> IntentTags { get; set; }

            /// <summary>
            /// 短信模板ID
            /// </summary>
            [NameInMap("SmsTemplateId")]
            [Validation(Required=false)]
            public long? SmsTemplateId { get; set; }

        }

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// 任务id
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// 话术模板ID
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 话术模板类型
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
