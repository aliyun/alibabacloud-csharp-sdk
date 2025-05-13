// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
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
                /// <para>加微</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AddWx")]
                [Validation(Required=false)]
                public long? AddWx { get; set; }

                /// <summary>
                /// <para>加微进度</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("AddWxStatus")]
                [Validation(Required=false)]
                public string AddWxStatus { get; set; }

                /// <summary>
                /// <para>坐席分机</para>
                /// 
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("AgentExtension")]
                [Validation(Required=false)]
                public string AgentExtension { get; set; }

                /// <summary>
                /// <para>坐席ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <para>人工通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>98</para>
                /// </summary>
                [NameInMap("AgentSpeakingDuration")]
                [Validation(Required=false)]
                public long? AgentSpeakingDuration { get; set; }

                /// <summary>
                /// <para>人工通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("AgentSpeakingTime")]
                [Validation(Required=false)]
                public string AgentSpeakingTime { get; set; }

                /// <summary>
                /// <para>坐席标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("AgentTag")]
                [Validation(Required=false)]
                public string AgentTag { get; set; }

                /// <summary>
                /// <para>是否接通重呼</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("AnswerRecall")]
                [Validation(Required=false)]
                public long? AnswerRecall { get; set; }

                /// <summary>
                /// <para>接通时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-26 18:58:25</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// <para>批次ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// <para>开始通话时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-26 18:58:25</para>
                /// </summary>
                [NameInMap("CallBeginTime")]
                [Validation(Required=false)]
                public string CallBeginTime { get; set; }

                /// <summary>
                /// <para>外呼ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>9197ed9e-ceda-42a5-b683-823b23ef208e</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallTimes")]
                [Validation(Required=false)]
                public string CallTimes { get; set; }

                /// <summary>
                /// <para>外呼类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public long? CallType { get; set; }

                /// <summary>
                /// <para>对话录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ChatRecord")]
                [Validation(Required=false)]
                public string ChatRecord { get; set; }

                /// <summary>
                /// <para>外呼网关</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// <para>挂断时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-26 18:58:25</para>
                /// </summary>
                [NameInMap("HangupTime")]
                [Validation(Required=false)]
                public string HangupTime { get; set; }

                /// <summary>
                /// <para>挂机方式</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HangupType")]
                [Validation(Required=false)]
                public long? HangupType { get; set; }

                /// <summary>
                /// <para>导入时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-26 18:58:25</para>
                /// </summary>
                [NameInMap("ImportTime")]
                [Validation(Required=false)]
                public string ImportTime { get; set; }

                /// <summary>
                /// <para>个性标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("IndividualTag")]
                [Validation(Required=false)]
                public string IndividualTag { get; set; }

                /// <summary>
                /// <para>意向说明</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// <para>意向标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>“C”</para>
                /// </summary>
                [NameInMap("IntentTag")]
                [Validation(Required=false)]
                public string IntentTag { get; set; }

                /// <summary>
                /// <para>拦截原因</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("InterceptReason")]
                [Validation(Required=false)]
                public string InterceptReason { get; set; }

                /// <summary>
                /// <para>回复关键词</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                /// <summary>
                /// <para>外呼号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>138*****123</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>外呼号码MD5</para>
                /// 
                /// <b>Example:</b>
                /// <para>75916b635568954583783d</para>
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// <para>参数</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>振铃时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// <para>挂机短信</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Sms")]
                [Validation(Required=false)]
                public string Sms { get; set; }

                /// <summary>
                /// <para>AI通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("SpeakingDuration")]
                [Validation(Required=false)]
                public long? SpeakingDuration { get; set; }

                /// <summary>
                /// <para>AI通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SpeakingTime")]
                [Validation(Required=false)]
                public string SpeakingTime { get; set; }

                /// <summary>
                /// <para>对话轮次</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpeakingTurns")]
                [Validation(Required=false)]
                public string SpeakingTurns { get; set; }

                /// <summary>
                /// <para>外呼状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>外呼状态编码</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }

                /// <summary>
                /// <para>外呼状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("StatusDescription")]
                [Validation(Required=false)]
                public string StatusDescription { get; set; }

                /// <summary>
                /// <para>用户自定义标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>外呼任务ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>AI话术ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>转人工状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("TransferStatus")]
                [Validation(Required=false)]
                public string TransferStatus { get; set; }

                /// <summary>
                /// <para>转人工状态编码</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TransferStatusCode")]
                [Validation(Required=false)]
                public long? TransferStatusCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

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
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683440860035</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
