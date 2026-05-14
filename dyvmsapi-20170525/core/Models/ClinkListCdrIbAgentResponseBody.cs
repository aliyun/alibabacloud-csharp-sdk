// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrIbAgentResponseBody : TeaModel {
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
        public ClinkListCdrIbAgentResponseBodyData Data { get; set; }
        public class ClinkListCdrIbAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[座席接听记录列表] #座席接听记录列表</para>
            /// </summary>
            [NameInMap("CdrIbAgent")]
            [Validation(Required=false)]
            public List<ClinkListCdrIbAgentResponseBodyDataCdrIbAgent> CdrIbAgent { get; set; }
            public class ClinkListCdrIbAgentResponseBodyDataCdrIbAgent : TeaModel {
                /// <summary>
                /// <para>及时应答</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentAnswerInTime")]
                [Validation(Required=false)]
                public long? AgentAnswerInTime { get; set; }

                /// <summary>
                /// <para>接听时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public long? AnswerTime { get; set; }

                /// <summary>
                /// <para>接听设备</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BindType")]
                [Validation(Required=false)]
                public long? BindType { get; set; }

                /// <summary>
                /// <para>通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>接听状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("BridgeStatus")]
                [Validation(Required=false)]
                public string BridgeStatus { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("BridgeStatusDetail")]
                [Validation(Required=false)]
                public string BridgeStatusDetail { get; set; }

                /// <summary>
                /// <para>CallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClientName</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>座席电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ClientNumber")]
                [Validation(Required=false)]
                public string ClientNumber { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1122</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户号码城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码，带区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户号码加密串</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerNumberEncrypt")]
                [Validation(Required=false)]
                public string CustomerNumberEncrypt { get; set; }

                /// <summary>
                /// <para>客户号码省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>呼叫类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("DetailCallType")]
                [Validation(Required=false)]
                public string DetailCallType { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>82</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>热线别名</para>
                /// 
                /// <b>Example:</b>
                /// <para>HotlineName</para>
                /// </summary>
                [NameInMap("HotlineName")]
                [Validation(Required=false)]
                public string HotlineName { get; set; }

                /// <summary>
                /// <para>振铃时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbRingingDuration")]
                [Validation(Required=false)]
                public long? IbRingingDuration { get; set; }

                /// <summary>
                /// <para>通话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>medias_1-162046xxxx.12</para>
                /// </summary>
                [NameInMap("MainUniqueId")]
                [Validation(Required=false)]
                public string MainUniqueId { get; set; }

                /// <summary>
                /// <para>座席接起时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("OffhookTime")]
                [Validation(Required=false)]
                public long? OffhookTime { get; set; }

                /// <summary>
                /// <para>挂断方</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("OnHookSource")]
                [Validation(Required=false)]
                public string OnHookSource { get; set; }

                /// <summary>
                /// <para>来电队列名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Qname")]
                [Validation(Required=false)]
                public string Qname { get; set; }

                /// <summary>
                /// <para>来电队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>2233</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>主叫记忆。obRemember: 外呼主叫记忆，ibRemember: 来电主叫记忆</para>
                /// 
                /// <b>Example:</b>
                /// <para>obRemember</para>
                /// </summary>
                [NameInMap("Remember")]
                [Validation(Required=false)]
                public string Remember { get; set; }

                /// <summary>
                /// <para>振铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// <para>语音播报时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("SayVoiceDuration")]
                [Validation(Required=false)]
                public long? SayVoiceDuration { get; set; }

                /// <summary>
                /// <para>呼叫情况</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("SipCauseDesc")]
                [Validation(Required=false)]
                public string SipCauseDesc { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>WebRTCCallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("WebrtcCallId")]
                [Validation(Required=false)]
                public string WebrtcCallId { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>一页展示条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>滚动查询ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ScrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>总条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
