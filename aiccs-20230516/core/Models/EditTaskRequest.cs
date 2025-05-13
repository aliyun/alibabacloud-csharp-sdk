// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class EditTaskRequest : TeaModel {
        /// <summary>
        /// <para>外呼时间</para>
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
        /// <para>60</para>
        /// </summary>
        [NameInMap("FlashSmsTemplateId")]
        [Validation(Required=false)]
        public long? FlashSmsTemplateId { get; set; }

        /// <summary>
        /// <para>发送闪信配置,默认为0,0不发送闪信.1发送闪信</para>
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
        /// <para>83</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>任务名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
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
        /// <para>29</para>
        /// </summary>
        [NameInMap("PlaySleepVal")]
        [Validation(Required=false)]
        public long? PlaySleepVal { get; set; }

        /// <summary>
        /// <para>录音播放次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        /// <summary>
        /// <para>重呼配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public long? RecallType { get; set; }

        /// <summary>
        /// <para>录音地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("RecordPath")]
        [Validation(Required=false)]
        public string RecordPath { get; set; }

        /// <summary>
        /// <para>重呼次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("RepeatCount")]
        [Validation(Required=false)]
        public long? RepeatCount { get; set; }

        /// <summary>
        /// <para>重呼间隔</para>
        /// 
        /// <b>Example:</b>
        /// <para>91</para>
        /// </summary>
        [NameInMap("RepeatInterval")]
        [Validation(Required=false)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// <para>重呼条件</para>
        /// </summary>
        [NameInMap("RepeatReason")]
        [Validation(Required=false)]
        public List<long?> RepeatReason { get; set; }

        /// <summary>
        /// <para>重呼时间</para>
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
        /// <para>短信发送规则</para>
        /// </summary>
        [NameInMap("SendSmsPlan")]
        [Validation(Required=false)]
        public List<EditTaskRequestSendSmsPlan> SendSmsPlan { get; set; }
        public class EditTaskRequestSendSmsPlan : TeaModel {
            /// <summary>
            /// <para>意向标签</para>
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<string> IntentTags { get; set; }

            /// <summary>
            /// <para>短信模板ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SmsTemplateId")]
            [Validation(Required=false)]
            public long? SmsTemplateId { get; set; }

        }

        /// <summary>
        /// <para>任务状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>任务id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>话术模板ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
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
