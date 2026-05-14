// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrIbResponseBody : TeaModel {
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
        public ClinkListCdrIbResponseBodyData Data { get; set; }
        public class ClinkListCdrIbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[客户来电记录列表] #客户来电记录列表</para>
            /// </summary>
            [NameInMap("CdrIb")]
            [Validation(Required=false)]
            public List<ClinkListCdrIbResponseBodyDataCdrIb> CdrIb { get; set; }
            public class ClinkListCdrIbResponseBodyDataCdrIb : TeaModel {
                /// <summary>
                /// <para>首次及时应答</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("AgentAnswerInTime")]
                [Validation(Required=false)]
                public string AgentAnswerInTime { get; set; }

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
                /// <para>32</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>首次接听时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public long? BridgeTime { get; set; }

                /// <summary>
                /// <para>业务记录ID</para>
                /// </summary>
                [NameInMap("BusinessIds")]
                [Validation(Required=false)]
                public List<string> BusinessIds { get; set; }

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
                /// <para>客户号码城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码</para>
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
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>是否邀评</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Evaluation")]
                [Validation(Required=false)]
                public string Evaluation { get; set; }

                /// <summary>
                /// <para>首呼座席姓名</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("FirstCallCname")]
                [Validation(Required=false)]
                public string FirstCallCname { get; set; }

                /// <summary>
                /// <para>首呼座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1212</para>
                /// </summary>
                [NameInMap("FirstCallCno")]
                [Validation(Required=false)]
                public string FirstCallCno { get; set; }

                /// <summary>
                /// <para>首呼座席电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("FirstCallNumber")]
                [Validation(Required=false)]
                public string FirstCallNumber { get; set; }

                /// <summary>
                /// <para>首呼队列名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("FirstCallQname")]
                [Validation(Required=false)]
                public string FirstCallQname { get; set; }

                /// <summary>
                /// <para>首呼队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("FirstCallQno")]
                [Validation(Required=false)]
                public string FirstCallQno { get; set; }

                /// <summary>
                /// <para>首次进入队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713848594</para>
                /// </summary>
                [NameInMap("FirstJoinQueueTime")]
                [Validation(Required=false)]
                public long? FirstJoinQueueTime { get; set; }

                /// <summary>
                /// <para>首次离开队列时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("FirstLeaveQueueTime")]
                [Validation(Required=false)]
                public long? FirstLeaveQueueTime { get; set; }

                /// <summary>
                /// <para>首呼队列排队时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("FirstQueueDuration")]
                [Validation(Required=false)]
                public long? FirstQueueDuration { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>热线别名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("HotlineName")]
                [Validation(Required=false)]
                public string HotlineName { get; set; }

                /// <summary>
                /// <para>满意度评价</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("InvestigationKeys")]
                [Validation(Required=false)]
                public long? InvestigationKeys { get; set; }

                /// <summary>
                /// <para>IVR名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

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
                /// <para>备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("MarkData")]
                [Validation(Required=false)]
                public string MarkData { get; set; }

                /// <summary>
                /// <para>挂断方</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("OnHookSource")]
                [Validation(Required=false)]
                public string OnHookSource { get; set; }

                /// <summary>
                /// <para>录音文件</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>rtcUid</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RtcUid")]
                [Validation(Required=false)]
                public string RtcUid { get; set; }

                /// <summary>
                /// <para>语音播报时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("SayVoiceDuration")]
                [Validation(Required=false)]
                public long? SayVoiceDuration { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713848570</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>接听状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("StatusResult")]
                [Validation(Required=false)]
                public string StatusResult { get; set; }

                /// <summary>
                /// <para>机器人接听状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("StatusRobot")]
                [Validation(Required=false)]
                public string StatusRobot { get; set; }

                /// <summary>
                /// <para>通话标签</para>
                /// </summary>
                [NameInMap("TagNames")]
                [Validation(Required=false)]
                public List<string> TagNames { get; set; }

                /// <summary>
                /// <para>工单ID</para>
                /// </summary>
                [NameInMap("TicketIds")]
                [Validation(Required=false)]
                public List<string> TicketIds { get; set; }

                /// <summary>
                /// <para>总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>73</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("UserField")]
                [Validation(Required=false)]
                public string UserField { get; set; }

                /// <summary>
                /// <para>WebRTCCallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("WebrtcCallId")]
                [Validation(Required=false)]
                public string WebrtcCallId { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Xnumber")]
                [Validation(Required=false)]
                public string Xnumber { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713848594</para>
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
            /// <para>69</para>
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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
