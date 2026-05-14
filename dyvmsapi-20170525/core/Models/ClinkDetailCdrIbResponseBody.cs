// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDetailCdrIbResponseBody : TeaModel {
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
        public ClinkDetailCdrIbResponseBodyData Data { get; set; }
        public class ClinkDetailCdrIbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[客户来电记录详情] #客户来电记录详情</para>
            /// </summary>
            [NameInMap("CdrIbDetail")]
            [Validation(Required=false)]
            public List<ClinkDetailCdrIbResponseBodyDataCdrIbDetail> CdrIbDetail { get; set; }
            public class ClinkDetailCdrIbResponseBodyDataCdrIbDetail : TeaModel {
                /// <summary>
                /// <para>首次及时应答</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
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
                /// <para>17</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>首次接听时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713848599</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public long? BridgeTime { get; set; }

                /// <summary>
                /// <para>CallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>客户号码城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>138xxxx8888</para>
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
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713848599</para>
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
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("FirstCallCname")]
                [Validation(Required=false)]
                public string FirstCallCname { get; set; }

                /// <summary>
                /// <para>首呼座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>2233</para>
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
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("FirstCallQname")]
                [Validation(Required=false)]
                public string FirstCallQname { get; set; }

                /// <summary>
                /// <para>首呼队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>223</para>
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
                /// <para>1713848595</para>
                /// </summary>
                [NameInMap("FirstLeaveQueueTime")]
                [Validation(Required=false)]
                public long? FirstLeaveQueueTime { get; set; }

                /// <summary>
                /// <para>首呼队列排队时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>12233</para>
                /// </summary>
                [NameInMap("FirstQueueDuration")]
                [Validation(Required=false)]
                public long? FirstQueueDuration { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>热线别名</para>
                /// 
                /// <b>Example:</b>
                /// <para>hotline3</para>
                /// </summary>
                [NameInMap("HotlineName")]
                [Validation(Required=false)]
                public string HotlineName { get; set; }

                /// <summary>
                /// <para>[满意度记录] #满意度记录</para>
                /// </summary>
                [NameInMap("Investigation")]
                [Validation(Required=false)]
                public ClinkDetailCdrIbResponseBodyDataCdrIbDetailInvestigation Investigation { get; set; }
                public class ClinkDetailCdrIbResponseBodyDataCdrIbDetailInvestigation : TeaModel {
                    /// <summary>
                    /// <para>座席名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("ClientName")]
                    [Validation(Required=false)]
                    public string ClientName { get; set; }

                    /// <summary>
                    /// <para>座席号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11221</para>
                    /// </summary>
                    [NameInMap("Cno")]
                    [Validation(Required=false)]
                    public string Cno { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483979</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>满意度导航</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("InvestigationName")]
                    [Validation(Required=false)]
                    public string InvestigationName { get; set; }

                    /// <summary>
                    /// <para>按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public long? Keys { get; set; }

                    /// <summary>
                    /// <para>多按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("MultiKeys")]
                    [Validation(Required=false)]
                    public string MultiKeys { get; set; }

                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483974</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>满意度评价</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("InvestigationKeys")]
                [Validation(Required=false)]
                public long? InvestigationKeys { get; set; }

                /// <summary>
                /// <para>[路由和IVR] #路由和IVR</para>
                /// </summary>
                [NameInMap("IvrFlows")]
                [Validation(Required=false)]
                public List<ClinkDetailCdrIbResponseBodyDataCdrIbDetailIvrFlows> IvrFlows { get; set; }
                public class ClinkDetailCdrIbResponseBodyDataCdrIbDetailIvrFlows : TeaModel {
                    /// <summary>
                    /// <para>执行动作</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public long? Action { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483927</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>ivr 名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>78</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public long? Name { get; set; }

                    /// <summary>
                    /// <para>节点 id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>节点名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                    /// <summary>
                    /// <para>按键值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("PressKey")]
                    [Validation(Required=false)]
                    public string PressKey { get; set; }

                    /// <summary>
                    /// <para>按键时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483814</para>
                    /// </summary>
                    [NameInMap("PressTime")]
                    [Validation(Required=false)]
                    public long? PressTime { get; set; }

                    /// <summary>
                    /// <para>路由结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483897</para>
                    /// </summary>
                    [NameInMap("RouterEndTime")]
                    [Validation(Required=false)]
                    public long? RouterEndTime { get; set; }

                    /// <summary>
                    /// <para>路由名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>78</para>
                    /// </summary>
                    [NameInMap("RouterName")]
                    [Validation(Required=false)]
                    public long? RouterName { get; set; }

                    /// <summary>
                    /// <para>路由开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483814</para>
                    /// </summary>
                    [NameInMap("RouterStartTime")]
                    [Validation(Required=false)]
                    public long? RouterStartTime { get; set; }

                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731483814</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>IVR名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
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
                /// <para>mark</para>
                /// </summary>
                [NameInMap("MarkData")]
                [Validation(Required=false)]
                public string MarkData { get; set; }

                /// <summary>
                /// <para>挂断方</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OnHookSource")]
                [Validation(Required=false)]
                public string OnHookSource { get; set; }

                /// <summary>
                /// <para>录音文件</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>rtcUid</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RtcUid")]
                [Validation(Required=false)]
                public string RtcUid { get; set; }

                /// <summary>
                /// <para>语音播报时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
                /// <para>示例值示例值</para>
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
                /// <para>总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>98</para>
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
                /// <para>null</para>
                /// </summary>
                [NameInMap("WebrtcCallId")]
                [Validation(Required=false)]
                public string WebrtcCallId { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Xnumber")]
                [Validation(Required=false)]
                public string Xnumber { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

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
