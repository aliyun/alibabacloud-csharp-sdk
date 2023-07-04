// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public TaskCallListResponseBodyModel Model { get; set; }
        public class TaskCallListResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<TaskCallListResponseBodyModelList> List { get; set; }
            public class TaskCallListResponseBodyModelList : TeaModel {
                /// <summary>
                /// 加微
                /// </summary>
                [NameInMap("AddWx")]
                [Validation(Required=false)]
                public long? AddWx { get; set; }

                /// <summary>
                /// 加微进度
                /// </summary>
                [NameInMap("AddWxStatus")]
                [Validation(Required=false)]
                public string AddWxStatus { get; set; }

                /// <summary>
                /// 坐席分机
                /// </summary>
                [NameInMap("AgentExtension")]
                [Validation(Required=false)]
                public string AgentExtension { get; set; }

                /// <summary>
                /// 坐席ID
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// 人工通话时长
                /// </summary>
                [NameInMap("AgentSpeakingDuration")]
                [Validation(Required=false)]
                public long? AgentSpeakingDuration { get; set; }

                /// <summary>
                /// 人工通话时长
                /// </summary>
                [NameInMap("AgentSpeakingTime")]
                [Validation(Required=false)]
                public string AgentSpeakingTime { get; set; }

                /// <summary>
                /// 坐席标签
                /// </summary>
                [NameInMap("AgentTag")]
                [Validation(Required=false)]
                public string AgentTag { get; set; }

                /// <summary>
                /// 是否接通重呼
                /// </summary>
                [NameInMap("AnswerRecall")]
                [Validation(Required=false)]
                public long? AnswerRecall { get; set; }

                /// <summary>
                /// 接通时间
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// 批次ID
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// 开始通话时间
                /// </summary>
                [NameInMap("CallBeginTime")]
                [Validation(Required=false)]
                public string CallBeginTime { get; set; }

                /// <summary>
                /// 外呼ID
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// 呼叫次数
                /// </summary>
                [NameInMap("CallTimes")]
                [Validation(Required=false)]
                public string CallTimes { get; set; }

                /// <summary>
                /// 外呼类型
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public long? CallType { get; set; }

                /// <summary>
                /// 对话录音
                /// </summary>
                [NameInMap("ChatRecord")]
                [Validation(Required=false)]
                public string ChatRecord { get; set; }

                /// <summary>
                /// 外呼网关
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// 挂断时间
                /// </summary>
                [NameInMap("HangupTime")]
                [Validation(Required=false)]
                public string HangupTime { get; set; }

                /// <summary>
                /// 挂机方式
                /// </summary>
                [NameInMap("HangupType")]
                [Validation(Required=false)]
                public long? HangupType { get; set; }

                /// <summary>
                /// 导入时间
                /// </summary>
                [NameInMap("ImportTime")]
                [Validation(Required=false)]
                public string ImportTime { get; set; }

                /// <summary>
                /// 个性标签
                /// </summary>
                [NameInMap("IndividualTag")]
                [Validation(Required=false)]
                public string IndividualTag { get; set; }

                /// <summary>
                /// 意向说明
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// 意向标签
                /// </summary>
                [NameInMap("IntentTag")]
                [Validation(Required=false)]
                public string IntentTag { get; set; }

                /// <summary>
                /// 拦截原因
                /// </summary>
                [NameInMap("InterceptReason")]
                [Validation(Required=false)]
                public string InterceptReason { get; set; }

                /// <summary>
                /// 回复关键词
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                /// <summary>
                /// 外呼号码
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// 外呼号码MD5
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// 参数
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 振铃时长
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// 挂机短信
                /// </summary>
                [NameInMap("Sms")]
                [Validation(Required=false)]
                public string Sms { get; set; }

                /// <summary>
                /// AI通话时长
                /// </summary>
                [NameInMap("SpeakingDuration")]
                [Validation(Required=false)]
                public long? SpeakingDuration { get; set; }

                /// <summary>
                /// AI通话时长
                /// </summary>
                [NameInMap("SpeakingTime")]
                [Validation(Required=false)]
                public string SpeakingTime { get; set; }

                /// <summary>
                /// 对话轮次
                /// </summary>
                [NameInMap("SpeakingTurns")]
                [Validation(Required=false)]
                public string SpeakingTurns { get; set; }

                /// <summary>
                /// 外呼状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 外呼状态编码
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }

                /// <summary>
                /// 外呼状态描述
                /// </summary>
                [NameInMap("StatusDescription")]
                [Validation(Required=false)]
                public string StatusDescription { get; set; }

                /// <summary>
                /// 用户自定义标签
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// 外呼任务ID
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// AI话术ID
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// 转人工状态
                /// </summary>
                [NameInMap("TransferStatus")]
                [Validation(Required=false)]
                public string TransferStatus { get; set; }

                /// <summary>
                /// 转人工状态编码
                /// </summary>
                [NameInMap("TransferStatusCode")]
                [Validation(Required=false)]
                public long? TransferStatusCode { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
