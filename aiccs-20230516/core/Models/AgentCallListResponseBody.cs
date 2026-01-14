// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentCallListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public AgentCallListResponseBodyModel Model { get; set; }
        public class AgentCallListResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<AgentCallListResponseBodyModelList> List { get; set; }
            public class AgentCallListResponseBodyModelList : TeaModel {
                /// <summary>
                /// <para>坐席分机</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("AgentExtension")]
                [Validation(Required=false)]
                public string AgentExtension { get; set; }

                /// <summary>
                /// <para>分配坐席ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <para>坐席通话时长，单位：秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentSpeakingDuration")]
                [Validation(Required=false)]
                public long? AgentSpeakingDuration { get; set; }

                /// <summary>
                /// <para>坐席通话时长，单位：大于1分钟，显示分钟秒，小于1分钟，显示秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentSpeakingTime")]
                [Validation(Required=false)]
                public string AgentSpeakingTime { get; set; }

                /// <summary>
                /// <para>坐席标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("AgentTag")]
                [Validation(Required=false)]
                public string AgentTag { get; set; }

                /// <summary>
                /// <para>接通时间 格式：2019-11-23 14:47:06</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-23 14:47:06</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// <para>导入号码时返回的批次号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// <para>开始通话时间, 格式：2019-11-23 14:47:06</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-23 14:47:06</para>
                /// </summary>
                [NameInMap("CallBeginTime")]
                [Validation(Required=false)]
                public string CallBeginTime { get; set; }

                /// <summary>
                /// <para>外呼ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>可选项：1001：坐席-人工外呼，1002：坐席-AI外呼-不转人工，1003：坐席-AI外呼-接通转人工，1004：坐席-AI外呼-智能转人工；</para>
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
                /// <para>URL</para>
                /// </summary>
                [NameInMap("ChatRecord")]
                [Validation(Required=false)]
                public string ChatRecord { get; set; }

                /// <summary>
                /// <para>挂断时间 格式：2019-11-23 14:47:06</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-23 14:47:06</para>
                /// </summary>
                [NameInMap("HangupTime")]
                [Validation(Required=false)]
                public string HangupTime { get; set; }

                /// <summary>
                /// <para>挂机方式  AI挂机1，坐席挂机2，客户挂机3</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HangupType")]
                [Validation(Required=false)]
                public long? HangupType { get; set; }

                /// <summary>
                /// <para>导入时间,格式：2019-11-23 14:47:06</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-23 14:47:06</para>
                /// </summary>
                [NameInMap("ImportTime")]
                [Validation(Required=false)]
                public string ImportTime { get; set; }

                /// <summary>
                /// <para>个性标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>如投诉,非本人</para>
                /// </summary>
                [NameInMap("IndividualTag")]
                [Validation(Required=false)]
                public string IndividualTag { get; set; }

                /// <summary>
                /// <para>意向说明 如：确认本人,未承诺还款</para>
                /// 
                /// <b>Example:</b>
                /// <para>如：确认本人</para>
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// <para>意向标签, 如“C”</para>
                /// 
                /// <b>Example:</b>
                /// <para>C</para>
                /// </summary>
                [NameInMap("IntentTag")]
                [Validation(Required=false)]
                public string IntentTag { get; set; }

                /// <summary>
                /// <para>拦截原因 当状态为已拦截时，可选值：黑名单拦截，灰名单拦截，异常号码拦截</para>
                /// 
                /// <b>Example:</b>
                /// <para>黑名单拦截</para>
                /// </summary>
                [NameInMap("InterceptReason")]
                [Validation(Required=false)]
                public string InterceptReason { get; set; }

                /// <summary>
                /// <para>回复关键词</para>
                /// 
                /// <b>Example:</b>
                /// <para>如链接,利息</para>
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                /// <summary>
                /// <para>外呼号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>外呼号码MD5</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// <para>导入号码时的参数值</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;电话号码&quot;:&quot;13100000000&quot;}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>人工备注信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>振铃时长 单位：毫秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// <para>挂机短信 1:发送，2:不发送</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sms")]
                [Validation(Required=false)]
                public string Sms { get; set; }

                /// <summary>
                /// <para>通话时长 单位：秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpeakingDuration")]
                [Validation(Required=false)]
                public long? SpeakingDuration { get; set; }

                /// <summary>
                /// <para>通话时长 单位：大于1分钟，显示分钟秒，小于1分钟，显示秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpeakingTime")]
                [Validation(Required=false)]
                public string SpeakingTime { get; set; }

                /// <summary>
                /// <para>对话轮次</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpeakingTurns")]
                [Validation(Required=false)]
                public string SpeakingTurns { get; set; }

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
                /// <para>外呼状态，如“已接听”“拒接”，转外呼状态编码与描述对应 1-已接听,2-关机</para>
                /// 
                /// <b>Example:</b>
                /// <para>已接听</para>
                /// </summary>
                [NameInMap("StatusDescription")]
                [Validation(Required=false)]
                public string StatusDescription { get; set; }

                /// <summary>
                /// <para>用户自定义标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>外呼任务ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>AI话术ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>转人工状态 0-未触发</para>
                /// 
                /// <b>Example:</b>
                /// <para>未触发</para>
                /// </summary>
                [NameInMap("TransferStatus")]
                [Validation(Required=false)]
                public string TransferStatus { get; set; }

                /// <summary>
                /// <para>转人工状态编码</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TransferStatusCode")]
                [Validation(Required=false)]
                public long? TransferStatusCode { get; set; }

                /// <summary>
                /// <para>转接人工时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-09 14:14:19</para>
                /// </summary>
                [NameInMap("TransferTime")]
                [Validation(Required=false)]
                public string TransferTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
