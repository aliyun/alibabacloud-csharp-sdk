// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AddTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>外呼时间</para>
        /// </summary>
        [NameInMap("CallTimeList")]
        [Validation(Required=false)]
        public string CallTimeListShrink { get; set; }

        /// <summary>
        /// <para>回调地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>当发送闪信配置为1时，闪信模板ID必填</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("FlashSmsTemplateId")]
        [Validation(Required=false)]
        public long? FlashSmsTemplateId { get; set; }

        /// <summary>
        /// <para>发送闪信配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FlashSmsType")]
        [Validation(Required=false)]
        public long? FlashSmsType { get; set; }

        /// <summary>
        /// <para>并发数</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>任务名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>播放间隔时长</para>
        /// 
        /// <b>Example:</b>
        /// <para>89</para>
        /// </summary>
        [NameInMap("PlaySleepVal")]
        [Validation(Required=false)]
        public long? PlaySleepVal { get; set; }

        /// <summary>
        /// <para>录音播放次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        /// <summary>
        /// <para>重呼配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public long? RecallType { get; set; }

        /// <summary>
        /// <para>录音地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("RecordPath")]
        [Validation(Required=false)]
        public string RecordPath { get; set; }

        /// <summary>
        /// <para>重呼次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("RepeatCount")]
        [Validation(Required=false)]
        public long? RepeatCount { get; set; }

        /// <summary>
        /// <para>重呼间隔</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("RepeatInterval")]
        [Validation(Required=false)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// <para>重呼条件</para>
        /// </summary>
        [NameInMap("RepeatReason")]
        [Validation(Required=false)]
        public string RepeatReasonShrink { get; set; }

        /// <summary>
        /// <para>重呼时间</para>
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
        /// <para>短信发送规则</para>
        /// </summary>
        [NameInMap("SendSmsPlan")]
        [Validation(Required=false)]
        public string SendSmsPlanShrink { get; set; }

        /// <summary>
        /// <para>任务启动日期</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-16</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>任务类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// <para>话术模板ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>话术模板类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
