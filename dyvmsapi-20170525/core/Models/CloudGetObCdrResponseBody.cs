// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetObCdrResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudGetObCdrResponseBodyData Data { get; set; }
        public class CloudGetObCdrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席外呼通话记录详情</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudGetObCdrResponseBodyDataList> List { get; set; }
            public class CloudGetObCdrResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>客户接听时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                /// <summary>
                /// <para>通话唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫类型 转移</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>呼叫类型编码，如102</para>
                /// 
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("CallTypeCode")]
                [Validation(Required=false)]
                public string CallTypeCode { get; set; }

                /// <summary>
                /// <para>被叫号码区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("CalleeAreaCode")]
                [Validation(Required=false)]
                public string CalleeAreaCode { get; set; }

                /// <summary>
                /// <para>呼叫的号码，可能是座席也可能是普通电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>01041003090</para>
                /// </summary>
                [NameInMap("CalleeNumber")]
                [Validation(Required=false)]
                public string CalleeNumber { get; set; }

                /// <summary>
                /// <para>外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("Clid")]
                [Validation(Required=false)]
                public string Clid { get; set; }

                /// <summary>
                /// <para>座席工号，如2000</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户侧真实外显号码，当使用AXB场景进行外呼时，客户侧真实外显号码为虚拟号</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("DisplayNumber")]
                [Validation(Required=false)]
                public string DisplayNumber { get; set; }

                /// <summary>
                /// <para>结束原因,接听之后的挂机原因 1000:主通道挂机 1001:非主通道挂机 1002:被强拆</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <para>电话结束时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WH514097</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

                /// <summary>
                /// <para>Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>797880898</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>入队列时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("JoinQueueTime")]
                [Validation(Required=false)]
                public string JoinQueueTime { get; set; }

                /// <summary>
                /// <para>主通话记录来电类型 主叫外呼</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("MainCallType")]
                [Validation(Required=false)]
                public string MainCallType { get; set; }

                /// <summary>
                /// <para>主外呼通话记录唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("MainUniqueId")]
                [Validation(Required=false)]
                public string MainUniqueId { get; set; }

                /// <summary>
                /// <para>队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>131</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>进入队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public List<string> RecordFile { get; set; }

                /// <summary>
                /// <para>响铃时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("RingingTime")]
                [Validation(Required=false)]
                public string RingingTime { get; set; }

                /// <summary>
                /// <para>SIP响应码：200 ~ 699</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public string SipCause { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SipCauseStr")]
                [Validation(Required=false)]
                public string SipCauseStr { get; set; }

                /// <summary>
                /// <para>呼叫客户时间，时间戳，精确到s，如1480904471</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>外呼结果，如接听</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>总通话时长秒数，单位是s</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public string TotalDuration { get; set; }

                /// <summary>
                /// <para>中继群组代号</para>
                /// 
                /// <b>Example:</b>
                /// <para>30019</para>
                /// </summary>
                [NameInMap("TrunkGroupKey")]
                [Validation(Required=false)]
                public string TrunkGroupKey { get; set; }

                /// <summary>
                /// <para>号码状态识别录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>name5</para>
                /// </summary>
                [NameInMap("TsiFile")]
                [Validation(Required=false)]
                public string TsiFile { get; set; }

                /// <summary>
                /// <para>从通道唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>uniq_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("XNumber")]
                [Validation(Required=false)]
                public string XNumber { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9FF70B74-1B3C-44C1-ACDF-8DF962988F0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
