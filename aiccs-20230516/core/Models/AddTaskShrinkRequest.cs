// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AddTaskShrinkRequest : TeaModel {
        /// <summary>
        /// 外呼时间
        /// </summary>
        [NameInMap("CallTimeList")]
        [Validation(Required=false)]
        public string CallTimeListShrink { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 并发数
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// 任务名称
        /// 
        /// This parameter is required.
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
        public string RepeatReasonShrink { get; set; }

        /// <summary>
        /// 重呼时间
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public string RepeatTimesShrink { get; set; }

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
        public string SendSmsPlanShrink { get; set; }

        /// <summary>
        /// 任务启动日期
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务类型
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

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
